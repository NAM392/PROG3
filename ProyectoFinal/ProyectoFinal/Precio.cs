﻿using System;
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
        private int Cantidad;
        public Precio(Form prim , Form met , object depo , object elegido , double precio , int cantidad)
        {

            Deposito = (Sistema_Rep)depo;
            method = met;
            primerFrm = prim;
            Elegido = (Producto_comp)elegido;
            Price = precio;
            Cantidad = cantidad;
            InitializeComponent();
            
        }

        private void Precio_Load(object sender, EventArgs e)
        {

            lbl_Precio.Text =   Price.ToString();  //muestra el precio final el cual se tiene que cobrar por el producto
        }

        private void btn_CanVta_Click(object sender, EventArgs e)
        {
            //BOTON CANCELAR
            
            this.Hide();
            method.Show();
        }

        private void btn_Vendido_Click(object sender, EventArgs e)
        {
            /*BOTON VENDER*/
            Deposito.ProductoVendido(Elegido ,Cantidad );// esta funcion sustrae de la lista el producto vendido
            method.Close(); //cierro el form metodo
            primerFrm.Show();
            this.Hide();

        }

    }
}
