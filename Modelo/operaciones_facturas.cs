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
    
    public partial class operaciones_facturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public operaciones_facturas()
        {
            this.rubros = new HashSet<rubros>();
            this.tipos_facturas = new HashSet<tipos_facturas>();
        }
    
        public decimal operacion { get; set; }
        public string descripcion { get; set; }
        public decimal serie_factura { get; set; }
        public decimal origen { get; set; }
        public decimal operacion_borrador { get; set; }
        public decimal tipo_comprobante { get; set; }
        public string usuario { get; set; }
        public decimal nro_entrada { get; set; }
        public Nullable<decimal> operacion_borrador_elim { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rubros> rubros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tipos_facturas> tipos_facturas { get; set; }
    }
}
