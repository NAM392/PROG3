namespace ProyectoFinal
{
    partial class NewProvider
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lbldire = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom_prov = new System.Windows.Forms.TextBox();
            this.txt_dire_prov = new System.Windows.Forms.TextBox();
            this.txt_tel_prove = new System.Windows.Forms.TextBox();
            this.btn_ad_prov = new System.Windows.Forms.Button();
            this.btn_Canc_Prov = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(73, 18);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(58, 17);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nombre";
            // 
            // lbldire
            // 
            this.lbldire.AutoSize = true;
            this.lbldire.Location = new System.Drawing.Point(73, 83);
            this.lbldire.Name = "lbldire";
            this.lbldire.Size = new System.Drawing.Size(67, 17);
            this.lbldire.TabIndex = 1;
            this.lbldire.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // txt_nom_prov
            // 
            this.txt_nom_prov.Location = new System.Drawing.Point(12, 48);
            this.txt_nom_prov.Name = "txt_nom_prov";
            this.txt_nom_prov.Size = new System.Drawing.Size(194, 22);
            this.txt_nom_prov.TabIndex = 3;
            // 
            // txt_dire_prov
            // 
            this.txt_dire_prov.Location = new System.Drawing.Point(12, 103);
            this.txt_dire_prov.Name = "txt_dire_prov";
            this.txt_dire_prov.Size = new System.Drawing.Size(194, 22);
            this.txt_dire_prov.TabIndex = 4;
            // 
            // txt_tel_prove
            // 
            this.txt_tel_prove.Location = new System.Drawing.Point(12, 162);
            this.txt_tel_prove.Name = "txt_tel_prove";
            this.txt_tel_prove.Size = new System.Drawing.Size(194, 22);
            this.txt_tel_prove.TabIndex = 5;
            this.txt_tel_prove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_prove_KeyPress);
            // 
            // btn_ad_prov
            // 
            this.btn_ad_prov.Location = new System.Drawing.Point(25, 202);
            this.btn_ad_prov.Name = "btn_ad_prov";
            this.btn_ad_prov.Size = new System.Drawing.Size(167, 27);
            this.btn_ad_prov.TabIndex = 6;
            this.btn_ad_prov.Text = "Agregar";
            this.btn_ad_prov.UseVisualStyleBackColor = true;
            this.btn_ad_prov.Click += new System.EventHandler(this.btn_ad_prov_Click_1);
            // 
            // btn_Canc_Prov
            // 
            this.btn_Canc_Prov.Location = new System.Drawing.Point(25, 235);
            this.btn_Canc_Prov.Name = "btn_Canc_Prov";
            this.btn_Canc_Prov.Size = new System.Drawing.Size(167, 30);
            this.btn_Canc_Prov.TabIndex = 7;
            this.btn_Canc_Prov.Text = "Cancelar";
            this.btn_Canc_Prov.UseVisualStyleBackColor = true;
            this.btn_Canc_Prov.Click += new System.EventHandler(this.btn_Canc_Prov_Click_1);
            // 
            // NewProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 277);
            this.Controls.Add(this.btn_Canc_Prov);
            this.Controls.Add(this.btn_ad_prov);
            this.Controls.Add(this.txt_tel_prove);
            this.Controls.Add(this.txt_dire_prov);
            this.Controls.Add(this.txt_nom_prov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbldire);
            this.Controls.Add(this.lblNom);
            this.Name = "NewProvider";
            this.Text = "NewProvider";
            this.Load += new System.EventHandler(this.NewProvider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lbldire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom_prov;
        private System.Windows.Forms.TextBox txt_dire_prov;
        private System.Windows.Forms.TextBox txt_tel_prove;
        private System.Windows.Forms.Button btn_ad_prov;
        private System.Windows.Forms.Button btn_Canc_Prov;
    }
}