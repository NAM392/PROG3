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
        private Form frmSTC;
        public Ver_Stock(object sistema , Form stc)
        {
            InitializeComponent();
            frmSTC = stc;
            Deposito = (Sistema_Rep)sistema;
        }

        private void btn_STNom_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            frmSTC.Show();
            this.Close();
        }

        private void Ver_Stock_Load(object sender, EventArgs e)
        {
            List<Costeados> depo = Program.getSistema().getCosteados();

            _Deposito.Items.AddRange(depo.ToArray());

            double max = 0;
            foreach (var c in depo)
            {
                if (c.precio > max)
                    max = c.precio;
              
            }
            txt_hasta.Text = max.ToString();

            foreach(var c in depo)
            {
                if(c.precio < max)
                {
                    max = c.precio;
                }
            }
            txt_desde.Text = max.ToString();

            cmb_Proveedor.Items.AddRange(Program.getSistema().getProveedor().ToArray());
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            List<Costeados> depo = Program.getSistema().getCosteados();
            List<Costeados> Seleccionados = new List<Costeados>();
            Costeados n;
            Proveedor elegido = (Proveedor)cmb_Proveedor.SelectedItem;
            if(elegido == null) { MessageBox.Show("Seleccione Proveedor");return; }
            foreach (var c in depo)
            {
                if (c.precio >= double.Parse(txt_desde.Text) && c.precio <= double.Parse(txt_hasta.Text))
               {
                    if(c.Proveedor == elegido )
                    {
                        n = new Costeados(c.Nombre, c.precio, c.cantidad, c.date, c.Proveedor);
                        Seleccionados.Add(n);
                    }
                }
            }

            _Deposito.Items.Clear();
            _Deposito.Items.AddRange(Seleccionados.ToArray());







        }
    }
}
