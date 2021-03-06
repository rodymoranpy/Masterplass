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
    
    public partial class facturas_cab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public facturas_cab()
        {
            this.facturas_cuotas = new HashSet<facturas_cuotas>();
            this.fondo_fijo1 = new HashSet<fondo_fijo>();
        }
    
        public decimal cod_empresa { get; set; }
        public decimal operacion { get; set; }
        public decimal nro_entrada { get; set; }
        public decimal tipo_factura { get; set; }
        public string nro_factura { get; set; }
        public string nro_factura_legal { get; set; }
        public string nota_credito { get; set; }
        public decimal cod_persona { get; set; }
        public decimal cod_rubro { get; set; }
        public System.DateTime fecha_emision { get; set; }
        public System.DateTime fecha_vto { get; set; }
        public decimal cod_money { get; set; }
        public decimal t_cambio { get; set; }
        public decimal imponible { get; set; }
        public decimal imponible10 { get; set; }
        public decimal imponible5 { get; set; }
        public decimal iva { get; set; }
        public decimal iva10 { get; set; }
        public decimal iva5 { get; set; }
        public decimal exenta { get; set; }
        public decimal total { get; set; }
        public decimal pct_descuento { get; set; }
        public decimal descuento { get; set; }
        public decimal neto { get; set; }
        public decimal a_abonar { get; set; }
        public decimal abonado { get; set; }
        public decimal saldo { get; set; }
        public decimal imponible_gs { get; set; }
        public decimal imponible10_gs { get; set; }
        public decimal imponible5_gs { get; set; }
        public decimal iva_gs { get; set; }
        public decimal iva10_gs { get; set; }
        public decimal iva5_gs { get; set; }
        public decimal exenta_gs { get; set; }
        public decimal total_gs { get; set; }
        public decimal descuento_gs { get; set; }
        public decimal neto_gs { get; set; }
        public decimal a_abonar_gs { get; set; }
        public decimal provisionar { get; set; }
        public decimal nro_asto { get; set; }
        public string cta_credito { get; set; }
        public decimal fondo_fijo { get; set; }
        public Nullable<decimal> nro_caja { get; set; }
        public decimal utiliza_serie { get; set; }
        public System.DateTime fecha_carga { get; set; }
        public string hora_carga { get; set; }
        public string usuario_carga { get; set; }
        public Nullable<System.DateTime> fecha_provisiona { get; set; }
        public string hora_provisiona { get; set; }
        public string usuario_provisiona { get; set; }
        public Nullable<System.DateTime> fecha_elimina { get; set; }
        public string hora_elimina { get; set; }
        public string usuario_elimina { get; set; }
        public Nullable<System.DateTime> fecha_factura_legal { get; set; }
        public string hora_factura_legal { get; set; }
        public string usuario_factura_legal { get; set; }
        public Nullable<System.DateTime> fecha_impresion_factura { get; set; }
        public string hora_impresion_factura { get; set; }
        public string usuario_impresion_factura { get; set; }
        public decimal nro_asto_elim { get; set; }
        public string nro_referencia { get; set; }
        public decimal otros { get; set; }
        public decimal otros_gs { get; set; }
        public decimal nro_entrada_fact { get; set; }
        public decimal cod_agcia { get; set; }
        public decimal nro_lote { get; set; }
        public Nullable<System.DateTime> fecha_lote { get; set; }
        public string hora_lote { get; set; }
        public string usuario_lote { get; set; }
        public string nro_timbrado { get; set; }
        public Nullable<System.DateTime> fecha_recibe { get; set; }
        public string hora_recibe { get; set; }
        public string usuario_recibe { get; set; }
        public decimal certificado { get; set; }
        public Nullable<decimal> nro_entrada_certificado { get; set; }
        public decimal nro_entrada_agcia { get; set; }
        public decimal monto_retencion { get; set; }
        public decimal monto_retencion_gs { get; set; }
        public Nullable<decimal> cod_vendedor { get; set; }
        public Nullable<System.DateTime> fecha_recepcion { get; set; }
        public string usuario_archivo { get; set; }
        public Nullable<System.DateTime> fecha_archivo { get; set; }
        public string hora_archivo { get; set; }
        public Nullable<decimal> marca { get; set; }
        public string documento_cliente { get; set; }
        public string documento_vendedor { get; set; }
        public Nullable<decimal> cod_persona_anterior { get; set; }
        public Nullable<decimal> cod_vendedor_anterior { get; set; }
        public Nullable<decimal> clave_orden { get; set; }
        public string observaciones { get; set; }
        public Nullable<System.DateTime> fecha_vto_timbrado { get; set; }
        public Nullable<decimal> nro_despacho { get; set; }
        public Nullable<decimal> ejercicio_despacho { get; set; }
    
        public virtual monedas monedas { get; set; }
        public virtual personas personas { get; set; }
        public virtual rubros rubros { get; set; }
        public virtual tipos_facturas tipos_facturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<facturas_cuotas> facturas_cuotas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fondo_fijo> fondo_fijo1 { get; set; }
    }
}
