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
    
    public partial class parte_caja
    {
        public decimal cod_empresa { get; set; }
        public decimal ejercicio { get; set; }
        public string cta_contable { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal nro_movimiento { get; set; }
        public decimal operacion { get; set; }
        public decimal ejercicio_cta_afecta { get; set; }
        public string cta_afecta { get; set; }
        public string concepto { get; set; }
        public decimal importe { get; set; }
        public decimal importe_me { get; set; }
    
        public virtual bancos bancos { get; set; }
    }
}
