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
    
    public partial class tall_tipos_tareas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tall_tipos_tareas()
        {
            this.tall_tareas_tiempos = new HashSet<tall_tareas_tiempos>();
        }
    
        public decimal tpa_codigo { get; set; }
        public decimal tpa_cod_dependencia { get; set; }
        public Nullable<decimal> tpa_cod_parte { get; set; }
        public Nullable<decimal> tpa_tipo_trabajo { get; set; }
        public string tpa_descripcion { get; set; }
        public Nullable<decimal> tpa_cod_departamento { get; set; }
        public decimal tpa_nro_entrada { get; set; }
    
        public virtual tall_departamentos_cia tall_departamentos_cia { get; set; }
        public virtual tall_partes tall_partes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tall_tareas_tiempos> tall_tareas_tiempos { get; set; }
        public virtual tall_tipos_trabajos tall_tipos_trabajos { get; set; }
    }
}
