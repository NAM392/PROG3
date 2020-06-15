using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DemoProductos
{
   public partial class Form1 : Form
   {
      List<Producto> Productos = new List<Producto>();

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         //Producto Producto1 = new Producto();

         //Producto1.SKU = "2020";
         //Producto1.Descripcion = "Babita";
         //Producto1.Proveedor = "Proveedor ABC";
         //Producto1.Cantidad = 600;
         //Producto1.Precio = 200.5m;
         //Productos.Add(Producto1);

         //Producto Producto2 = new Producto();
         //Producto2.SKU = "3020";
         //Producto2.Descripcion = "Ranita";
         //Producto2.Proveedor = "Proveedor FGH";
         //Producto2.Cantidad = 320;
         //Producto2.Precio = 320.5m;
         //Productos.Add(Producto2);

         Deserializar();

         dgvDatos.DataSource = Productos;
      }

      private void btnCargar_Click(object sender, EventArgs e)
      {
         //if (txtSku.Text == "")
         //{
         //   //MessageBox.Show("Debe ingresar el SKU", "Error");
         //   errorProvider1.SetError(txtSku, "Debe ingrear el SKU");
         //   txtSku.Focus();
         //   return;
         //}
         //errorProvider1.SetError(txtSku, "");

         if (!ValidarSKU()) return;

         //Valida si existe o no el SKU
         if (Existe(txtSku.Text))
         { //valida si existe o no el sku del producto
            errorProvider1.SetError(txtSku, "SKU existente - Debe ingrear un nuevo SKU");
            txtSku.Focus();
            return;
         }

         if (!ValidarOtrosCampos()) return;

         

         Producto miProducto = new Producto();
         miProducto.SKU = txtSku.Text;
         miProducto.Cantidad = Convert.ToInt32(txtCantidad.Text);
         miProducto.Descripcion = txtDescripcion.Text;
         miProducto.Precio = Convert.ToDecimal(txtPrecio.Text);
         miProducto.Proveedor = txtProveedor.Text;
         
         Productos.Add(miProducto);
         dgvDatos.DataSource = null;
         dgvDatos.DataSource = Productos;

         txtSku.Clear();
         txtCantidad.Clear();
         txtDescripcion.Clear();
         txtPrecio.Clear();
         txtProveedor.Clear();
         txtSku.Focus();

      }

      //Para validar si existe o no el sku producto
      private bool Existe(string SKU)
      {
         foreach (Producto producto in Productos)
         {
            if (producto.SKU == SKU) return true;
         }
         return false;
      }

      //----Validar SKU----
      private void btnModificar_Click(object sender, EventArgs e)
      {
         if (!ValidarSKU()) return;

         Producto miProducto = GetProducto(txtSku.Text);//Paso el producto tecleado
         if (miProducto == null)
         {
            errorProvider1.SetError(txtSku, "Producto inexistente");
            txtSku.Focus();
            return;
         }

         txtDescripcion.Text = miProducto.Descripcion;
         txtCantidad.Text = miProducto.Cantidad.ToString();
         txtPrecio.Text = miProducto.Precio.ToString();
         txtProveedor.Text = miProducto.Proveedor;

      }

      private bool ValidarSKU()
      {
         if(txtSku.Text == "")
         {
            errorProvider1.SetError(txtSku, "Debe ingrear el SKU");
            txtSku.Focus();
            return false;
         }
         errorProvider1.SetError(txtSku, "");
         return true;
      }

      private Producto GetProducto(string sku)
      {
         foreach (Producto miProducto in Productos)
         {
            if (miProducto.SKU == sku) return miProducto;
         }
         return null; //xq no existe el producto
      }

      private void btnModifica_Click(object sender, EventArgs e)
      {
         if (!ValidarSKU()) return; //valido si existe el sku

         if (GetProducto(txtSku.Text) == null) //si no existe el sku
         {
            errorProvider1.SetError(txtSku, "Producto inexistente");
            txtSku.Focus();
            return;
         }
         errorProvider1.SetError(txtSku, "");

         // debo validar todo idem como nuevo ->
         if (!ValidarOtrosCampos()) return;

         foreach (Producto miProducto in Productos)
         {
            if (miProducto.SKU == txtSku.Text)
            {
               miProducto.Cantidad = Convert.ToInt32(txtCantidad.Text);
               miProducto.Descripcion = txtDescripcion.Text;
               miProducto.Precio = Convert.ToDecimal(txtPrecio.Text);
               miProducto.Proveedor = txtProveedor.Text;
               break; //salgo 
            }
         }
         dgvDatos.DataSource = null;
         dgvDatos.DataSource = Productos;
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         BinaryFormatter formateador = new BinaryFormatter();
         Stream miStream = new FileStream("back.bnn", FileMode.Create, FileAccess.Write, FileShare.None);
         formateador.Serialize(miStream, Productos);
         miStream.Close();
      }

      private void Deserializar()
      {
         if (File.Exists("back.bnn"))
         {
            Stream miStream = File.OpenRead("back.bnn");
            BinaryFormatter deserializer = new BinaryFormatter();
            Productos = (List<Producto>)deserializer.Deserialize(miStream);
            miStream.Close();
         }
      }

      private bool ValidarOtrosCampos()
      {

         int auxCant;

         if (!int.TryParse(txtCantidad.Text, out auxCant))
         {
            errorProvider2.SetError(txtCantidad, "Debe ingrear números enteros en la Cantidad");
            txtCantidad.Focus();
            return false;
         }
         if (auxCant < 0)
         {
            errorProvider2.SetError(txtCantidad, "Debe ingrear números positivos en la Cantidad");
            txtCantidad.Focus();
            return false;
         }

         errorProvider2.SetError(txtCantidad, "");

         if (txtDescripcion.Text == "")
         {
            errorProvider3.SetError(txtDescripcion, "Debe ingrear la Descripcion");
            txtDescripcion.Focus();
            return false;
         }
         errorProvider3.SetError(txtDescripcion, "");

         decimal auxPrecio;//para convertir el importe
         if (!Decimal.TryParse(txtPrecio.Text, out auxPrecio))
         {
            errorProvider4.SetError(txtPrecio, "Debe ingrear números en el campo Precio");
            txtPrecio.Focus();
            return false;
         }
         if (auxPrecio < 0)
         {
            errorProvider4.SetError(txtPrecio, "Debe ingrear números positivos en el campo Precio");
            txtPrecio.Focus();
            return false;
         }

         errorProvider4.SetError(txtPrecio, "");


         if (txtProveedor.Text == "")
         {
            errorProvider5.SetError(txtProveedor, "Debe ingrear el Proveedor");
            txtProveedor.Focus();
            return false;
         }
         errorProvider5.SetError(txtProveedor, "");

         return true;
      }

      private void btnLimpiar_Click(object sender, EventArgs e)
      {
         txtSku.Clear();
         txtCantidad.Clear();
         txtDescripcion.Clear();
         txtPrecio.Clear();
         txtProveedor.Clear();
      }

      private void btnBorrar_Click(object sender, EventArgs e)
      {
         DialogResult rta = MessageBox.Show(this, "¿Esta seguro de borrar?", 
            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
         //valido si existe o no el registro a borrar 

         if (rta == DialogResult.No) return; //salgo si no quiero borra

         if (!ValidarSKU()) return; //valido si existe el sku

         if (GetProducto(txtSku.Text) == null) //si no existe el sku
         {
            errorProvider1.SetError(txtSku, "Producto inexistente");
            txtSku.Focus();
            return;
         }
         errorProvider1.SetError(txtSku, "");

         foreach (Producto miProducto in Productos)
         {
            if (miProducto.SKU == txtSku.Text)
            {
               Productos.Remove(miProducto);
               break; //salgo del siclo.
            }
         }
         //Actualizo la cuadricula
         btnLimpiar_Click(sender, e);//llamada al botón
         dgvDatos.DataSource = null;
         dgvDatos.DataSource = Productos;

      }
   }
}
