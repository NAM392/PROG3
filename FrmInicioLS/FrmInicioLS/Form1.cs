using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmInicioLS
{
    public partial class FrmInicio : Form
    {
        private FrmJuego frmJuego;
        public FrmInicio()
        {
            InitializeComponent();
            frmJuego = new FrmJuego(this);
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Length < 1)
            {
                MessageBox.Show("Ingrese su nombre ", "Error");
                return;
            }
            frmJuego.NuevoJuego();
            frmJuego.Show();
            this.Hide();

        }
    }
}
