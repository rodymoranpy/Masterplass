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
    
    public partial class tall_tipos_danos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tall_tipos_danos()
        {
            this.tall_tareas_tiempos = new HashSet<tall_tareas_tiempos>();
        }
    
        public decimal tid_codigo { get; set; }
        public string tid_descripcion { get; set; }
        public decimal tid_nro_entrada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tall_tareas_tiempos> tall_tareas_tiempos { get; set; }
    }
}
