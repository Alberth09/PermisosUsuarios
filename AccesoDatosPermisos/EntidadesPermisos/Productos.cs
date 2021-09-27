using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Productos
    {
        private string _codigoBarra;
        private string _nombre;
        private string _descripcion;
        private string _marca;

        public string CodigoBarra { get => _codigoBarra; set => _codigoBarra = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Marca { get => _marca; set => _marca = value; }
    }
}
