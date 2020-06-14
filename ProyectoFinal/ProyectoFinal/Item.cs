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
            int provider = Int32.Parse(txt_Prov.Text);
            int quant = Int32.Parse(txt_Cant.Text);
            double cost = double.Parse(txt_Precio.Text);

            Producto_comp prod = new Producto_comp(name, article, provider, quant, cost);

            Sistema_Rep.agregarProducto(prod);
            
            MessageBox.Show("SE INGRESO EL PRODUCTO CORRECTAMENTE");
            LimpiarLista();
            stac.Show();
            this.Hide();

        }

        private void Item_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarLista()
        {

            txtNom.Clear();
            txt_CodProd.Clear();
            txt_Prov.Clear();
            txt_Cant.Clear();
            txt_Precio.Clear();


        }













    }
}
