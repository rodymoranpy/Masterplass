//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tall_partes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tall_partes()
        {
            this.tall_partes_vehiculos = new HashSet<tall_partes_vehiculos>();
            this.tall_tipos_tareas = new HashSet<tall_tipos_tareas>();
        }
    
        public decimal par_codigo { get; set; }
        public string par_descripcion { get; set; }
        public decimal par_pulida { get; set; }
        public decimal par_nro_entrada { get; set; }
        public Nullable<decimal> par_tipo_trabajo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tall_partes_vehiculos> tall_partes_vehiculos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tall_tipos_tareas> tall_tipos_tareas { get; set; }
    }
}
