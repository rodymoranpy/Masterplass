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
    
    public partial class retiros_caja
    {
        public decimal cod_empresa { get; set; }
        public decimal cod_agcia { get; set; }
        public decimal nro_caja { get; set; }
        public decimal nro_retiro { get; set; }
        public decimal tipo_ingreso { get; set; }
        public decimal cod_money { get; set; }
        public decimal monto { get; set; }
        public System.DateTime fecha { get; set; }
        public string hora { get; set; }
        public string usuario { get; set; }
        public Nullable<decimal> retirado { get; set; }
    }
}
