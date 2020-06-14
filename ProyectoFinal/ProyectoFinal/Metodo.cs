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
            precio = new Precio(this , Deposito);
            InitializeComponent();
        }

        private void frmMetodo_Load(object sender, EventArgs e)
        {
            ActualizarLista();
           
        }

        
        private void cmb_Todos_SelectedIndexChanged(object sender, EventArgs e)
        {

            //FIFO
            lbl_FIFO.Text = Sistema_Rep.FIFO((Producto_comp)cmb_Todos.SelectedItem);

            //LIFO
            lbl_LIFO.Text = Sistema_Rep.LIFO((Producto_comp)cmb_Todos.SelectedItem);

            //PPP  
            lbl_PPP.Text = Sistema_Rep.PPP((Producto_comp)cmb_Todos.SelectedItem);


        }
        public void ActualizarLista()
        {
            cmb_Todos.Items.Clear();
            cmb_Todos.Items.AddRange(Deposito.getSistema().ToArray());

            /*
            if (Sistema_Rep.GetProductos() == null) { MessageBox.Show("cree un item"); }
            else
            {  */






        }

        private void btn_LFP_Click(object sender, EventArgs e)
        {
            precio.Show();
            this.Hide();
        }

        private void lbl_FIFO_Click(object sender, EventArgs e)
        {

        }
    }
}
