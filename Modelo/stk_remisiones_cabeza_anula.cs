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
    
    public partial class stk_remisiones_cabeza_anula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public stk_remisiones_cabeza_anula()
        {
            this.stk_remisiones_detalle_anula = new HashSet<stk_remisiones_detalle_anula>();
        }
    
        public decimal rem_cod_empresa { get; set; }
        public decimal rem_nro_remision { get; set; }
        public decimal rem_cod_agcia { get; set; }
        public decimal rem_cod_camion { get; set; }
        public decimal rem_cod_chofer { get; set; }
        public decimal rem_clave_remision { get; set; }
        public decimal rem_cod_persona { get; set; }
        public decimal rem_cod_frente { get; set; }
        public System.DateTime rem_fecha_emision { get; set; }
        public string rem_nro_documento { get; set; }
        public decimal rem_nro_autorizacion_impresor { get; set; }
        public decimal rem_nro_timbrado { get; set; }
        public System.DateTime rem_fecha_desde_timbrado { get; set; }
        public System.DateTime rem_fecha_hasta_timbrado { get; set; }
        public decimal rem_cod_vendedor { get; set; }
        public string rem_motivo_trasalado { get; set; }
        public Nullable<System.DateTime> rem_fecha_inicio_traslado { get; set; }
        public string rem_hora_inicio_traslado { get; set; }
        public Nullable<System.DateTime> rem_fecha_entrega { get; set; }
        public string rem_hora_entrega { get; set; }
        public string rem_usuario_entrega { get; set; }
        public Nullable<System.DateTime> rem_fecha_llegada { get; set; }
        public string rem_hora_llegada { get; set; }
        public Nullable<System.DateTime> rem_fecha_carga { get; set; }
        public string rem_hora_carga { get; set; }
        public string rem_usuario_carga { get; set; }
        public Nullable<System.DateTime> rem_fecha_impresion { get; set; }
        public string rem_hora_impresion { get; set; }
        public string rem_usuario_impresion { get; set; }
        public Nullable<System.DateTime> rem_fecha_carga_llegada { get; set; }
        public string rem_hora_carga_llegada { get; set; }
        public string rem_usuario_carga_llegada { get; set; }
        public string rem_facturas_afecta { get; set; }
        public Nullable<decimal> rem_tipo { get; set; }
        public Nullable<decimal> rem_nro_mvto_caja { get; set; }
        public Nullable<System.DateTime> rem_fecha_anula { get; set; }
        public string rem_hora_anula { get; set; }
        public string rem_usuario_anula { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stk_remisiones_detalle_anula> stk_remisiones_detalle_anula { get; set; }
    }
}
