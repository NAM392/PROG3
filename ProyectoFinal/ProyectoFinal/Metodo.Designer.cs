namespace ProyectoFinal
{
    partial class frmMetodo
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_Margen = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.OP_FIFO = new System.Windows.Forms.RadioButton();
            this.OP_LIFO = new System.Windows.Forms.RadioButton();
            this.OP_PPP = new System.Windows.Forms.RadioButton();
            this.grpCosteo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PPP = new System.Windows.Forms.Label();
            this.lbl_LIFO = new System.Windows.Forms.Label();
            this.lbl_FIFO = new System.Windows.Forms.Label();
            this.btn_LFP = new System.Windows.Forms.Button();
            this.cmb_Todos = new System.Windows.Forms.ComboBox();
            this.lbl_prod = new System.Windows.Forms.Label();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.grpCosteo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(28, 81);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(177, 17);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Indique Margen de Utilidad";
            // 
            // txt_Margen
            // 
            this.txt_Margen.Location = new System.Drawing.Point(31, 114);
            this.txt_Margen.Name = "txt_Margen";
            this.txt_Margen.Size = new System.Drawing.Size(74, 22);
            this.txt_Margen.TabIndex = 1;
            this.txt_Margen.TextChanged += new System.EventHandler(this.txt_Margen_TextChanged);
            this.txt_Margen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Margen_KeyPress);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(120, 117);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(20, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "%";
            // 
            // OP_FIFO
            // 
            this.OP_FIFO.AutoSize = true;
            this.OP_FIFO.Location = new System.Drawing.Point(19, 36);
            this.OP_FIFO.Name = "OP_FIFO";
            this.OP_FIFO.Size = new System.Drawing.Size(59, 21);
            this.OP_FIFO.TabIndex = 4;
            this.OP_FIFO.TabStop = true;
            this.OP_FIFO.Text = "FIFO";
            this.OP_FIFO.UseVisualStyleBackColor = true;
            // 
            // OP_LIFO
            // 
            this.OP_LIFO.AutoSize = true;
            this.OP_LIFO.Location = new System.Drawing.Point(19, 73);
            this.OP_LIFO.Name = "OP_LIFO";
            this.OP_LIFO.Size = new System.Drawing.Size(59, 21);
            this.OP_LIFO.TabIndex = 5;
            this.OP_LIFO.TabStop = true;
            this.OP_LIFO.Text = "LIFO";
            this.OP_LIFO.UseVisualStyleBackColor = true;
            // 
            // OP_PPP
            // 
            this.OP_PPP.AutoSize = true;
            this.OP_PPP.Location = new System.Drawing.Point(19, 110);
            this.OP_PPP.Name = "OP_PPP";
            this.OP_PPP.Size = new System.Drawing.Size(56, 21);
            this.OP_PPP.TabIndex = 6;
            this.OP_PPP.TabStop = true;
            this.OP_PPP.Text = "PPP";
            this.OP_PPP.UseVisualStyleBackColor = true;
            // 
            // grpCosteo
            // 
            this.grpCosteo.Controls.Add(this.label2);
            this.grpCosteo.Controls.Add(this.label3);
            this.grpCosteo.Controls.Add(this.label1);
            this.grpCosteo.Controls.Add(this.lbl_PPP);
            this.grpCosteo.Controls.Add(this.lbl_LIFO);
            this.grpCosteo.Controls.Add(this.lbl_FIFO);
            this.grpCosteo.Controls.Add(this.OP_PPP);
            this.grpCosteo.Controls.Add(this.OP_LIFO);
            this.grpCosteo.Controls.Add(this.OP_FIFO);
            this.grpCosteo.Location = new System.Drawing.Point(12, 156);
            this.grpCosteo.Name = "grpCosteo";
            this.grpCosteo.Size = new System.Drawing.Size(198, 137);
            this.grpCosteo.TabIndex = 7;
            this.grpCosteo.TabStop = false;
            this.grpCosteo.Text = "Indique Metodo de Costeo";
            this.grpCosteo.Enter += new System.EventHandler(this.grpCosteo_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "$";
            // 
            // lbl_PPP
            // 
            this.lbl_PPP.AutoSize = true;
            this.lbl_PPP.Location = new System.Drawing.Point(132, 110);
            this.lbl_PPP.Name = "lbl_PPP";
            this.lbl_PPP.Size = new System.Drawing.Size(44, 17);
            this.lbl_PPP.TabIndex = 15;
            this.lbl_PPP.Text = "00.00";
            // 
            // lbl_LIFO
            // 
            this.lbl_LIFO.AutoSize = true;
            this.lbl_LIFO.Location = new System.Drawing.Point(132, 73);
            this.lbl_LIFO.Name = "lbl_LIFO";
            this.lbl_LIFO.Size = new System.Drawing.Size(44, 17);
            this.lbl_LIFO.TabIndex = 14;
            this.lbl_LIFO.Text = "00.00";
            // 
            // lbl_FIFO
            // 
            this.lbl_FIFO.AutoSize = true;
            this.lbl_FIFO.Location = new System.Drawing.Point(132, 40);
            this.lbl_FIFO.Name = "lbl_FIFO";
            this.lbl_FIFO.Size = new System.Drawing.Size(44, 17);
            this.lbl_FIFO.TabIndex = 13;
            this.lbl_FIFO.Text = "00.00";
            this.lbl_FIFO.Click += new System.EventHandler(this.lbl_FIFO_Click);
            // 
            // btn_LFP
            // 
            this.btn_LFP.Location = new System.Drawing.Point(263, 229);
            this.btn_LFP.Name = "btn_LFP";
            this.btn_LFP.Size = new System.Drawing.Size(126, 38);
            this.btn_LFP.TabIndex = 8;
            this.btn_LFP.Text = "Aceptar";
            this.btn_LFP.UseVisualStyleBackColor = true;
            this.btn_LFP.Click += new System.EventHandler(this.btn_LFP_Click);
            // 
            // cmb_Todos
            // 
            this.cmb_Todos.FormattingEnabled = true;
            this.cmb_Todos.Location = new System.Drawing.Point(31, 38);
            this.cmb_Todos.Name = "cmb_Todos";
            this.cmb_Todos.Size = new System.Drawing.Size(122, 24);
            this.cmb_Todos.TabIndex = 9;
            this.cmb_Todos.SelectedIndexChanged += new System.EventHandler(this.cmb_Todos_SelectedIndexChanged);
            // 
            // lbl_prod
            // 
            this.lbl_prod.AutoSize = true;
            this.lbl_prod.Location = new System.Drawing.Point(28, 18);
            this.lbl_prod.Name = "lbl_prod";
            this.lbl_prod.Size = new System.Drawing.Size(99, 17);
            this.lbl_prod.TabIndex = 10;
            this.lbl_prod.Text = "Elija Producto ";
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Location = new System.Drawing.Point(247, 18);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(126, 17);
            this.lbl_cant.TabIndex = 11;
            this.lbl_cant.Text = "Indique Cantidad : ";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(272, 40);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(74, 22);
            this.txtCant.TabIndex = 12;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(263, 288);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(126, 38);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stock";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(189, 41);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(16, 17);
            this.lbl_stock.TabIndex = 15;
            this.lbl_stock.Text = "0";
            // 
            // frmMetodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 338);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.lbl_cant);
            this.Controls.Add(this.lbl_prod);
            this.Controls.Add(this.cmb_Todos);
            this.Controls.Add(this.btn_LFP);
            this.Controls.Add(this.grpCosteo);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt_Margen);
            this.Controls.Add(this.lbl_1);
            this.Name = "frmMetodo";
            this.Text = "Metodo";
            this.Load += new System.EventHandler(this.frmMetodo_Load);
            this.grpCosteo.ResumeLayout(false);
            this.grpCosteo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_Margen;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.RadioButton OP_FIFO;
        private System.Windows.Forms.RadioButton OP_LIFO;
        private System.Windows.Forms.RadioButton OP_PPP;
        private System.Windows.Forms.GroupBox grpCosteo;
        private System.Windows.Forms.Button btn_LFP;
        private System.Windows.Forms.ComboBox cmb_Todos;
        private System.Windows.Forms.Label lbl_prod;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PPP;
        private System.Windows.Forms.Label lbl_LIFO;
        private System.Windows.Forms.Label lbl_FIFO;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_stock;
    }
}