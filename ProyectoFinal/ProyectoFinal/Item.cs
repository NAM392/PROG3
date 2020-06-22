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
        public Item( Form Stac )
        {
            stac = Stac;
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

            //FALTAN CAMPOS
            if (article == 0 || name == null && quant == 0 || cost == 0 || (Proveedor)cmb_Proveedor.SelectedItem == null)
                { MessageBox.Show("Complete todos los campos "); return; };

            Producto_comp prod = new Producto_comp(name, article, provider, quant, cost , fecha);



            Program.getSistema().agregarProducto(prod);
            
            MessageBox.Show("SE INGRESO EL PRODUCTO CORRECTAMENTE");
            LimpiarLista();
            stac.Show();
            this.Hide();
            
            
        }

        private void Item_Load(object sender, EventArgs e)
        {
            
            LimpiarLista();

        }
        public void LimpiarLista()
        {
            txtNom.Text = " ";
            txt_CodProd.Text = "0";
            cmb_Proveedor.Items.Clear();
            cmb_Proveedor.Items.AddRange(Program.getSistema().getProveedor().ToArray());
            txt_Cant.Text = "0";
            txt_Precio.Text = "0";
            txtNom.Focus();
                      
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            stac.Show();
            this.Hide();
        }
    }











    }

