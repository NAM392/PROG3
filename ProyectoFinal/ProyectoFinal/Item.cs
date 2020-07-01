using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
   
    public partial class Item : Form
    {
        private Form stac;
        private string codigo;
        private string nombre;
        public Item( Form Stac )
        {
            stac = Stac;
            InitializeComponent();
            
        }
        //SOBRECARGA PARA DIFERENCIAR CUANDO VENGO DE UN PROVEEDOR CREADO O CUANDO SOLO INICIO ESTE FORM
        public Item(Form Stac , string Nombre , string Codigo)
        {
            stac = Stac;
            nombre = Nombre;
            codigo = Codigo;
            InitializeComponent();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            
            string name = txtNom.Text;
            int article = Int32.Parse(txt_CodProd.Text);
            Proveedor provider = (Proveedor)cmb_Proveedor.SelectedItem;
            int quant = Int32.Parse(txt_Cant.Text);
            double cost = double.Parse(txt_Precio.Text);
            DateTime fecha = Fecha_Date.Value;
            //YA EXISTE ESE CODIGO DE PRODUCTO
            List<Producto_comp> Deposito = Program.getSistema().getDeposito();
            foreach(var d in Deposito)
            {
               if( d.cod_articulo == Int32.Parse(txt_CodProd.Text)) 
                { 
                    MessageBox.Show("YA EXISTE ESE CODIGO DE PRODUCTO");
                    return;
                }

            }
            //FALTAN CAMPOS
            if (article == 0 || name == null || quant == 0 || cost == 0 || (Proveedor)cmb_Proveedor.SelectedItem == null || article==null)
                { MessageBox.Show("Complete todos los campos "); return; };

            //CREO UN NUEVO PRODUCTO 
            Producto_comp prod = Program.getSistema().NuevoProducto(name, article, provider, quant, cost , fecha);
            //PONGO ESTE NUEVO PRODUCTO EN LA LISTA DE PRODUCTOS QUE VIVE EN SISTEMA
            Program.getSistema().agregarProducto(prod);
            
            MessageBox.Show("SE INGRESO EL PRODUCTO CORRECTAMENTE");
            LimpiarLista();
            stac.Show();
            this.Hide();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            this.ttmensaje.SetToolTip(AD_prov, "AGREGAR UN PROVEEDOR");
            LimpiarLista();
        }
        public void LimpiarLista()
        {
            if(codigo == null) { txt_CodProd.Text = "0"; }
            else { txt_CodProd.Text = codigo; };

            if(nombre == null) { txtNom.Text = ""; }
            else { txtNom.Text = nombre; }

            txtNom.MaxLength = 10;
            txt_CodProd.MaxLength = 6;
            cmb_Proveedor.Items.Clear();
            cmb_Proveedor.Items.AddRange(Program.getSistema().getProveedor().ToArray());
            txt_Cant.Text = "0";
            txt_Cant.MaxLength = 6;
            txt_Precio.Text = "0";
            txt_Precio.MaxLength = 6;
            txtNom.Focus();
                      
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            stac.Show();
            this.Hide();
        }

        private void btn_new_Proveedor_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewProvider np = new NewProvider(stac, this, txtNom.Text, txt_CodProd.Text);
            
            np.Show();
            this.Hide();

        }

        private void txt_CodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NumeroEnteros(e);
        }

        private void txt_Cant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Cant_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_Cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NumeroEnteros(e);
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NumeroDecimal(e);
        }
    }
    }

