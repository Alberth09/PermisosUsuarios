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
    public partial class FrmCrearProductos : Form
    {
        private ManejadorProductos _manejaprod;
        private Productos _producto;

        public static FrmVistaProducto fr = new FrmVistaProducto();
        public string banderaGuardar;
        public FrmCrearProductos(FrmVistaProducto registro)
        {
            InitializeComponent();
            _manejaprod = new ManejadorProductos();
            _producto = new Productos();
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


        private void GuardarProducto()
        {
            _producto.CodigoBarra = txtCodigo3.Text;
            _producto.Nombre = txtNombre3.Text;
            _producto.Descripcion = txtDescripcion3.Text;
            _producto.Marca = txtMarca3.Text;

            var valida = _manejaprod.ValidarProductos(_producto);

            if (valida.Item1)
            {
                _manejaprod.GuardarProductos(_producto);
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
                GuardarProducto();
                Agregard();
                Close();
            }

            else
            {
                ActualizarProducto();
                Close();
            }
        }

        private void ActualizarProducto()
        {
            _manejaprod.ActualizarProductos(new Productos
            {

                CodigoBarra = txtCodigo3.Text,
                Nombre = txtNombre3.Text,
                Descripcion = txtDescripcion3.Text,
                Marca = txtMarca3.Text


            });
        }
    }
}
