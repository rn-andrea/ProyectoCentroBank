using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

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

            float a = (1 + taza / 100);
            Double x = Math.Pow(a, -plazo);
            resultado = ((taza / 100) * monto) / (1 - x);



            return resultado;
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
        private List<TipoCreditos> GetTasa1()
        {
           
            var query = from c in entities.TipoCreditos
                        where c.IdTipoCreditos == 1
                        select c;
            return query.ToList();

        }

        public int GetTasaP1()
        {

            TipoCreditos tipo = new TipoCreditos();
            //validacion de datos
            //try
            //{
            List<TipoCreditos> listaUsuarios = new List<TipoCreditos>();
            List<TipoCreditos> dataUsers = GetTasa1();
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
                        where c.IdTipoCreditos == 3
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
                        where c.IdTipoCreditos == 4
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
                        where c.IdTipoCreditos == 5
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
                        where c.IdTipoCreditos == 6
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
                        where c.IdTipoCreditos == 7
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
                        where c.IdTipoCreditos == 8
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
                        where c.IdTipoCreditos == 9
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
                        where c.IdTipoCreditos == 10
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
