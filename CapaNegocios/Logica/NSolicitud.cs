using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

//DANIELA 
namespace CapaNegocios.Logica
{
    public class NSolicitud
    {
        private CentroBankEntities entities;

        public NSolicitud()
        {
            entities = new CentroBankEntities();
        }

        public List<TipoCreditos> GetTipoCredito()
        {
            try
            {
                var query = from c in entities.TipoCreditos
                            select c;

                return query.ToList<TipoCreditos>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

        public List<sp_Recepcion_Result> MostrarRecepcion()
        {
            using(CentroBankEntities dm = new CentroBankEntities())
            {
                return dm.sp_Recepcion().ToList();
            }
        }
    }
}

