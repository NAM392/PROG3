namespace FrmInicioLS
{
    partial class FrmJuego
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
            this.components = new System.ComponentModel.Container();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.rbtOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbtOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbtOpcion3 = new System.Windows.Forms.RadioButton();
            this.btnResponder = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.vida = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(32, 40);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(80, 17);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "lblPregunta";
            // 
            // rbtOpcion1
            // 
            this.rbtOpcion1.AutoSize = true;
            this.rbtOpcion1.Location = new System.Drawing.Point(35, 74);
            this.rbtOpcion1.Name = "rbtOpcion1";
            this.rbtOpcion1.Size = new System.Drawing.Size(99, 21);
            this.rbtOpcion1.TabIndex = 1;
            this.rbtOpcion1.TabStop = true;
            this.rbtOpcion1.Text = "rbtOpcion1";
            this.rbtOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbtOpcion2
            // 
            this.rbtOpcion2.AutoSize = true;
            this.rbtOpcion2.Location = new System.Drawing.Point(35, 118);
            this.rbtOpcion2.Name = "rbtOpcion2";
            this.rbtOpcion2.Size = new System.Drawing.Size(99, 21);
            this.rbtOpcion2.TabIndex = 2;
            this.rbtOpcion2.TabStop = true;
            this.rbtOpcion2.Text = "rbtOpcion2";
            this.rbtOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbtOpcion3
            // 
            this.rbtOpcion3.AutoSize = true;
            this.rbtOpcion3.Location = new System.Drawing.Point(35, 163);
            this.rbtOpcion3.Name = "rbtOpcion3";
            this.rbtOpcion3.Size = new System.Drawing.Size(99, 21);
            this.rbtOpcion3.TabIndex = 3;
            this.rbtOpcion3.TabStop = true;
            this.rbtOpcion3.Text = "rbtOpcion3";
            this.rbtOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(12, 211);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(173, 47);
            this.btnResponder.TabIndex = 4;
            this.btnResponder.Text = "btnResponder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(284, 211);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(16, 17);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "0";
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Location = new System.Drawing.Point(259, 9);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(52, 17);
            this.point.TabIndex = 6;
            this.point.Text = "Puntos";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(284, 40);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(16, 17);
            this.lblPoint.TabIndex = 7;
            this.lblPoint.Text = "0";
            // 
            // vida
            // 
            this.vida.AutoSize = true;
            this.vida.Location = new System.Drawing.Point(269, 90);
            this.vida.Name = "vida";
            this.vida.Size = new System.Drawing.Size(34, 17);
            this.vida.TabIndex = 8;
            this.vida.Text = "vida";
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Location = new System.Drawing.Point(284, 118);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(16, 17);
            this.lblLife.TabIndex = 9;
            this.lblLife.Text = "3";
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 281);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.vida);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.point);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.rbtOpcion3);
            this.Controls.Add(this.rbtOpcion2);
            this.Controls.Add(this.rbtOpcion1);
            this.Controls.Add(this.lblPregunta);
            this.Name = "FrmJuego";
            this.Text = "FrmJuego";
            this.Load += new System.EventHandler(this.FrmJuego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton rbtOpcion1;
        private System.Windows.Forms.RadioButton rbtOpcion2;
        private System.Windows.Forms.RadioButton rbtOpcion3;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label vida;
        private System.Windows.Forms.Label lblLife;
    }
}