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
    public partial class FrmJuego : Form
    {
        private Form frmInicio;
        Trivia trivia;
        public FrmJuego(Form inicio)
        {
            frmInicio = inicio;
            trivia = new Trivia();
            InitializeComponent();
        }

        public void NuevoJuego()
        {
            trivia.NuevaPregunta();
            Pregunta p = trivia.getPregunta();
            lblPregunta.Text = p.getTexto();

            rbtOpcion1.Text = p.getRespuestasPosibles()[0];
            rbtOpcion2.Text = p.getRespuestasPosibles()[1];
            rbtOpcion3.Text = p.getRespuestasPosibles()[2];

            lblTiempo.Text = "0";
            timer1.Enabled = true;


        }

        private void FrmJuego_Load(object sender, EventArgs e)
        {

        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            string respondida = "";
            if (rbtOpcion1.Checked) respondida = rbtOpcion1.Text;
            if (rbtOpcion2.Checked) respondida = rbtOpcion2.Text;
            if (rbtOpcion3.Checked) respondida = rbtOpcion3.Text;

            if (trivia.getPregunta().esCorrecta(respondida))
            {
                MessageBox.Show("Correcto");
                lblPoint.Text = (Int32.Parse(lblPoint.Text) + 1).ToString();

            }
            else
            {
                MessageBox.Show("MAL");
                lblLife.Text = (Int32.Parse(lblLife.Text) - 1).ToString();
                if (Int32.Parse(lblPoint.Text) > 1)
                {
                    
                    frmInicio.Show();
                    this.Hide();

                }

            }
            NuevoJuego();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = (Int32.Parse(lblTiempo.Text) + 1).ToString();
        }
    }
}
