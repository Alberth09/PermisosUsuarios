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
    public partial class FrmCrearHerramientas : Form
    {
        private ManejadorHerramientas _manejadorherra;
        private Herramientas _herramienta;

        public static FrmVistaHerramientas fr = new FrmVistaHerramientas();
        public string banderaGuardar;
        public FrmCrearHerramientas(FrmCrearHerramientas registro)
        {
            InitializeComponent();
            _herramienta = new Herramientas();
            _manejadorherra = new ManejadorHerramientas();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregard()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void GuardarHerramienta()
        {
            _herramienta.Codigoherramienta = txtCodigo2.Text;
            _herramienta.Nombre = txtNombre2.Text;
            _herramienta.Medida = txtMedida2.Text;
            _herramienta.Marca = txtMarca2.Text;
            _herramienta.Descripcion = txtDescripcion2.Text;



            var valida = _manejadorherra.ValidarHerramientas(_herramienta);

            if (valida.Item1)
            {
                _manejadorherra.GuardarHerramientas(_herramienta);
            }

            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            if (banderaGuardar == "guardar")
            {
                GuardarHerramienta();
                Agregard();
                Close();
            }

            else
            {
                ActualizarHerramientas();
                Close();
            }
        }

        private void ActualizarHerramientas()
        {
            _manejadorherra.ActualizarHerramientas(new Herramientas
            {
                Codigoherramienta = txtCodigo2.Text,
                Nombre = txtNombre2.Text,
                Medida = txtMedida2.Text,
                Marca = txtMarca2.Text,
                Descripcion = txtDescripcion2.Text

            });
        }
    }
}
