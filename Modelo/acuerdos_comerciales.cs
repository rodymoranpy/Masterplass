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
    
    public partial class acuerdos_comerciales
    {
        public decimal acco_codigo { get; set; }
        public string acco_descripcion { get; set; }
        public Nullable<System.DateTime> acco_fecha { get; set; }
        public Nullable<System.DateTime> acco_vigdes { get; set; }
        public Nullable<System.DateTime> acco_vighas { get; set; }
        public Nullable<decimal> acco_cod_persona { get; set; }
        public Nullable<decimal> acco_tipo_acuerdo { get; set; }
        public Nullable<decimal> acco_tipo_pago { get; set; }
        public Nullable<decimal> acco_periodo_pago { get; set; }
        public string acco_observacion { get; set; }
        public Nullable<decimal> acco_iva_incluido { get; set; }
        public Nullable<decimal> acco_importe { get; set; }
        public Nullable<System.DateTime> acco_fecha_carga { get; set; }
        public string acco_usuario_carga { get; set; }
        public Nullable<decimal> acco_nro_entrada { get; set; }
    }
}
