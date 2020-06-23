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
   
    public partial class AD_Stock : Form
    {
        private Form frmSTC;
        public AD_Stock(Form stc)
        {
            frmSTC = stc;
            InitializeComponent();
        }

        private void cmb_Depo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto_comp elegido = (Producto_comp)cmb_Depo.SelectedItem;
            txt_Cant.Text = "0";
            txt_Precio.Text = elegido.prec.ToString();
            fecha_Compra.MinDate = elegido.date;
            fecha_Compra.MaxDate = DateTime.MaxValue;
        }

        private void AD_Stock_Load(object sender, EventArgs e)
        {
            cmb_Depo.Items.AddRange(Program.getSistema().getDeposito().ToArray());
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            Producto_comp elegido = (Producto_comp)cmb_Depo.SelectedItem;

            string name = elegido.Nombre;
            int article = elegido.cod_articulo;
            Proveedor provider = elegido.Proveedor;
            int quant =  Int32.Parse(txt_Cant.Text)+ elegido.cantidad;
            double cost = double.Parse(txt_Precio.Text);
            DateTime fecha = fecha_Compra.Value;

            //FALTAN CAMPOS
            if (name == null || quant == 0 || cost == 0 || (Producto_comp)cmb_Depo.SelectedItem == null)
            { MessageBox.Show("Complete todos los campos "); return; };

            //crea nuevo producto
            Producto_comp prod = new Producto_comp(name, article, provider, quant, cost , fecha);
            //borra antiguo
            Program.getSistema().QuitarProducto(elegido);
            //carga nuevo
            Program.getSistema().agregarProducto(prod , Int32.Parse(txt_Cant.Text));

            MessageBox.Show("SE AGREGO STOCK CORRECTAMENTE");
            frmSTC.Show();
            this.Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            frmSTC.Show();
            this.Hide();
            
        }
    }
}
