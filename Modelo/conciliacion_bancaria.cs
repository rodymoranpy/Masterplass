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
    
    public partial class conciliacion_bancaria
    {
        public decimal cod_empresa { get; set; }
        public decimal nro_movimiento { get; set; }
        public decimal ejercicio { get; set; }
        public string cta_contable { get; set; }
        public decimal cod_money { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal tipo_operacion { get; set; }
        public string nro_comprobante { get; set; }
        public decimal debito { get; set; }
        public decimal credito { get; set; }
        public string concepto { get; set; }
        public System.DateTime fecha_carga { get; set; }
        public string hora_carga { get; set; }
        public string usuario_carga { get; set; }
        public decimal conciliado { get; set; }
        public Nullable<System.DateTime> fecha_concilia { get; set; }
        public string hora_concilia { get; set; }
        public string usuario_concilia { get; set; }
        public decimal nro_conciliacion { get; set; }
    
        public virtual bancos bancos { get; set; }
    }
}
