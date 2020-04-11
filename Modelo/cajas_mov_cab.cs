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
    
    public partial class cajas_mov_cab
    {
        public decimal cod_empresa { get; set; }
        public decimal cod_agcia { get; set; }
        public decimal nro_caja { get; set; }
        public decimal nro_habilitacion { get; set; }
        public decimal nro_mvto { get; set; }
        public System.DateTime fecha { get; set; }
        public string hora { get; set; }
        public decimal tipo_venta { get; set; }
        public string tipo_mvto { get; set; }
        public decimal tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public Nullable<decimal> nro_timbrado { get; set; }
        public Nullable<System.DateTime> fecha_vto_timbrado { get; set; }
        public Nullable<decimal> cod_persona { get; set; }
        public string nombre_persona { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public decimal cod_money { get; set; }
        public decimal t_cambio { get; set; }
        public decimal imponible5 { get; set; }
        public decimal imponible10 { get; set; }
        public decimal imponible { get; set; }
        public decimal iva5 { get; set; }
        public decimal iva10 { get; set; }
        public decimal iva { get; set; }
        public decimal exento { get; set; }
        public decimal otros { get; set; }
        public decimal total { get; set; }
        public decimal descuento { get; set; }
        public decimal neto { get; set; }
        public decimal donacion { get; set; }
        public decimal imponible5_gs { get; set; }
        public decimal imponible10_gs { get; set; }
        public decimal imponible_gs { get; set; }
        public decimal iva5_gs { get; set; }
        public decimal iva10_gs { get; set; }
        public decimal iva_gs { get; set; }
        public decimal exento_gs { get; set; }
        public decimal otros_gs { get; set; }
        public decimal total_gs { get; set; }
        public decimal descuento_gs { get; set; }
        public decimal neto_gs { get; set; }
        public decimal donacion_gs { get; set; }
        public decimal vuelto_gs { get; set; }
        public decimal vuelto_dl { get; set; }
        public decimal impreso { get; set; }
        public Nullable<System.DateTime> fecha_impresion { get; set; }
        public string hora_impresion { get; set; }
        public string usuario_reimpresion { get; set; }
        public Nullable<System.DateTime> fecha_reimpresion { get; set; }
        public string hora_reimpresion { get; set; }
        public decimal anulado { get; set; }
        public string usuario_anula { get; set; }
        public Nullable<System.DateTime> fecha_anula { get; set; }
        public string hora_anula { get; set; }
        public string motivo_anula { get; set; }
        public string autoriza_tipo_venta { get; set; }
        public decimal nro_mvto_relacion { get; set; }
        public string observacion_factura { get; set; }
        public Nullable<System.DateTime> fecha_ini_timbrado { get; set; }
        public Nullable<decimal> nro_entrada { get; set; }
        public Nullable<decimal> cod_vendedor { get; set; }
        public Nullable<decimal> nro_anticipo { get; set; }
    
        public virtual cajas_habilitaciones cajas_habilitaciones { get; set; }
        public virtual personas personas { get; set; }
        public virtual tipos_documentos_series tipos_documentos_series { get; set; }
        public virtual tipos_mvtos tipos_mvtos { get; set; }
    }
}
