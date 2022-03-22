using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaDatos.Data;

namespace CapaNegocios.Logica
{
  public class solicitudLo
    {
        Dsolicitud objso = new Dsolicitud();

        public int Idu { get => objso.Idu; set =>objso.Idu  = value; }
        public string tipoid { get => objso.tipoid; set => objso.tipoid = value; }
        public string nombre { get => objso.nombre; set => objso.nombre = value; }
        public string appelido { get => objso.appelido; set => objso.appelido = value; }
        public string Nacimiento { get => objso.Nacimiento; set => objso.Nacimiento = value; }
        public int Telefono { get => objso.Telefono; set => objso.Telefono = value; }
        public string provincia { get => objso.provincia; set => objso.provincia = value; }
        public string correo { get => objso.correo; set => objso.correo = value; }
        public string direccion { get => objso.direccion; set => objso.direccion = value; }
        public int tipocred { get => objso.tipocred; set => objso.tipocred = value; }
        public float monto { get => objso.monto; set => objso.monto = value; }
        public string FechaSoli { get => objso.FechaSoli; set => objso.FechaSoli = value; }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
        public string RegistroSolicitudC(int _idSoli,int _IdUsu,string _tipoid,string _nombre,string _apellido,string _fechaN, int _telefono,string _provincia,string _correo,string _direecion,int _tipocredito,float _monto, string _fechasoli)
        {
            var mensaje = new System.Data.Entity.Core.Objects.ObjectParameter("Mensaje", typeof(string));
           

            using (CentroBankEntities db = new CentroBankEntities())
            {
                db.sp_Registro_SolicitudCredito( _IdUsu,_idSoli,_tipoid,_nombre,_apellido, Convert.ToDateTime(_fechaN), _telefono,_provincia,_correo,_direecion,_tipocredito,_monto, Convert.ToDateTime(_fechasoli), mensaje);
                string retor = mensaje.Value.ToString();
                return retor;
            }

        }

    }
}
