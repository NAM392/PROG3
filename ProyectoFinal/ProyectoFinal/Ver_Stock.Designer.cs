namespace ProyectoFinal
{
    partial class Ver_Stock
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
            this.btn_STNom = new System.Windows.Forms.Button();
            this.btn_STProv = new System.Windows.Forms.Button();
            this.btn_STRange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_STNom
            // 
            this.btn_STNom.Location = new System.Drawing.Point(68, 30);
            this.btn_STNom.Name = "btn_STNom";
            this.btn_STNom.Size = new System.Drawing.Size(163, 35);
            this.btn_STNom.TabIndex = 0;
            this.btn_STNom.Text = "Producto";
            this.btn_STNom.UseVisualStyleBackColor = true;
            this.btn_STNom.Click += new System.EventHandler(this.btn_STNom_Click);
            // 
            // btn_STProv
            // 
            this.btn_STProv.Location = new System.Drawing.Point(71, 117);
            this.btn_STProv.Name = "btn_STProv";
            this.btn_STProv.Size = new System.Drawing.Size(163, 35);
            this.btn_STProv.TabIndex = 1;
            this.btn_STProv.Text = "Proveedor";
            this.btn_STProv.UseVisualStyleBackColor = true;
            // 
            // btn_STRange
            // 
            this.btn_STRange.Location = new System.Drawing.Point(71, 203);
            this.btn_STRange.Name = "btn_STRange";
            this.btn_STRange.Size = new System.Drawing.Size(163, 35);
            this.btn_STRange.TabIndex = 3;
            this.btn_STRange.Text = "Rango de Precios";
            this.btn_STRange.UseVisualStyleBackColor = true;
            // 
            // Ver_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 301);
            this.Controls.Add(this.btn_STRange);
            this.Controls.Add(this.btn_STProv);
            this.Controls.Add(this.btn_STNom);
            this.Name = "Ver_Stock";
            this.Text = "Ver_Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_STNom;
        private System.Windows.Forms.Button btn_STProv;
        private System.Windows.Forms.Button btn_STRange;
    }
}