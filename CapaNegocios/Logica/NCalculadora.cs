using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios.Logica
{
    public class NCalculadora
    {
        private CentroBankEntities entities;
        private static int _tipoCredito;
        public NCalculadora()
        {
            entities = new CentroBankEntities();
        }

        public int tipo { get => _tipoCredito; set => _tipoCredito = value; }
        public double resultado { get; set; }
        public double Calculo(int monto, float taza, int plazo)
        {
            float t2 = taza / 12;
            float a = (1 + t2 / 100);
            Double x = Math.Pow(a, -plazo);
            resultado = ((t2 / 100) * monto) / (1 - x);



            return resultado;
        }
        public List<TipoCreditos> GetCreditos()
        {
            try
            {
                var query = from c in entities.TipoCreditos
                            select c;
                return query.ToList<TipoCreditos>();

            }
            catch(Exception ex)
            {
                throw ex;
            }

            
        }
        public int LimitePlazo(string tipoP, int plazo)
        {//limite de dinero dolares
            if (tipoP == "Préstamo Personal")
            {
                if (plazo >= 6 && plazo <= 240)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Unificación de deudas")
            {
                if (plazo >= 6 && plazo <= 60)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "MiniCredito")
            {
                if (plazo >= 6 && plazo <= 60)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Préstamo Multiproposito")
            {
                if (plazo >= 6 && plazo <= 240)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Compra Vehículos")
            {
                if (plazo >= 6 && plazo <= 96)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Vehículo Sostenible")
            {
                if (plazo >= 6 && plazo <= 96)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Leasing Financiero")
            {
                if (plazo >= 6 && plazo <= 96)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Compra Vivienda")
            {
                if (plazo >= 120 && plazo <= 360)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Compra Lote")
            {
                if (plazo >= 120 && plazo <= 360)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Traslado de Hipoteca")
            {
                if (plazo >= 120 && plazo <= 360)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            return 2;
        }

        public int LimiteDineroD(string tipoP, float monto)
        {//limite de dinero dolares
            if (tipoP == "Préstamo Personal")
            {
                if (monto >= 400 && monto <= 23000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Unificación de deudas")
            {
                if (monto >= 200 && monto <= 23000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "MiniCredito")
            {
                if (monto >= 200 && monto <= 1000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Préstamo Multiproposito")
            {
                if (monto >= 1500 && monto <= 62000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Compra Vehículos")
            {
                if (monto >= 1500 && monto <= 62000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Vehículo Sostenible")
            {
                if (monto >= 1500 && monto <= 62000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Leasing Financiero")
            {
                if (monto >= 1500 && monto <= 62000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Compra Vivienda")
            {
                if (monto >= 7500 && monto <= 152000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Compra Lote")
            {
                if (monto >= 7500 && monto <= 152000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Traslado de Hipoteca")
            {
                if (monto >= 7500 && monto <= 152000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            return 2;
        }
        //limite de dinero colones
        public int LimiteDinero (string tipoP, float monto)
        {
            if(tipoP== "Préstamo Personal")
            {
                if (monto>= 250000 && monto <= 15000000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Unificación de deudas")
            {
                if (monto >= 100000 && monto <= 15000000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "MiniCredito")
            {
                if (monto >= 100000 && monto <= 650000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Préstamo Multiproposito")
            {
                if (monto >= 1000000 && monto <= 40000000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Compra Vehículos")
            {
                if (monto >= 1000000 && monto <= 40000000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Vehículo Sostenible")
            {
                if (monto >= 1000000 && monto <= 40000000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Leasing Financiero")
            {
                if (monto >= 1000000 && monto <= 40000000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Crédito Compra Vivienda")
            {
                if (monto >= 5000000 && monto <= 100000000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Compra Lote")
            {
                if (monto >= 5000000 && monto <= 100000000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else if (tipoP == "Traslado de Hipoteca")
            {
                if (monto >= 5000000 && monto <= 100000000)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            return 2;
        }

        private List<TipoCambio> GetDollar()
        {

            var query = from c in entities.TipoCambio
                        where c.IdTipoCambio == 1
                        select c;
            return query.ToList();

        }

        public decimal GetDollarp()
        {

            TipoCambio tipo = new TipoCambio();
            //validacion de datos
            //try
            //{
            List<TipoCambio> listaUsuarios = new List<TipoCambio>();
            List<TipoCambio> dataUsers = GetDollar();
            foreach (TipoCambio us in dataUsers)
            {

                tipo.Venta = us.Venta;
                listaUsuarios.Add(tipo);
            }

            return (decimal)tipo.Venta;

        }
        // prestamopersonal
        private List<TipoCreditos> GetTasa1(string tipoC)
        {
           
            var query = from c in entities.TipoCreditos
                        where c.TipoCredito == tipoC
                        select c;
            return query.ToList();

        }

        public int GetTasaP1(string tipoC)
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa1(tipoC);
            foreach (TipoCreditos us in dataUsers)
            {

                tipo.Tasa = us.Tasa;
                listaUsuarios.Add(tipo);
            }

            return (int)tipo.Tasa;

        }
        //unificacion de deudas
        private List<TipoCreditos> GetTasa2()
        {

            var query = from c in entities.TipoCreditos
                        where c.IdTipoCreditos == 2
                        select c;
            return query.ToList();

        }

        public int GetTasaP2()
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa2();
            foreach (TipoCreditos us in dataUsers)
            {

                tipo.Tasa = us.Tasa;
                listaUsuarios.Add(tipo);
            }

            return (int)tipo.Tasa;

        }
        private List<TipoCreditos> GetTasa3()
        {

            var query = from c in entities.TipoCreditos
                        where c.IdTipoCreditos == 8
                        select c;
            return query.ToList();

        }

        public int GetTasaP3()
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa3();
            foreach (TipoCreditos us in dataUsers)
            {

                tipo.Tasa = us.Tasa;
                listaUsuarios.Add(tipo);
            }

            return (int)tipo.Tasa;

        }
        private List<TipoCreditos> GetTasa4()
        {

            var query = from c in entities.TipoCreditos
                        where c.IdTipoCreditos == 9
                        select c;
            return query.ToList();

        }

        public int GetTasaP4()
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa4();
            foreach (TipoCreditos us in dataUsers)
            {

                tipo.Tasa = us.Tasa;
                listaUsuarios.Add(tipo);
            }

            return (int)tipo.Tasa;

        }
        private List<TipoCreditos> GetTasa5()
        {

            var query = from c in entities.TipoCreditos
                        where c.IdTipoCreditos == 10
                        select c;
            return query.ToList();

        }

        public int GetTasaP5()
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa5();
            foreach (TipoCreditos us in dataUsers)
            {

                tipo.Tasa = us.Tasa;
                listaUsuarios.Add(tipo);
            }

            return (int)tipo.Tasa;

        }
        private List<TipoCreditos> GetTasa6()
        {

            var query = from c in entities.TipoCreditos
                        where c.IdTipoCreditos == 11
                        select c;
            return query.ToList();

        }

        public int GetTasaP6()
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa6();
            foreach (TipoCreditos us in dataUsers)
            {

                tipo.Tasa = us.Tasa;
                listaUsuarios.Add(tipo);
            }

            return (int)tipo.Tasa;

        }

        private List<TipoCreditos> GetTasa7()
        {

            var query = from c in entities.TipoCreditos
                        where c.IdTipoCreditos == 12
                        select c;
            return query.ToList();

        }

        public int GetTasaP7()
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa7();
            foreach (TipoCreditos us in dataUsers)
            {

                tipo.Tasa = us.Tasa;
                listaUsuarios.Add(tipo);
            }

            return (int)tipo.Tasa;

        }

        private List<TipoCreditos> GetTasa8()
        {

            var query = from c in entities.TipoCreditos
                        where c.IdTipoCreditos == 13
                        select c;
            return query.ToList();

        }

        public int GetTasaP8()
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa8();
            foreach (TipoCreditos us in dataUsers)
            {

                tipo.Tasa = us.Tasa;
                listaUsuarios.Add(tipo);
            }

            return (int)tipo.Tasa;

        }
        private List<TipoCreditos> GetTasa9()
        {

            var query = from c in entities.TipoCreditos
                        where c.IdTipoCreditos == 14
                        select c;
            return query.ToList();

        }

        public int GetTasaP9()
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa9();
            foreach (TipoCreditos us in dataUsers)
            {

                tipo.Tasa = us.Tasa;
                listaUsuarios.Add(tipo);
            }

            return (int)tipo.Tasa;

        }
        private List<TipoCreditos> GetTasa10()
        {

            var query = from c in entities.TipoCreditos
                        where c.IdTipoCreditos == 15
                        select c;
            return query.ToList();

        }

        public int GetTasaP10()
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa10();
            foreach (TipoCreditos us in dataUsers)
            {

                tipo.Tasa = us.Tasa;
                listaUsuarios.Add(tipo);
            }

            return (int)tipo.Tasa;

        }
    }
}
