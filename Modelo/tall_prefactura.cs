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
    
    public partial class tall_prefactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tall_prefactura()
        {
            this.tall_prefactura_detalle = new HashSet<tall_prefactura_detalle>();
        }
    
        public decimal pfa_numero { get; set; }
        public decimal pfa_nro_orden { get; set; }
        public System.DateTime pfa_fecha { get; set; }
        public System.TimeSpan pfa_hora { get; set; }
        public string pfa_usuario { get; set; }
        public decimal pfa_estado { get; set; }
        public Nullable<System.DateTime> pfa_fecha_elimina { get; set; }
        public Nullable<System.TimeSpan> pfa_hora_elimina { get; set; }
        public string pfa_usuario_elimina { get; set; }
        public string pfa_observaciones { get; set; }
    
        public virtual tall_ordenes tall_ordenes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tall_prefactura_detalle> tall_prefactura_detalle { get; set; }
    }
}
