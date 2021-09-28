using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosPermisos;
using EntidadesPermisos;

namespace ManejadorPermisos
{
    public class ManejadorUsuarios
    {
        UsuariosAccesoDatos _usuariosAccesoDatos = new UsuariosAccesoDatos();

        public Tuple<bool, string> ValidarUruarios(Usuarios usu)
        {
            bool error = true;
            string CadenasErrores = "";

            if (usu.Idusuario == null)
            {
                CadenasErrores = CadenasErrores + "El campo idusuario no puede ser validado \n";
                error = false;
            }
            if (usu.Nombre.Length == 0 || usu.Nombre == null)
            {
                CadenasErrores = CadenasErrores + "El campo nombre no puede ser validado \n";
                error = false;
            }
            if (usu.Apellidop.Length == 0 || usu.Apellidop == null)
            {
                CadenasErrores = CadenasErrores + "El campo apellidop no puede ser validado \n";
                error = false;
            }
            if (usu.Apellidom.Length == 0 || usu.Apellidom == null)
            {
                CadenasErrores = CadenasErrores + "El campo apellidom no puede ser validado \n";
                error = false;
            }
            if (usu.Fechanacimiento.Length == 0 || usu.Fechanacimiento == null)
            {
                CadenasErrores = CadenasErrores + "El campo fechanacimiento no puede ser validado \n";
                error = false;
            }
            if (usu.Rfc.Length == 0 || usu.Rfc == null)
            {
                CadenasErrores = CadenasErrores + "El campo rfc no puede ser validado \n";
                error = false;
            }
            if (usu.Fkidaccesos.Length == 0 || usu.Fkidaccesos == null)
            {
                CadenasErrores = CadenasErrores + "El campo fkidaccesos no puede ser validado \n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, CadenasErrores);
            return valida;
        }

        public void GuardarUsuarios(Usuarios usuario)
        {
            try
            {
                _usuariosAccesoDatos.GuardarUsuarios(usuario);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo en guardar " + ex.Message);
            }
        }

        public List<Usuarios> ObtenerUsuarios(string filtro)
        {
            var listaContactos = _usuariosAccesoDatos.ObtenerUsuarios(filtro);
            return listaContactos;
        }

        public void ActualizarUsuarios(Usuarios usuario)
        {
            try
            {
                _usuariosAccesoDatos.ActualizarUsuarios(usuario);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo en actualizar " + ex.Message);
            }
        }

        public void EliminarUsuarios(string usuario)
        {
            try
            {
                _usuariosAccesoDatos.EliminarUsuarios(usuario);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo en eliminar " + ex.Message);
            }
        }
        public bool ExisteUsuario(Usuarios usuario)
        {
            var existe = _usuariosAccesoDatos.ExisteUsuario(usuario);
            return existe;
        }
    }
}
