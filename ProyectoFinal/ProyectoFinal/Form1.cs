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
        private Form login;
        private Sistema_Rep sistema;
        private frmMetodo Metodo;
        private Item items;
        private Ver_Stock stock;
        private AD_Stock agregar;
        
        public STC(Form log)
        {
            InitializeComponent();
            sistema = Program.getSistema();           
            login = log;
        }



        private void btn_sold_Click(object sender, EventArgs e)
        {
            /*BOTON VENDER PRODUCTO*/
            Metodo = new frmMetodo(this, sistema); //creo un nuevo form metodo aqui para referescar la lista
            Metodo.Show();
            this.Hide();

        }

        private void btn_ADitem_Click(object sender, EventArgs e)
        {
            /*BOTON CREAR ITEM */
            items = new Item(this);
            items.Show();
            this.Hide();         

        }

        private void STC_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_shStock_Click(object sender, EventArgs e)
        {
            /*BOTON VER DEPOSITO*/
            stock = new Ver_Stock(this);  //creo un nuevo form stock para refrescar la lista
            stock.Show();
            this.Hide();

        }

        private void btn_ADstock_Click(object sender, EventArgs e)
        {
            /**BOTON AGREGAR STOCK**/
            agregar = new AD_Stock(this);
            agregar.Show();
            this.Hide();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            /**BOTON SALIR**/
            this.Close();
            login.Close();
        }
    }
}
