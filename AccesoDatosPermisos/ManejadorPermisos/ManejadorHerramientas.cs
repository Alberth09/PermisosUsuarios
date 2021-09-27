using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosPermisos;
using EntidadesPermisos;

namespace ManejadorPermisos
{
    public class ManejadorHerramientas
    {
        UsuariosAccesoDatos _usuariosAccesoDatos = new UsuariosAccesoDatos();

        public Tuple<bool, string> ValidarHerramientas(Herramientas herra)
        {
            bool error = true;
            string CadenasErrores = "";

            if (herra.Codigoherramienta.Length == 0 || herra.Codigoherramienta == null)
            {
                CadenasErrores = CadenasErrores + "El campo Codigoherramienta no puede ser validado \n";
                error = false;
            }
            if (herra.Nombre.Length == 0 || herra.Nombre == null)
            {
                CadenasErrores = CadenasErrores + "El campo nombre no puede ser validado \n";
                error = false;
            }
            if (herra.Medida.Length == 0 || herra.Medida == null)
            {
                CadenasErrores = CadenasErrores + "El campo medida no puede ser validado \n";
                error = false;
            }
            if (herra.Marca.Length == 0 || herra.Marca == null)
            {
                CadenasErrores = CadenasErrores + "El campo marca no puede ser validado \n";
                error = false;
            }
            if (herra.Descripcion.Length == 0 || herra.Descripcion == null)
            {
                CadenasErrores = CadenasErrores + "El campo descripcion no puede ser validado \n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, CadenasErrores);
            return valida;
        }

        public void GuardarHerramientas(Herramientas herramienta)
        {
            try
            {
                _usuariosAccesoDatos.GuardarHerramientas(herramienta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo en guardar " + ex.Message);
            }
        }

        public List<Herramientas> ObtenerHerramientas(string filtro)
        {
            var listaContactos = _usuariosAccesoDatos.ObtenerHerramientas(filtro);
            return listaContactos;
        }

        public void ActualizarHerramientas(Herramientas herramienta)
        {
            try
            {
                _usuariosAccesoDatos.ActualizarHerramientas(herramienta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo en actualizar " + ex.Message);
            }
        }

        public void EliminarHerramientas(string herramienta)
        {
            try
            {
                _usuariosAccesoDatos.EliminarHerramientas(herramienta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo en eliminar " + ex.Message);
            }
        }
    }
}
