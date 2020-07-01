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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_pr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Proveedor = new System.Windows.Forms.ComboBox();
            this._Deposito = new System.Windows.Forms.ListBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Todo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 285);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(163, 35);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_pr
            // 
            this.lbl_pr.AutoSize = true;
            this.lbl_pr.Location = new System.Drawing.Point(9, 12);
            this.lbl_pr.Name = "lbl_pr";
            this.lbl_pr.Size = new System.Drawing.Size(137, 17);
            this.lbl_pr.TabIndex = 5;
            this.lbl_pr.Text = "Rango de Precios  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde : ";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(79, 43);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(54, 22);
            this.txt_desde.TabIndex = 7;
            this.txt_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desde_KeyPress);
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(79, 83);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(54, 22);
            this.txt_hasta.TabIndex = 9;
            this.txt_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hasta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "-------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Proveedor : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_Proveedor
            // 
            this.cmb_Proveedor.FormattingEnabled = true;
            this.cmb_Proveedor.Location = new System.Drawing.Point(12, 142);
            this.cmb_Proveedor.Name = "cmb_Proveedor";
            this.cmb_Proveedor.Size = new System.Drawing.Size(152, 24);
            this.cmb_Proveedor.TabIndex = 12;
            // 
            // _Deposito
            // 
            this._Deposito.FormattingEnabled = true;
            this._Deposito.ItemHeight = 16;
            this._Deposito.Location = new System.Drawing.Point(196, 12);
            this._Deposito.Name = "_Deposito";
            this._Deposito.Size = new System.Drawing.Size(677, 308);
            this._Deposito.TabIndex = 14;
            this._Deposito.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(12, 186);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(163, 35);
            this.btn_Select.TabIndex = 15;
            this.btn_Select.Text = "Seleccionar";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Todo
            // 
            this.btn_Todo.Location = new System.Drawing.Point(12, 244);
            this.btn_Todo.Name = "btn_Todo";
            this.btn_Todo.Size = new System.Drawing.Size(163, 35);
            this.btn_Todo.TabIndex = 16;
            this.btn_Todo.Text = "Ver Todo";
            this.btn_Todo.UseVisualStyleBackColor = true;
            this.btn_Todo.Click += new System.EventHandler(this.btn_Todo_Click);
            // 
            // Ver_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 329);
            this.Controls.Add(this.btn_Todo);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this._Deposito);
            this.Controls.Add(this.cmb_Proveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_hasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_pr);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "Ver_Stock";
            this.Text = "Ver_Stock";
            this.Load += new System.EventHandler(this.Ver_Stock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_pr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Proveedor;
        private System.Windows.Forms.ListBox _Deposito;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Todo;
    }
}