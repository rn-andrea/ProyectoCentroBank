using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Data
{
    public class Dsolicitud
    {
        public int Idu  {get ; set; }
    public string tipoid { get; set; }
        public string nombre { get; set; }
        public string appelido { get; set; }
        public string Nacimiento { get; set; }
        public int Telefono { get; set; }
        public string provincia { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public int tipocred { get; set; }
        public float monto { get; set; }
        public string FechaSoli { get; set; }


    }
}
