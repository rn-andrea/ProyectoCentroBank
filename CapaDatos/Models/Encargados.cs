//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Encargados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Encargados()
        {
            this.TipoCambio = new HashSet<TipoCambio>();
        }
    
        public int IdEncargado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public System.DateTime Nacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public int IdProvincia { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public int IdRol { get; set; }
        public byte[] Contrasena { get; set; }
    
        public virtual Provincias Provincias { get; set; }
        public virtual Roles Roles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoCambio> TipoCambio { get; set; }
    }
}
