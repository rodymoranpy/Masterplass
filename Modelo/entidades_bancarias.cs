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
    
    public partial class entidades_bancarias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public entidades_bancarias()
        {
            this.cajas_mov_valores = new HashSet<cajas_mov_valores>();
            this.fina_datos_cheques = new HashSet<fina_datos_cheques>();
            this.fina_datos_tarjetas = new HashSet<fina_datos_tarjetas>();
        }
    
        public decimal cod_entidad { get; set; }
        public string nombre_entidad { get; set; }
        public decimal emisor_tarjeta { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string userid { get; set; }
        public decimal nro_entrada { get; set; }
        public string dia_descuento { get; set; }
        public Nullable<decimal> porc_dia_descuento { get; set; }
        public Nullable<System.DateTime> fecha_descuento { get; set; }
        public Nullable<decimal> porc_fecha_descuento { get; set; }
        public string codigo_bic { get; set; }
        public string nombre_oficial { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cajas_mov_valores> cajas_mov_valores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fina_datos_cheques> fina_datos_cheques { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fina_datos_tarjetas> fina_datos_tarjetas { get; set; }
    }
}
