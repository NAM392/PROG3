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
    public partial class Precio : Form
    {
        private Form method;
        private Form primerFrm;
        private Sistema_Rep Deposito;
        private Producto_comp Elegido;
        private double Price ;
        public Precio(Form prim , Form met , object depo , object elegido , double precio)
        {

            Deposito = (Sistema_Rep)depo;
            method = met;
            primerFrm = prim;
            Elegido = (Producto_comp)elegido;
            Price = precio;
            InitializeComponent();
            
        }

        private void Precio_Load(object sender, EventArgs e)
        {
            lbl_Precio.Text =   Price.ToString();
        }

        private void btn_CanVta_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            primerFrm.Show();
        }
    }
}
