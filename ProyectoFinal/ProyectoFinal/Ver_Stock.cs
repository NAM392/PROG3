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
    
    public partial class Ver_Stock : Form
    {
        private Sistema_Rep Deposito;
        public Ver_Stock(object sistema)
        {
            InitializeComponent();
            Deposito = (Sistema_Rep)sistema;
        }

        private void btn_STNom_Click(object sender, EventArgs e)
        {

        }
    }
}
