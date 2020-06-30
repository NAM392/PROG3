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
        private List<Producto_comp> Deposito;
        private Form frmSTC;
        private List<Costeados> depo;
        public Ver_Stock(Form stc)
        {
            InitializeComponent();
            frmSTC = stc;
            depo = Program.getSistema().getCosteados();
            Deposito = Program.getSistema().getDeposito();
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
        {   //TRAIGO LA LISTA DE COSTEADOS
             List<Costeados> depo = Program.getSistema().getCosteados();
            //ORDENO LA LISTA DE COSTEADOS Y LA MUESTRO
            depo.Sort((x, y) => x.date.CompareTo(y.date));
            _Deposito.Items.AddRange(depo.ToArray());

            //BUSCO EL PRECIO MAXIMO
            double max = 0;
            foreach (var c in depo)
            {
                if (c.precio > max)
                    max = c.precio;
              
            }
            txt_hasta.Text = max.ToString();

            //BUSCO EL PRECIO MINIMO
            foreach(var c in depo)
            {
                if(c.precio < max)
                {
                    max = c.precio;
                }
            }
            txt_desde.Text = max.ToString();
            //LISTA DE PROVEEDORES
            cmb_Proveedor.Items.AddRange(Program.getSistema().getProveedor().ToArray());
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            //List<Costeados> depo = Program.getSistema().getCosteados();
            
            List<Costeados> Seleccionados = new List<Costeados>();
            Costeados n;
            Proveedor elegido = (Proveedor)cmb_Proveedor.SelectedItem;
            //ERROR NO ELIGIO PROVEEDOR
            if(elegido == null) { MessageBox.Show("Seleccione Proveedor");return; }
            //RECORRO TODA LA LISTA DE COSTEADOS
            foreach (var c in depo)
            {
                 //LOS PRECIOS SELECCIONADOS SON DESDE X  HASTA Y.
                if (c.precio >= double.Parse(txt_desde.Text) && c.precio <= double.Parse(txt_hasta.Text))
               {    
                    //LOS RANGOS DE PRECIOS LOS TIENE EL PROVEEDOR ELEGIDO
                    if(c.Proveedor == elegido )
                    {
                        //AGREGO EN LA LISTA DE SELECCIONADOS ESTE PRODUCTO PARA PODER VISUALIZARSE
                        n = new Costeados(c.Nombre, c.cod_articulo , c.precio, c.cantidad, c.date, c.Proveedor);
                        Seleccionados.Add(n);
                    }
                }
            }

            //Ordeno la lista de seleccionados
            Seleccionados.Sort((x, y) => x.date.CompareTo(y.date));
            _Deposito.Items.Clear();
            _Deposito.Items.AddRange(Seleccionados.ToArray());







        }

        private void btn_Todo_Click(object sender, EventArgs e)
        {             
            _Deposito.Items.Clear();
             depo.Sort((x, y) => x.date.CompareTo(y.date));
            _Deposito.Items.AddRange(depo.ToArray());
        }
    }
}
