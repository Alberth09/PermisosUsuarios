using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPermisos;
using ManejadorPermisos;

namespace PresentacionPermisos
{
    public partial class FrmLogin : Form
    {
        public static ManejadorUsuarios _usuariosManejador;
        private Usuarios _usuarios;
        public FrmLogin()
        {
            InitializeComponent();
            _usuariosManejador = new ManejadorUsuarios();
            _usuarios = new Usuarios();
        }

        private void btnRegristrarte_Click(object sender, EventArgs e)
        {
            _usuarios.Nombre = txtNombreU.Text;
            _usuarios.Contraseña = txtContraseña.Text;
            if (_usuariosManejador.ExisteUsuario(_usuarios))
            {
                if (txtNombreU.Text == "Alberto" && txtContraseña.Text == "password")
                {
                    FrmMenu formmenu = new FrmMenu();
                    formmenu.Show();
                    this.Hide();

                    MessageBox.Show("bienvenido administrador");
                    formmenu.lblTipoCuenta.Text = "Administrador";
                }

                else
                {
                    FrmMenu formmenu = new FrmMenu();
                    formmenu.Show();
                    this.Hide();
                    formmenu.btnUsuarios.Visible = false;
                    formmenu.lblUsuario.Visible = false;


                    MessageBox.Show("Bienvenido " + txtNombreU.Text + ", tienes permisos restringidos");
                    formmenu.lblTipoCuenta.Text = "Usuario";
                }
            }
        }


        private void btnInvitado_Click(object sender, EventArgs e)
        {
            FrmMenu formmenu = new FrmMenu();
            formmenu.Show();
            this.Hide();
            formmenu.toolStrip1.Enabled = false;
            formmenu.btnSalir.Enabled = true;


            MessageBox.Show("No puedes acceder al contenido de este formulario");
        }
    }
}
       
