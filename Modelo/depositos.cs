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
    
    public partial class depositos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public depositos()
        {
            this.depositos_areas = new HashSet<depositos_areas>();
        }
    
        public decimal cod_empresa { get; set; }
        public decimal cod_deposito { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string encargado { get; set; }
        public decimal cod_agcia { get; set; }
        public string cta_contable { get; set; }
        public decimal estado { get; set; }
        public string usuario { get; set; }
        public decimal nro_entrada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<depositos_areas> depositos_areas { get; set; }
    }
}
