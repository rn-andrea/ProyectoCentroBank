using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatos.Data
{
    public class CalculadoraModel
    {
        public double resultado { get; set; }
        public int porcentage { get; set; }
        public int Dolares { get; set; } // cambio venta 656 y compra 641
        public int Colones { get; set; }

        public int Monto { get; set; }
        public int plazo { get; set; }
        public float taza { get; set; }
        //metodo que nos de el valor del porcentage,
        public int Dolar()
        {
            return Dolares;
        }
        public int Colon()
        {
            return Colones;
        }
    }
}