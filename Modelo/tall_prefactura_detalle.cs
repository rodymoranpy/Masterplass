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
    
    public partial class tall_prefactura_detalle
    {
        public decimal pfd_numero { get; set; }
        public decimal pfd_item { get; set; }
        public decimal pfd_origen { get; set; }
        public decimal pfd_item_orden { get; set; }
        public decimal pfd_movimiento { get; set; }
        public decimal pfd_cod_producto { get; set; }
        public Nullable<decimal> pfd_cod_tecnico { get; set; }
        public string pfd_concepto { get; set; }
        public decimal pfd_cantidad { get; set; }
        public decimal pfd_costo { get; set; }
        public decimal pfd_precio { get; set; }
        public decimal pfd_pct_descuento { get; set; }
        public decimal pfd_descuento { get; set; }
        public decimal pfd_precio_neto { get; set; }
        public decimal pfd_pct_iva { get; set; }
        public decimal pfd_gravadas { get; set; }
        public decimal pfd_exentas { get; set; }
        public decimal pfd_iva { get; set; }
        public string pfd_detalle_tarea { get; set; }
        public decimal pfd_tipo_pago { get; set; }
        public Nullable<decimal> pfd_clave_facturacion { get; set; }
        public decimal pfd_nro_reclamo_fab { get; set; }
        public Nullable<System.DateTime> pfd_fecha_reclamo_fab { get; set; }
        public Nullable<System.TimeSpan> pfd_hora_reclamo_fab { get; set; }
        public string pfd_usuario_reclamo_fab { get; set; }
        public string pfd_comentario_reclamo_fab { get; set; }
        public Nullable<System.DateTime> pfd_fecha_confirmacion_fab { get; set; }
        public Nullable<System.TimeSpan> pfd_hora_confirmacion_fab { get; set; }
        public string pfd_usuario_confirmacion_fab { get; set; }
        public string pfd_comentario_confirmacion_fab { get; set; }
        public Nullable<decimal> pfd_clave_facturacion_fab { get; set; }
        public Nullable<decimal> pfd_precio_total { get; set; }
        public decimal pfd_estado_reclamo { get; set; }
        public Nullable<System.DateTime> pfd_fecha_real_reclamo { get; set; }
        public Nullable<System.DateTime> pfd_fecha_real_respuesta { get; set; }
        public Nullable<decimal> pfd_clave_presupuesto { get; set; }
    
        public virtual tall_prefactura tall_prefactura { get; set; }
    }
}
