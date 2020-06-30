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
    public partial class Login : Form
    {
        private STC prim;
        private int intentos;
        public Login()
        {
            InitializeComponent();
            intentos = 0;
            prim = new STC(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VERIFICO SI EL USUARIO Y LA CONTRASEÑA SON CORRECTOS
            bool ingreso = Program.getSistema().VerificaUsuarioyPass(txt_user.Text, txt_pass.Text);
            
            if(ingreso == true) 
            {
                prim.Show();
                this.Hide();
            }
            else
            {
                intentos++;
                MessageBox.Show("Error al ingresar -  Reingrese datos ","Intento : " + intentos.ToString() + " de 3");
            }
            if(intentos == 3) { this.Close(); }
            








        }
    }
}
