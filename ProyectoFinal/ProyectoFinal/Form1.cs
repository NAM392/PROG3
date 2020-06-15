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
    public partial class STC : Form
    {
        private Sistema_Rep sistema;
        private frmMetodo Metodo;
        private Item items;
        
        public STC()
        {
            InitializeComponent();
            sistema = new Sistema_Rep();
            Metodo = new frmMetodo( this ,  sistema );
            items = new Item(this);
            // IT = new Item(); si instancio aqui cae en un bucle infinito

        }



        private void btn_sold_Click(object sender, EventArgs e)
        {
            Metodo.Show();
            this.Hide();


        }

        private void btn_ADitem_Click(object sender, EventArgs e)
        {
            
            items.Show();
            this.Hide();
            

        }

        private void STC_Load(object sender, EventArgs e)
        {

        }
    }
}
