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
    
    public partial class tall_motivos_rechazo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tall_motivos_rechazo()
        {
            this.tall_fichas_presupuestos = new HashSet<tall_fichas_presupuestos>();
            this.tall_fichas_presupuestos1 = new HashSet<tall_fichas_presupuestos>();
        }
    
        public decimal mre_codigo { get; set; }
        public string mre_descripcion { get; set; }
        public decimal mre_nro_entrada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tall_fichas_presupuestos> tall_fichas_presupuestos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tall_fichas_presupuestos> tall_fichas_presupuestos1 { get; set; }
    }
}
