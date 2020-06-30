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

        }


        private void btn_ad_prov_Click_1(object sender, EventArgs e)
        {
            /***ERRORES***/
            if (txt_nom_prov.Text == null || txt_dire_prov.Text == null || txt_tel_prove.Text == null)
            {
                MessageBox.Show("Complete los Campos");
                return;
            }
            //SI NO HAY ERROR CREA UN NUEVO PROVEEDOR
            Proveedor p = new Proveedor(txt_nom_prov.Text, txt_dire_prov.Text, int.Parse(txt_tel_prove.Text));
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
