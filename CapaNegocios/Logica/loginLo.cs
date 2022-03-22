using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaNegocios.Clases
{
    public class loginLo
    {
        private static string _contra;
        private static int _id;
        public int Id { get => _id; set => _id = value; }
        public string Contra { get => _contra; set => _contra = value; }
        public bool ContraSafe(string _contra)
        {
            try
            {
                bool may = false, min = false, num = false, carac = false;
                for (int i = 0; i < _contra.Length; i++)
                {
                    if (char.IsUpper(_contra, i))
                    {
                        may = true;
                    }
                    else if (char.IsLower(_contra, i))
                    {
                        min = true;
                    }
                    else if (char.IsDigit(_contra, i))
                    {
                        num = true;
                    }
                    else
                    {
                        carac = true;
                    }
                }

                if (may && min && num && carac.Equals(true) && _contra.Length >= 8)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
                throw;
            }




        }

        public string ValidarUsuario(int _Id, string _Contra)
        {
            var mensaje = new System.Data.Entity.Core.Objects.ObjectParameter("Mensaje", typeof(string));

            using ( CentroBankEntities db = new CentroBankEntities())
            {
                db.sp_ValidarUsuario(_Id, _Contra, mensaje);
                string retor = mensaje.Value.ToString();
                return retor;
            }

        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }




    }
}
