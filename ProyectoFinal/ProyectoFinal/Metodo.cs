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

    public partial class frmMetodo : Form
    {
        private Form frmSTC;
        private Precio precio;
        private Sistema_Rep Deposito; 
        public frmMetodo(Form stc , object sistema )
        {
            frmSTC = stc ;
            Deposito = (Sistema_Rep)sistema;
            
            InitializeComponent();
        }

        private void frmMetodo_Load(object sender, EventArgs e)
        {
            ActualizarLista();
           
        }

        
        private void cmb_Todos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto_comp elegido = (Producto_comp)cmb_Todos.SelectedItem;

            //FIFO
            lbl_FIFO.Text = Sistema_Rep.FIFO(elegido);

            //LIFO
            lbl_LIFO.Text = Sistema_Rep.LIFO(elegido);

            //PPP  
            lbl_PPP.Text = Sistema_Rep.PPP(elegido);
        }
        public void ActualizarLista()
        {
            cmb_Todos.Items.Clear();
            cmb_Todos.Items.AddRange(Deposito.getSistema().ToArray());
            txtCant.Text = "0";
            txt_Margen.Text = "0";

        }

        private void btn_LFP_Click(object sender, EventArgs e)
        {
            Producto_comp elegido = (Producto_comp)cmb_Todos.SelectedItem;
            double precio_final = 0;

            //sin stock
            if (elegido.cant < int.Parse(txtCant.Text))
            {
                MessageBox.Show("NO HAY STOCK");
                return;
            }
            // % mayor a 100
            if (int.Parse(txt_Margen.Text) > 100 )
            {
                MessageBox.Show(" MARGEN MAYOR A 100%  ");
                return;
            }
            // % 0
            if (int.Parse(txt_Margen.Text) <= 0)
            {
                MessageBox.Show(" MARGEN 0 ");
                return;
            }
            precio_final = PrecioFinal(elegido);

            precio = new Precio(frmSTC, this, Deposito, elegido , precio_final );

            precio.Show();
            this.Hide();
        }

        private void lbl_FIFO_Click(object sender, EventArgs e)
        {

        }

        public double PrecioFinal(object elegido)
        {
            int cantidad = int.Parse(txtCant.Text);
            Producto_comp Elegido = (Producto_comp)elegido;
            double MU = 0;

            //elegi FIFO
            if (OP_FIFO.Checked == true)
           {
                double SelFifo = double.Parse(Sistema_Rep.FIFO(Elegido));
               MU = MargenUtilidadTotal(SelFifo);
            }

            //elegi LIFO
            if (OP_LIFO.Checked == true)
            {
                double SelLifo = double.Parse(Sistema_Rep.LIFO(Elegido));
                MU = MargenUtilidadTotal(SelLifo);

            }

            //elegi PPP
            if (OP_PPP.Checked == true)
            {
                double SelPPP = double.Parse(Sistema_Rep.PPP(Elegido));
                MU = MargenUtilidadTotal(SelPPP);

            }


            return (MU * cantidad);
        }
        
        public double MargenUtilidadTotal ( double costo )
        {
            double margen_ut = double.Parse(txt_Margen.Text);

            double total = costo + (costo * (margen_ut/100));

          return total;
        }

        private void grpCosteo_Enter(object sender, EventArgs e)
        {

        }
    }
}
