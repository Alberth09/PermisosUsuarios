
namespace PresentacionPermisos
{
    partial class FrmCrearHerramientas
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
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.lblMarca1 = new System.Windows.Forms.Label();
            this.lblMedida1 = new System.Windows.Forms.Label();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.txtMarca2 = new System.Windows.Forms.TextBox();
            this.txtMedida2 = new System.Windows.Forms.TextBox();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(13, 13);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(52, 16);
            this.lblCodigo1.TabIndex = 0;
            this.lblCodigo1.Text = "Codigo";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(13, 47);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(57, 16);
            this.lblNombre1.TabIndex = 1;
            this.lblNombre1.Text = "Nombre";
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.AutoSize = true;
            this.lblDescripcion1.Location = new System.Drawing.Point(13, 87);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(80, 16);
            this.lblDescripcion1.TabIndex = 2;
            this.lblDescripcion1.Text = "Descripcion";
            // 
            // lblMarca1
            // 
            this.lblMarca1.AutoSize = true;
            this.lblMarca1.Location = new System.Drawing.Point(13, 131);
            this.lblMarca1.Name = "lblMarca1";
            this.lblMarca1.Size = new System.Drawing.Size(46, 16);
            this.lblMarca1.TabIndex = 3;
            this.lblMarca1.Text = "Marca";
            // 
            // lblMedida1
            // 
            this.lblMedida1.AutoSize = true;
            this.lblMedida1.Location = new System.Drawing.Point(13, 173);
            this.lblMedida1.Name = "lblMedida1";
            this.lblMedida1.Size = new System.Drawing.Size(54, 16);
            this.lblMedida1.TabIndex = 4;
            this.lblMedida1.Text = "Medida";
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(111, 10);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(222, 22);
            this.txtCodigo2.TabIndex = 5;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(111, 47);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(222, 22);
            this.txtNombre2.TabIndex = 6;
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(111, 84);
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(222, 22);
            this.txtDescripcion2.TabIndex = 7;
            // 
            // txtMarca2
            // 
            this.txtMarca2.Location = new System.Drawing.Point(111, 128);
            this.txtMarca2.Name = "txtMarca2";
            this.txtMarca2.Size = new System.Drawing.Size(222, 22);
            this.txtMarca2.TabIndex = 8;
            // 
            // txtMedida2
            // 
            this.txtMedida2.Location = new System.Drawing.Point(111, 170);
            this.txtMedida2.Name = "txtMedida2";
            this.txtMedida2.Size = new System.Drawing.Size(222, 22);
            this.txtMedida2.TabIndex = 9;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(387, 167);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar1.TabIndex = 10;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar1_Click);
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Location = new System.Drawing.Point(468, 167);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar1.TabIndex = 11;
            this.btnCancelar1.Text = "Cancelar";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            // 
            // FrmCrearHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 203);
            this.Controls.Add(this.btnCancelar1);
            this.Controls.Add(this.btnGuardar1);
            this.Controls.Add(this.txtMedida2);
            this.Controls.Add(this.txtMarca2);
            this.Controls.Add(this.txtDescripcion2);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtCodigo2);
            this.Controls.Add(this.lblMedida1);
            this.Controls.Add(this.lblMarca1);
            this.Controls.Add(this.lblDescripcion1);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.lblCodigo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCrearHerramientas";
            this.Text = "FrmHerramientas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblDescripcion1;
        private System.Windows.Forms.Label lblMarca1;
        private System.Windows.Forms.Label lblMedida1;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.TextBox txtMarca2;
        private System.Windows.Forms.TextBox txtMedida2;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.Button btnCancelar1;
    }
}