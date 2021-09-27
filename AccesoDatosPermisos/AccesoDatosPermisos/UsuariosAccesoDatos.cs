using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesPermisos;

namespace AccesoDatosPermisos
{
    public class UsuariosAccesoDatos
    {
        AccesoDatosPermisos _conexion;
        public UsuariosAccesoDatos()
        {
            try
            {
                _conexion = new AccesoDatosPermisos("localhost", "root", "", "AgenciaAutomotriz", 3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la conexion" + ex.Message);
            }
        }

        //Herramienta
        public void GuardarHerramientas(Herramientas herramienta)
        {
            try
            {
                string consulta = string.Format("insert into herramientas values('{0}','{1}','{2}','{3}')",
                herramienta.Codigoherramienta, herramienta.Nombre, herramienta.Medida, herramienta.Marca, herramienta.Descripcion);
                _conexion.EjecutarConsultas(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void EliminarHerramientas(string herramienta)
        {
            try
            {
                string consulta = string.Format("delete from herramientas where CodigoHerramienta ='{0}'", herramienta);
                _conexion.EjecutarConsultas(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void ActualizarHerramientas(Herramientas herramienta)
        {
            try
            {
                string consulta = string.Format("update herramientas set nombre = '{0}', medida = '{1}', marca = '{2}', descripcion = '{3}' where CodigoHerramienta = '{4}'", herramienta.Nombre,
                herramienta.Medida, herramienta.Marca, herramienta.Descripcion, herramienta.Codigoherramienta);
                _conexion.EjecutarConsultas(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }
        public List<Herramientas> ObtenerHerramientas (string filtro)
        {
                var ListaHerramientas = new List<Herramientas>();
                var ds = new DataSet();
                string consulta = string.Format("select * from herramientas where Nombre like '%{0}%'", filtro);
                ds = _conexion.ObtenerDatos(consulta, "Herramientas");
                
                var dt = new DataTable();
                dt = ds.Tables[0]; 
                foreach (DataRow row in dt.Rows)
                {
                    var herra = new Herramientas
                    {
                        Codigoherramienta = row["CodigoHerramienta"].ToString(),
                        Nombre = row["nombre"].ToString(),
                        Medida = row["medida"].ToString(),
                        Marca = row["marca"].ToString(),
                        Descripcion = row["descripcion"].ToString(),
                    };
                    ListaHerramientas.Add(herra);
                }
                return ListaHerramientas;
        }

        //Usuarios

        public void GuardarUsuarios(Usuarios usuario)
        {
            try
            {
                string consulta = string.Format("insert into usuarios values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                usuario.Idusuario, usuario.Nombre, usuario.Apellidop, usuario.Apellidom, usuario.Fechanacimiento, usuario.Rfc,
                usuario.Fkidaccesos);
                _conexion.EjecutarConsultas(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void EliminarUsuarios(string usuario)
        {
            try
            {
                string consulta = string.Format("delete from usuarios where idusuarios ='{0}'", usuario);
                _conexion.EjecutarConsultas(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void ActualizarUsuarios(Usuarios usuario)
        {
            try
            {
                string consulta = string.Format("update usuarios set nombre = '{0}', apellidop = '{1}', apellidom = '{2}', fechanacimiento = '{3}', rfc = '{4}',fkidaccesos = '{5}' where idusuarios = '{6}'", usuario.Nombre,
                usuario.Apellidop, usuario.Apellidom, usuario.Fechanacimiento, usuario.Rfc, usuario.Fkidaccesos, usuario.Idusuario);
                _conexion.EjecutarConsultas(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }
        public List<Usuarios> ObtenerUsuarios(string filtro)
        {
            var ListaUsuarios = new List<Usuarios>();
            var ds = new DataSet();
            string consulta = string.Format("select * from usuarios where Nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "usuarios");

            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var uru = new Usuarios
                {
                    Idusuario = int.Parse(row["idusuario"].ToString()),
                    Nombre = row["nombre"].ToString(),
                    Apellidop = row["apellidop"].ToString(),
                    Apellidom = row["apellidom"].ToString(),
                    Fechanacimiento = row["fechanacimiento"].ToString(),
                    Rfc = row["rfc"].ToString(),
                    Fkidaccesos = row["fkidaccesos"].ToString(),
                };
                ListaUsuarios.Add(uru);
            }
            return ListaUsuarios;
        }
        //Productos

        public void GuardarProductos(Productos producto)
        {
            try
            {
                string consulta = string.Format("insert into producto values('{0}','{1}','{2}','{3}')",
                producto.CodigoBarra, producto.Nombre, producto.Descripcion, producto.Marca);
                _conexion.EjecutarConsultas(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void EliminarProductos(string producto)
        {
            try
            {
                string consulta = string.Format("delete from producto where CodigoBarras ='{0}'", producto);
                _conexion.EjecutarConsultas(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void ActualizarProductos(Productos producto)
        {
            try
            {
                string consulta = string.Format("update producto set nombre = '{0}', descripcion = '{1}', marca = '{2}', where CodigoBarras = '{3}'", producto.Nombre,
                producto.Descripcion, producto.Marca, producto.CodigoBarra);
                _conexion.EjecutarConsultas(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public List<Productos> ObtenerProductos(string filtro)
        {
            var ListaProductos = new List<Productos>();
            var ds = new DataSet();
            string consulta = string.Format("select * from producto where Nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "producto");

            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var producto = new Productos
                {
                    CodigoBarra = row["CodigoBarras"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    Marca = row["marca"].ToString(),
                };
                ListaProductos.Add(producto);
            }
            return ListaProductos;
        }
    }
}
