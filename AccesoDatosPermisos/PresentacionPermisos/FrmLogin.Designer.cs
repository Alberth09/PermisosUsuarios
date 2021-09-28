
namespace PresentacionPermisos
{
    partial class FrmLogin
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
            this.lblnombreU = new System.Windows.Forms.Label();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnRegristrarte = new System.Windows.Forms.Button();
            this.btnInvitado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombreU
            // 
            this.lblnombreU.AutoSize = true;
            this.lblnombreU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreU.Location = new System.Drawing.Point(12, 27);
            this.lblnombreU.Name = "lblnombreU";
            this.lblnombreU.Size = new System.Drawing.Size(55, 16);
            this.lblnombreU.TabIndex = 0;
            this.lblnombreU.Text = "Usuario";
            // 
            // txtNombreU
            // 
            this.txtNombreU.Location = new System.Drawing.Point(96, 23);
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(148, 20);
            this.txtNombreU.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(96, 63);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(148, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(12, 67);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(77, 16);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 116);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(117, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar sección";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnRegristrarte
            // 
            this.btnRegristrarte.Location = new System.Drawing.Point(169, 116);
            this.btnRegristrarte.Name = "btnRegristrarte";
            this.btnRegristrarte.Size = new System.Drawing.Size(75, 23);
            this.btnRegristrarte.TabIndex = 5;
            this.btnRegristrarte.Text = "Regristrarte";
            this.btnRegristrarte.UseVisualStyleBackColor = true;
            this.btnRegristrarte.Click += new System.EventHandler(this.btnRegristrarte_Click);
            // 
            // btnInvitado
            // 
            this.btnInvitado.Location = new System.Drawing.Point(12, 169);
            this.btnInvitado.Name = "btnInvitado";
            this.btnInvitado.Size = new System.Drawing.Size(75, 23);
            this.btnInvitado.TabIndex = 6;
            this.btnInvitado.Text = "Invitado";
            this.btnInvitado.UseVisualStyleBackColor = true;
            this.btnInvitado.Click += new System.EventHandler(this.btnInvitado_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(169, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 207);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInvitado);
            this.Controls.Add(this.btnRegristrarte);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtNombreU);
            this.Controls.Add(this.lblnombreU);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombreU;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnRegristrarte;
        private System.Windows.Forms.Button btnInvitado;
        private System.Windows.Forms.Button btnCancelar;
    }
}