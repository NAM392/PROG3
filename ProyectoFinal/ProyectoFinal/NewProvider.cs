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
    public partial class NewProvider : Form
    {
        private Form Stc;
        private Form Items;
        private string codigoProd;
        private string NomProd;
        public NewProvider(Form stc, Form item, string nom_prod, string cod_prod)
        {
            InitializeComponent();
            Stc = stc;
            Items = item;
            NomProd = nom_prod;
            codigoProd = cod_prod;
        }


        private void NewProvider_Load(object sender, EventArgs e)
        {
            //limito la cantidad de digitos al ingreso
            txt_tel_prove.MaxLength = 13;
            txt_dire_prov.MaxLength = 20;
            txt_nom_prov.MaxLength = 15;
            txt_tel_prove.Text = "0";
        }


        private void btn_ad_prov_Click_1(object sender, EventArgs e)
        {
            string nombre_prov = txt_nom_prov.Text;
            string direccion_prov = txt_dire_prov.Text;
            long telefono_prov = long.Parse(txt_tel_prove.Text);

            if (nombre_prov == null || direccion_prov == null )
            {
                MessageBox.Show("Complete los Campos");
                return;
            }
            if(telefono_prov <= 0 )
            {
                MessageBox.Show("Ingrese Numero Telefonico Valido ");
                return;
            }


            /***ERRORES***/

            //SI NO HAY ERROR CREA UN NUEVO PROVEEDOR
            Proveedor p = new Proveedor(nombre_prov, direccion_prov, telefono_prov);
            //AGREGA EL NUEVO PROVEEDOR A LA LISTA PROVEEDOR QUE VIVE EN SISTEMA
            Program.getSistema().agregarProveedor(p);
            
            MessageBox.Show("Se Agrego Proveedor Exitosamente");
            //CIERRO EL FORM ITEM
            Items.Close();
            //CREO UN NUEVO FORM ITEM CON LOS PARAMETROS QUE USE ANTES DE AGREGAR UN PROVEEDOR
            Item nuevo = new Item(Stc, NomProd, codigoProd);
            //MUESTRO EL NUEVO FORM ITE,
            nuevo.Show();
            //CIERRO ESTE FORM
            this.Close();

        }

        private void btn_Canc_Prov_Click_1(object sender, EventArgs e)
        {
            //BOTON CANCELAR
            Items.Show();
            this.Hide();
        }

        private void txt_tel_prove_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NumeroEnteros(e);
        }
    }
}
