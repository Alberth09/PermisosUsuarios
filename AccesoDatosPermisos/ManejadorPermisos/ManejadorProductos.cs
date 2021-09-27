using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosPermisos;
using EntidadesPermisos;

namespace ManejadorPermisos
{
    public class ManejadorProductos
    {
        UsuariosAccesoDatos _usuariosAccesoDatos = new UsuariosAccesoDatos();

        public Tuple<bool, string> ValidarProductos(Productos producto)
        {
            bool error = true;
            string CadenasErrores = "";

            if (producto.CodigoBarra.Length == 0 || producto.CodigoBarra == null)
            {
                CadenasErrores = CadenasErrores + "El campo CodigoBarra no puede ser validado \n";
                error = false;
            }
            if (producto.Nombre.Length == 0 || producto.Nombre == null)
            {
                CadenasErrores = CadenasErrores + "El campo nombre no puede ser validado \n";
                error = false;
            }
            if (producto.Descripcion.Length == 0 || producto.Descripcion == null)
            {
                CadenasErrores = CadenasErrores + "El campo descripcion no puede ser validado \n";
                error = false;
            }
            if (producto.Marca.Length == 0 || producto.Marca == null)
            {
                CadenasErrores = CadenasErrores + "El campo marca no puede ser validado \n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, CadenasErrores);
            return valida;
        }

        public void GuardarProductos(Productos producto)
        {
            try
            {
                _usuariosAccesoDatos.GuardarProductos(producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo en guardar " + ex.Message);
            }
        }

        public List<Productos> ObtenerProductos(string filtro)
        {
            var listaContactos = _usuariosAccesoDatos.ObtenerProductos(filtro);
            return listaContactos;
        }

        public void ActualizarProductos(Productos producto)
        {
            try
            {
                _usuariosAccesoDatos.ActualizarProductos(producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo en actualizar " + ex.Message);
            }
        }

        public void EliminarProductos(string producto)
        {
            try
            {
                _usuariosAccesoDatos.EliminarProductos(producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo en eliminar " + ex.Message);
            }
        }
    }
}
