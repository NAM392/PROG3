namespace ProyectoFinal
{
    partial class Precio
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn_Vendido = new System.Windows.Forms.Button();
            this.btn_CanVta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(111, 58);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(109, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Precio de Venta";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(160, 109);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(44, 17);
            this.lbl_Precio.TabIndex = 1;
            this.lbl_Precio.Text = "00.00";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(126, 109);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(16, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "$";
            // 
            // btn_Vendido
            // 
            this.btn_Vendido.Location = new System.Drawing.Point(93, 170);
            this.btn_Vendido.Name = "btn_Vendido";
            this.btn_Vendido.Size = new System.Drawing.Size(159, 31);
            this.btn_Vendido.TabIndex = 3;
            this.btn_Vendido.Text = "Concretar Venta";
            this.btn_Vendido.UseVisualStyleBackColor = true;
            // 
            // btn_CanVta
            // 
            this.btn_CanVta.Location = new System.Drawing.Point(93, 217);
            this.btn_CanVta.Name = "btn_CanVta";
            this.btn_CanVta.Size = new System.Drawing.Size(159, 31);
            this.btn_CanVta.TabIndex = 4;
            this.btn_CanVta.Text = "Cancelar";
            this.btn_CanVta.UseVisualStyleBackColor = true;
            this.btn_CanVta.Click += new System.EventHandler(this.btn_CanVta_Click);
            // 
            // Precio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 272);
            this.Controls.Add(this.btn_CanVta);
            this.Controls.Add(this.btn_Vendido);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl1);
            this.Name = "Precio";
            this.Tag = "a";
            this.Text = "Precio";
            this.Load += new System.EventHandler(this.Precio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn_Vendido;
        private System.Windows.Forms.Button btn_CanVta;
    }
}