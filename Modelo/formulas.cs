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
    
    public partial class formulas
    {
        public decimal cod_empresa { get; set; }
        public decimal cod_articulo { get; set; }
        public decimal nro_formula { get; set; }
        public string nombre { get; set; }
        public decimal cod_componente { get; set; }
        public decimal cantidad { get; set; }
        public decimal estado { get; set; }
        public decimal nro_entrada { get; set; }
        public string usuario { get; set; }
        public Nullable<decimal> pct_utilidad { get; set; }
    
        public virtual articulos articulos { get; set; }
        public virtual articulos articulos1 { get; set; }
    }
}
