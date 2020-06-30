namespace ProyectoFinal
{
    partial class AD_Stock
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
            this.cmb_Depo = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt_Cant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_Compra = new System.Windows.Forms.DateTimePicker();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Depo
            // 
            this.cmb_Depo.FormattingEnabled = true;
            this.cmb_Depo.Location = new System.Drawing.Point(17, 57);
            this.cmb_Depo.Name = "cmb_Depo";
            this.cmb_Depo.Size = new System.Drawing.Size(296, 24);
            this.cmb_Depo.TabIndex = 0;
            this.cmb_Depo.SelectedIndexChanged += new System.EventHandler(this.cmb_Depo_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(14, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(150, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Seleccione Producto : ";
            // 
            // txt_Cant
            // 
            this.txt_Cant.Location = new System.Drawing.Point(213, 101);
            this.txt_Cant.Name = "txt_Cant";
            this.txt_Cant.Size = new System.Drawing.Size(100, 22);
            this.txt_Cant.TabIndex = 2;
            this.txt_Cant.TextChanged += new System.EventHandler(this.txt_Cant_TextChanged);
            this.txt_Cant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cant_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indique Cantidad a Agregar : ";
            // 
            // fecha_Compra
            // 
            this.fecha_Compra.Location = new System.Drawing.Point(65, 200);
            this.fecha_Compra.Name = "fecha_Compra";
            this.fecha_Compra.Size = new System.Drawing.Size(248, 22);
            this.fecha_Compra.TabIndex = 4;
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(65, 250);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(133, 33);
            this.btn_Accept.TabIndex = 5;
            this.btn_Accept.Text = "Aceptar";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(213, 250);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 33);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(105, 130);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(93, 17);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Nuevo Precio";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(213, 130);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 22);
            this.txt_Precio.TabIndex = 7;
            this.txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Precio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccione Fecha";
            // 
            // AD_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.fecha_Compra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cant);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmb_Depo);
            this.Name = "AD_Stock";
            this.Text = "AD_Stock";
            this.Load += new System.EventHandler(this.AD_Stock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Depo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt_Cant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha_Compra;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label2;
    }
}