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
    
    public partial class cda_cabeza
    {
        public decimal cod_empresa { get; set; }
        public decimal ejercicio { get; set; }
        public string cta_contable { get; set; }
        public decimal numero { get; set; }
        public Nullable<decimal> numero_ant { get; set; }
        public decimal cod_money { get; set; }
        public decimal t_cambio { get; set; }
        public decimal importe { get; set; }
        public decimal importe_me { get; set; }
        public System.DateTime fecha_emision { get; set; }
        public System.DateTime fecha_vencimiento { get; set; }
        public decimal plazo { get; set; }
        public decimal tasa_interes { get; set; }
        public decimal interes { get; set; }
        public decimal interes_me { get; set; }
        public decimal tipo_distribucion { get; set; }
        public System.DateTime fecha_carga { get; set; }
        public string hora_carga { get; set; }
        public string usuario_carga { get; set; }
        public Nullable<decimal> t_cambio_finiquito { get; set; }
        public Nullable<System.DateTime> fecha_finiquito { get; set; }
        public string hora_finiquito { get; set; }
        public string usuario_finiquito { get; set; }
    
        public virtual cda_detalle cda_detalle { get; set; }
    }
}
