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
    
    public partial class retenciones
    {
        public decimal cod_empresa { get; set; }
        public decimal nro_orden { get; set; }
        public decimal operacion { get; set; }
        public decimal nro_entrada_fact { get; set; }
        public decimal nro_retencion { get; set; }
        public decimal importe { get; set; }
        public decimal importe_gs { get; set; }
        public decimal porcentaje_retencion { get; set; }
        public decimal monto_minimo_retencion { get; set; }
        public Nullable<System.DateTime> fecha_impresion { get; set; }
        public string hora_impresion { get; set; }
        public string usuario_impresion { get; set; }
        public Nullable<System.DateTime> fecha_anulacion { get; set; }
        public string hora_anulacion { get; set; }
        public string usuario_anulacion { get; set; }
        public Nullable<decimal> timbrado { get; set; }
        public Nullable<System.DateTime> fecha_exporta { get; set; }
        public string hora_exporta { get; set; }
        public string usuario_exporta { get; set; }
    }
}
