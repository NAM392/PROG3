namespace FrmInicioLS
{
    partial class FrmInicio
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
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(89, 64);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(175, 17);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Bienvenido a la Trivia TSP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ingrese su nombre : ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(110, 202);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(127, 35);
            this.btnComenzar.TabIndex = 3;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 302);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Name = "FrmInicio";
            this.Text = "Juego de Trivia";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnComenzar;
    }
}

