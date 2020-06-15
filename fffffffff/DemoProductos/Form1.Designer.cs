namespace DemoProductos
{
   partial class Form1
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
         this.components = new System.ComponentModel.Container();
         this.btnCargar = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txtSku = new System.Windows.Forms.TextBox();
         this.txtDescripcion = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.txtProveedor = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtCantidad = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.txtPrecio = new System.Windows.Forms.TextBox();
         this.dgvDatos = new System.Windows.Forms.DataGridView();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
         this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
         this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
         this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
         this.btnModificar = new System.Windows.Forms.Button();
         this.btnModifica = new System.Windows.Forms.Button();
         this.btnLimpiar = new System.Windows.Forms.Button();
         this.btnBorrar = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
         this.SuspendLayout();
         // 
         // btnCargar
         // 
         this.btnCargar.Location = new System.Drawing.Point(58, 281);
         this.btnCargar.Name = "btnCargar";
         this.btnCargar.Size = new System.Drawing.Size(75, 23);
         this.btnCargar.TabIndex = 0;
         this.btnCargar.Text = "Cargar";
         this.btnCargar.UseVisualStyleBackColor = true;
         this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(51, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(32, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "SKU:";
         // 
         // txtSku
         // 
         this.txtSku.Location = new System.Drawing.Point(104, 12);
         this.txtSku.Name = "txtSku";
         this.txtSku.Size = new System.Drawing.Size(157, 20);
         this.txtSku.TabIndex = 1;
         // 
         // txtDescripcion
         // 
         this.txtDescripcion.Location = new System.Drawing.Point(104, 38);
         this.txtDescripcion.Name = "txtDescripcion";
         this.txtDescripcion.Size = new System.Drawing.Size(157, 20);
         this.txtDescripcion.TabIndex = 4;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(24, 38);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(66, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Descripción:";
         // 
         // txtProveedor
         // 
         this.txtProveedor.Location = new System.Drawing.Point(104, 64);
         this.txtProveedor.Name = "txtProveedor";
         this.txtProveedor.Size = new System.Drawing.Size(429, 20);
         this.txtProveedor.TabIndex = 6;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(31, 64);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(59, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "Proveedor:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(307, 15);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(52, 13);
         this.label4.TabIndex = 5;
         this.label4.Text = "Cantidad:";
         // 
         // txtCantidad
         // 
         this.txtCantidad.Location = new System.Drawing.Point(376, 12);
         this.txtCantidad.Name = "txtCantidad";
         this.txtCantidad.Size = new System.Drawing.Size(157, 20);
         this.txtCantidad.TabIndex = 6;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(307, 41);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(40, 13);
         this.label5.TabIndex = 5;
         this.label5.Text = "Precio:";
         // 
         // txtPrecio
         // 
         this.txtPrecio.Location = new System.Drawing.Point(376, 38);
         this.txtPrecio.Name = "txtPrecio";
         this.txtPrecio.Size = new System.Drawing.Size(157, 20);
         this.txtPrecio.TabIndex = 6;
         // 
         // dgvDatos
         // 
         this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvDatos.Location = new System.Drawing.Point(12, 116);
         this.dgvDatos.Name = "dgvDatos";
         this.dgvDatos.Size = new System.Drawing.Size(521, 159);
         this.dgvDatos.TabIndex = 7;
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // errorProvider2
         // 
         this.errorProvider2.ContainerControl = this;
         // 
         // errorProvider3
         // 
         this.errorProvider3.ContainerControl = this;
         // 
         // errorProvider4
         // 
         this.errorProvider4.ContainerControl = this;
         // 
         // errorProvider5
         // 
         this.errorProvider5.ContainerControl = this;
         // 
         // btnModificar
         // 
         this.btnModificar.Location = new System.Drawing.Point(139, 281);
         this.btnModificar.Name = "btnModificar";
         this.btnModificar.Size = new System.Drawing.Size(75, 23);
         this.btnModificar.TabIndex = 8;
         this.btnModificar.Text = "Buscar";
         this.btnModificar.UseVisualStyleBackColor = true;
         this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
         // 
         // btnModifica
         // 
         this.btnModifica.Location = new System.Drawing.Point(221, 282);
         this.btnModifica.Name = "btnModifica";
         this.btnModifica.Size = new System.Drawing.Size(86, 23);
         this.btnModifica.TabIndex = 9;
         this.btnModifica.Text = "Modificar Reg";
         this.btnModifica.UseVisualStyleBackColor = true;
         this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
         // 
         // btnLimpiar
         // 
         this.btnLimpiar.Location = new System.Drawing.Point(313, 281);
         this.btnLimpiar.Name = "btnLimpiar";
         this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
         this.btnLimpiar.TabIndex = 10;
         this.btnLimpiar.Text = "Limpia";
         this.btnLimpiar.UseVisualStyleBackColor = true;
         this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
         // 
         // btnBorrar
         // 
         this.btnBorrar.Location = new System.Drawing.Point(395, 282);
         this.btnBorrar.Name = "btnBorrar";
         this.btnBorrar.Size = new System.Drawing.Size(75, 23);
         this.btnBorrar.TabIndex = 11;
         this.btnBorrar.Text = "Borrar";
         this.btnBorrar.UseVisualStyleBackColor = true;
         this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(548, 313);
         this.Controls.Add(this.btnBorrar);
         this.Controls.Add(this.btnLimpiar);
         this.Controls.Add(this.btnModifica);
         this.Controls.Add(this.btnModificar);
         this.Controls.Add(this.dgvDatos);
         this.Controls.Add(this.txtPrecio);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.txtCantidad);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txtProveedor);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtDescripcion);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtSku);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnCargar);
         this.Name = "Form1";
         this.Text = "Productos";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnCargar;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtSku;
      private System.Windows.Forms.TextBox txtDescripcion;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtProveedor;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtCantidad;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txtPrecio;
      private System.Windows.Forms.DataGridView dgvDatos;
      private System.Windows.Forms.ErrorProvider errorProvider1;
      private System.Windows.Forms.ErrorProvider errorProvider2;
      private System.Windows.Forms.ErrorProvider errorProvider3;
      private System.Windows.Forms.ErrorProvider errorProvider4;
      private System.Windows.Forms.ErrorProvider errorProvider5;
      private System.Windows.Forms.Button btnModificar;
      private System.Windows.Forms.Button btnModifica;
      private System.Windows.Forms.Button btnLimpiar;
      private System.Windows.Forms.Button btnBorrar;
   }
}

