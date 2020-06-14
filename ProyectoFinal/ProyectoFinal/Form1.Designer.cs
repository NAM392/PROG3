namespace ProyectoFinal
{
    partial class STC
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ADitem = new System.Windows.Forms.Button();
            this.btn_shStock = new System.Windows.Forms.Button();
            this.btn_sold = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ADitem
            // 
            this.btn_ADitem.Location = new System.Drawing.Point(95, 38);
            this.btn_ADitem.Name = "btn_ADitem";
            this.btn_ADitem.Size = new System.Drawing.Size(192, 47);
            this.btn_ADitem.TabIndex = 0;
            this.btn_ADitem.Text = "Agregar Item";
            this.btn_ADitem.UseCompatibleTextRendering = true;
            this.btn_ADitem.UseVisualStyleBackColor = true;
            this.btn_ADitem.Click += new System.EventHandler(this.btn_ADitem_Click);
            // 
            // btn_shStock
            // 
            this.btn_shStock.Location = new System.Drawing.Point(95, 110);
            this.btn_shStock.Name = "btn_shStock";
            this.btn_shStock.Size = new System.Drawing.Size(192, 47);
            this.btn_shStock.TabIndex = 1;
            this.btn_shStock.Text = "Ver Stock";
            this.btn_shStock.UseVisualStyleBackColor = true;
            // 
            // btn_sold
            // 
            this.btn_sold.Location = new System.Drawing.Point(95, 175);
            this.btn_sold.Name = "btn_sold";
            this.btn_sold.Size = new System.Drawing.Size(192, 47);
            this.btn_sold.TabIndex = 2;
            this.btn_sold.Text = "Vender Producto";
            this.btn_sold.UseVisualStyleBackColor = true;
            this.btn_sold.Click += new System.EventHandler(this.btn_sold_Click);
            // 
            // STC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 265);
            this.Controls.Add(this.btn_sold);
            this.Controls.Add(this.btn_shStock);
            this.Controls.Add(this.btn_ADitem);
            this.Name = "STC";
            this.Text = "Stock/Costo";
            this.Load += new System.EventHandler(this.STC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ADitem;
        private System.Windows.Forms.Button btn_shStock;
        private System.Windows.Forms.Button btn_sold;
    }
}

