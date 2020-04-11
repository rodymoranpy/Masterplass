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
    
    public partial class fina_datos_tarjetas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fina_datos_tarjetas()
        {
            this.fina_movimientos_caja = new HashSet<fina_movimientos_caja>();
        }
    
        public decimal tar_cod_empresa { get; set; }
        public decimal tar_clave_tarjeta { get; set; }
        public decimal tar_cod_sucursal { get; set; }
        public Nullable<decimal> tar_cod_banco { get; set; }
        public decimal tar_cod_marca { get; set; }
        public decimal tar_nro_tarjeta { get; set; }
        public string tar_nombre_titular { get; set; }
        public string tar_nro_confirmacion { get; set; }
        public System.DateTime tar_fecha_carga { get; set; }
        public System.TimeSpan tar_hora_carga { get; set; }
        public string tar_usuario_carga { get; set; }
        public decimal tar_cod_moneda { get; set; }
        public decimal tar_importe { get; set; }
        public decimal tar_importe_loc { get; set; }
        public Nullable<System.DateTime> tar_fecha_cobro { get; set; }
        public Nullable<System.TimeSpan> tar_hora_cobro { get; set; }
        public string tar_usuario_cobro { get; set; }
        public decimal tar_estado { get; set; }
        public decimal tar_nro_entrada { get; set; }
    
        public virtual agencias agencias { get; set; }
        public virtual entidades_bancarias entidades_bancarias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fina_movimientos_caja> fina_movimientos_caja { get; set; }
        public virtual monedas monedas { get; set; }
    }
}
