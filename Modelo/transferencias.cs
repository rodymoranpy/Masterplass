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
    
    public partial class transferencias
    {
        public decimal cod_empresa { get; set; }
        public decimal nro_transferencia { get; set; }
        public decimal tipo_transferencia { get; set; }
        public decimal ejercicio { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal t_cambio { get; set; }
        public string cta_egreso { get; set; }
        public decimal cod_money_egreso { get; set; }
        public decimal importe_egreso { get; set; }
        public string cta_ingreso { get; set; }
        public decimal cod_money_ingreso { get; set; }
        public decimal importe_ingreso { get; set; }
        public string concepto { get; set; }
        public System.DateTime fecha_carga { get; set; }
        public string hora_carga { get; set; }
        public string usuario_carga { get; set; }
        public decimal nro_entrada_fact { get; set; }
        public decimal nro_orden_pago { get; set; }
        public Nullable<System.DateTime> fecha_anula { get; set; }
        public string hora_anula { get; set; }
        public string usuario_anula { get; set; }
        public decimal nro_asto { get; set; }
        public decimal nro_asto_anula { get; set; }
    }
}
