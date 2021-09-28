
namespace PresentacionPermisos
{
    partial class FrmCrearProductos
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
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.txtMarca3 = new System.Windows.Forms.TextBox();
            this.txtDescripcion3 = new System.Windows.Forms.TextBox();
            this.txtNombre3 = new System.Windows.Forms.TextBox();
            this.txtCodigo3 = new System.Windows.Forms.TextBox();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.lblMarca1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Location = new System.Drawing.Point(450, 119);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar1.TabIndex = 22;
            this.btnCancelar1.Text = "Cancelar";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(369, 119);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar1.TabIndex = 21;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar1_Click);
            // 
            // txtMarca3
            // 
            this.txtMarca3.Location = new System.Drawing.Point(110, 124);
            this.txtMarca3.Name = "txtMarca3";
            this.txtMarca3.Size = new System.Drawing.Size(222, 20);
            this.txtMarca3.TabIndex = 19;
            // 
            // txtDescripcion3
            // 
            this.txtDescripcion3.Location = new System.Drawing.Point(110, 80);
            this.txtDescripcion3.Name = "txtDescripcion3";
            this.txtDescripcion3.Size = new System.Drawing.Size(222, 20);
            this.txtDescripcion3.TabIndex = 18;
            // 
            // txtNombre3
            // 
            this.txtNombre3.Location = new System.Drawing.Point(110, 43);
            this.txtNombre3.Name = "txtNombre3";
            this.txtNombre3.Size = new System.Drawing.Size(222, 20);
            this.txtNombre3.TabIndex = 17;
            // 
            // txtCodigo3
            // 
            this.txtCodigo3.Location = new System.Drawing.Point(110, 6);
            this.txtCodigo3.Name = "txtCodigo3";
            this.txtCodigo3.Size = new System.Drawing.Size(222, 20);
            this.txtCodigo3.TabIndex = 16;
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.AutoSize = true;
            this.lblDescripcion1.Location = new System.Drawing.Point(12, 83);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion1.TabIndex = 14;
            this.lblDescripcion1.Text = "Descripcion";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(12, 43);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(44, 13);
            this.lblNombre1.TabIndex = 13;
            this.lblNombre1.Text = "Nombre";
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo1.TabIndex = 12;
            this.lblCodigo1.Text = "Codigo";
            // 
            // lblMarca1
            // 
            this.lblMarca1.AutoSize = true;
            this.lblMarca1.Location = new System.Drawing.Point(12, 127);
            this.lblMarca1.Name = "lblMarca1";
            this.lblMarca1.Size = new System.Drawing.Size(37, 13);
            this.lblMarca1.TabIndex = 23;
            this.lblMarca1.Text = "Marca";
            // 
            // FrmCrearProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 163);
            this.Controls.Add(this.lblMarca1);
            this.Controls.Add(this.btnCancelar1);
            this.Controls.Add(this.btnGuardar1);
            this.Controls.Add(this.txtMarca3);
            this.Controls.Add(this.txtDescripcion3);
            this.Controls.Add(this.txtNombre3);
            this.Controls.Add(this.txtCodigo3);
            this.Controls.Add(this.lblDescripcion1);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.lblCodigo1);
            this.Name = "FrmCrearProductos";
            this.Text = "FrmCrearProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.TextBox txtMarca3;
        private System.Windows.Forms.TextBox txtDescripcion3;
        private System.Windows.Forms.TextBox txtNombre3;
        private System.Windows.Forms.TextBox txtCodigo3;
        private System.Windows.Forms.Label lblDescripcion1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Label lblMarca1;
    }
}