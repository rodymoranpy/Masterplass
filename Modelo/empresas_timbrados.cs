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
    
    public partial class empresas_timbrados
    {
        public decimal cod_empresa { get; set; }
        public decimal tipo_documento { get; set; }
        public decimal cod_establecimiento { get; set; }
        public decimal punto_emision { get; set; }
        public string nro_timbrado { get; set; }
        public Nullable<System.DateTime> vto_timbrado { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<decimal> desde { get; set; }
        public Nullable<decimal> hasta { get; set; }
        public Nullable<decimal> estado { get; set; }
    }
}
