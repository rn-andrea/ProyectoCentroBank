//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tendencias
    {
        public int IDTendencia { get; set; }
        public string tendencia { get; set; }
        public int IdTipoCreditos { get; set; }
    
        public virtual TipoCreditos TipoCreditos { get; set; }
    }
}
