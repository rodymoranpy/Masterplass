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
    
    public partial class cajas_habilitaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cajas_habilitaciones()
        {
            this.cajas_mov_cab = new HashSet<cajas_mov_cab>();
        }
    
        public decimal cod_empresa { get; set; }
        public decimal cod_agcia { get; set; }
        public decimal nro_caja { get; set; }
        public decimal nro_habilitacion { get; set; }
        public string cajero { get; set; }
        public System.DateTime fecha_apertura { get; set; }
        public string hora_apertura { get; set; }
        public string estado_caja { get; set; }
        public string usuario_apertura { get; set; }
        public Nullable<System.DateTime> fecha_cierre { get; set; }
        public string hora_cierre { get; set; }
        public string usuario_cierre { get; set; }
        public decimal efectivo_gs_cierre { get; set; }
        public decimal efectivo_me_cierre { get; set; }
        public Nullable<decimal> patio { get; set; }
    
        public virtual cajas cajas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cajas_mov_cab> cajas_mov_cab { get; set; }
        public virtual usuarios_empresas usuarios_empresas { get; set; }
    }
}
