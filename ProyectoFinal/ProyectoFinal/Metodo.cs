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
            frmSTC = stc ;  //REFERENCIA AL FORM INICIAL
            Deposito = (Sistema_Rep)sistema; // REFERENCIA A LA CLASE Sistema_Rep que se instancio en el primer form
            
            InitializeComponent();
        }

        private void frmMetodo_Load(object sender, EventArgs e)
        {
            //ACTUALIZA LISTA CUANDO SE CREA UN NUEVO FORM METODO
            ActualizarLista();
           
        }

        
        private void cmb_Todos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MUESTRA EL PRELIMINAR DEL COSTEO , EL LBL QUE TE DICE POR CUANTO SE CALCULARIA
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
            OP_FIFO.Checked = false;
            OP_LIFO.Checked = false;
            OP_PPP.Checked = false;

        }

        private void btn_LFP_Click(object sender, EventArgs e)
        {
            //BOTON ACEPTAR FORM METODO
            Producto_comp elegido = (Producto_comp)cmb_Todos.SelectedItem;
            double precio_final = 0;
            int cantidad = int.Parse(txtCant.Text);
            /*ERRORES AL INGRESO*/


            //arreglar error al no ingresar absolutamente nada y apretar aceptar

            //sin stock
            if (elegido.cant < int.Parse(txtCant.Text))
            {
                MessageBox.Show("NO HAY STOCK");
                return;
            }
            //no elije cantidad
            if ( int.Parse(txtCant.Text) <= 0 )
            {
                MessageBox.Show("INGRESE CANTIDAD");
                return;
            }
            // % mayor a 100
            if (int.Parse(txt_Margen.Text) > 100 )
            {
                MessageBox.Show(" MARGEN MAYOR A 100%  ");
                return;
            }
            // margen 0
            if (int.Parse(txt_Margen.Text) <= 0)
            {
                MessageBox.Show(" INGRESE MARGEN DE UTILIDAD ");
                return;
            }
            //no eligio costeo
            if(OP_FIFO.Checked == false && OP_LIFO.Checked == false && OP_PPP.Checked == false)
            {
                MessageBox.Show(" INGRESE METODO DE COSTEO ");
                return;
            }
            precio_final = Math.Round(PrecioFinal(elegido));
             

            precio = new Precio(frmSTC, this, Deposito, elegido , precio_final , cantidad);

            precio.Show();
            this.Hide();

            //funcion de seleccion metodo de costeo
             double PrecioFinal(object seleccionado)
            {
                
                double MU = 0;

                //elegi FIFO
                if (OP_FIFO.Checked == true)
                {
                    double SelFifo = double.Parse(lbl_FIFO.Text);
                      MU = MargenUtilidadTotal(SelFifo);
                }

                //elegi LIFO
                if (OP_LIFO.Checked == true)
                {
                    double SelLifo = double.Parse(lbl_LIFO.Text);
                    MU = MargenUtilidadTotal(SelLifo);
                }

                //elegi PPP
                if (OP_PPP.Checked == true)
                {                    
                    double SelPPP = double.Parse(lbl_PPP.Text);
                    MU = MargenUtilidadTotal(SelPPP);
                }


                return (MU * cantidad);
            }
            //funcion de costo + margen utilidad
            double MargenUtilidadTotal(double costo)
            {
                double margen_ut = double.Parse(txt_Margen.Text);

                double total = costo + (costo * (margen_ut / 100));

                return total;
            }
        }

        private void lbl_FIFO_Click(object sender, EventArgs e)
        {

        }



        private void grpCosteo_Enter(object sender, EventArgs e)
        {

        }
    }
}
