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
    
    public partial class tall_ordenes_terceros
    {
        public decimal ote_nro_orden { get; set; }
        public decimal ote_item { get; set; }
        public decimal ote_cod_parte { get; set; }
        public string ote_observaciones { get; set; }
        public decimal ote_tipo_pago { get; set; }
        public Nullable<decimal> ote_cod_proveedor { get; set; }
        public string ote_nro_presupuesto_proveedor { get; set; }
        public decimal ote_importe_proveedor { get; set; }
        public decimal ote_importe_proveedor_loc { get; set; }
        public decimal ote_importe_cliente { get; set; }
        public decimal ote_importe_cliente_loc { get; set; }
        public Nullable<System.DateTime> ote_fecha_recibe { get; set; }
        public Nullable<System.TimeSpan> ote_hora_recibe { get; set; }
        public string ote_usuario_recibe { get; set; }
        public Nullable<decimal> ote_clave_presupuesto { get; set; }
        public Nullable<decimal> ote_clave_factura_proveedor { get; set; }
        public decimal ote_nro_entrada { get; set; }
        public Nullable<decimal> ote_cod_empleado_solicita { get; set; }
        public Nullable<decimal> ote_cod_empleado_recibe { get; set; }
        public Nullable<decimal> ote_imponible { get; set; }
        public Nullable<decimal> ote_iva { get; set; }
        public Nullable<decimal> ote_exenta { get; set; }
        public Nullable<decimal> ote_pct_iva { get; set; }
        public Nullable<decimal> ote_nro_factura { get; set; }
        public Nullable<System.DateTime> ote_fecha_factura { get; set; }
        public Nullable<decimal> ote_pct_utilidad { get; set; }
        public Nullable<decimal> ote_total { get; set; }
        public Nullable<decimal> ote_cod_moneda { get; set; }
        public Nullable<decimal> ote_nro_orden_compra { get; set; }
        public Nullable<System.DateTime> ote_fecha_orden_compra { get; set; }
        public Nullable<System.TimeSpan> ote_hora_orden_compra { get; set; }
        public string ote_usuario_orden_compra { get; set; }
        public Nullable<decimal> ote_clave_prefactura { get; set; }
        public Nullable<decimal> ote_clave_factura { get; set; }
        public decimal ote_fondo_fijo { get; set; }
        public Nullable<decimal> ote_nro_caja { get; set; }
        public Nullable<decimal> ote_nro_habilitacion { get; set; }
        public Nullable<decimal> ote_tipo_documento { get; set; }
        public string ote_usuario_modifica { get; set; }
        public Nullable<System.DateTime> ote_fecha_modifica { get; set; }
        public Nullable<System.TimeSpan> ote_hora_modifica { get; set; }
    
        public virtual tall_ordenes tall_ordenes { get; set; }
    }
}
