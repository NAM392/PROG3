namespace ProyectoFinal
{
    partial class Item
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_codP = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_Prov = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_CodProd = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txt_Prov = new System.Windows.Forms.TextBox();
            this.txt_Cant = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_CostoU = new System.Windows.Forms.Label();
            this.btn_Item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_codP
            // 
            this.lbl_codP.AutoSize = true;
            this.lbl_codP.Location = new System.Drawing.Point(34, 75);
            this.lbl_codP.Name = "lbl_codP";
            this.lbl_codP.Size = new System.Drawing.Size(148, 17);
            this.lbl_codP.TabIndex = 0;
            this.lbl_codP.Text = "Codigo del Producto : ";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(34, 21);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(70, 17);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "Nombre : ";
            // 
            // lbl_Prov
            // 
            this.lbl_Prov.AutoSize = true;
            this.lbl_Prov.Location = new System.Drawing.Point(34, 131);
            this.lbl_Prov.Name = "lbl_Prov";
            this.lbl_Prov.Size = new System.Drawing.Size(157, 17);
            this.lbl_Prov.TabIndex = 2;
            this.lbl_Prov.Text = "Codigo del Proveedor : ";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(34, 190);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(80, 17);
            this.lbl_cantidad.TabIndex = 3;
            this.lbl_cantidad.Text = "Cantidad  : ";
            // 
            // txt_CodProd
            // 
            this.txt_CodProd.Location = new System.Drawing.Point(37, 95);
            this.txt_CodProd.Name = "txt_CodProd";
            this.txt_CodProd.Size = new System.Drawing.Size(184, 22);
            this.txt_CodProd.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(37, 41);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(184, 22);
            this.txtNom.TabIndex = 1;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txt_Prov
            // 
            this.txt_Prov.Location = new System.Drawing.Point(37, 151);
            this.txt_Prov.Name = "txt_Prov";
            this.txt_Prov.Size = new System.Drawing.Size(184, 22);
            this.txt_Prov.TabIndex = 3;
            // 
            // txt_Cant
            // 
            this.txt_Cant.Location = new System.Drawing.Point(37, 210);
            this.txt_Cant.Name = "txt_Cant";
            this.txt_Cant.Size = new System.Drawing.Size(184, 22);
            this.txt_Cant.TabIndex = 4;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(37, 269);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(184, 22);
            this.txt_Precio.TabIndex = 5;
            // 
            // lbl_CostoU
            // 
            this.lbl_CostoU.AutoSize = true;
            this.lbl_CostoU.Location = new System.Drawing.Point(34, 249);
            this.lbl_CostoU.Name = "lbl_CostoU";
            this.lbl_CostoU.Size = new System.Drawing.Size(130, 17);
            this.lbl_CostoU.TabIndex = 8;
            this.lbl_CostoU.Text = "Costo por Unidad : ";
            // 
            // btn_Item
            // 
            this.btn_Item.Location = new System.Drawing.Point(59, 310);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(174, 36);
            this.btn_Item.TabIndex = 10;
            this.btn_Item.Text = "Aceptar";
            this.btn_Item.UseVisualStyleBackColor = true;
            this.btn_Item.Click += new System.EventHandler(this.btn_Item_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 358);
            this.Controls.Add(this.btn_Item);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.lbl_CostoU);
            this.Controls.Add(this.txt_Cant);
            this.Controls.Add(this.txt_Prov);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txt_CodProd);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_Prov);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.lbl_codP);
            this.Name = "Item";
            this.Text = "Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codP;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_Prov;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_CodProd;
        private System.Windows.Forms.TextBox txt_Prov;
        private System.Windows.Forms.TextBox txt_Cant;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_CostoU;
        private System.Windows.Forms.Button btn_Item;
        public System.Windows.Forms.TextBox txtNom;
    }
}