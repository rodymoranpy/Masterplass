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
    
    public partial class revaluo_movimientos
    {
        public decimal cod_empresa { get; set; }
        public decimal cod_inventario { get; set; }
        public decimal item { get; set; }
        public System.DateTime fecha_cierre { get; set; }
        public decimal ano_vida_restante { get; set; }
        public decimal coeficiente_ant { get; set; }
        public decimal coeficiente_cierre { get; set; }
        public decimal valor_fiscal_neto_ant { get; set; }
        public decimal valor_revaluado_ant { get; set; }
        public decimal valor_depreciado_ant { get; set; }
        public decimal valor_revaluoado_ejercicio { get; set; }
        public decimal valor_depreciado_ejercicio { get; set; }
        public decimal valor_residual_revaluado { get; set; }
        public decimal depreciacion_ejercicio { get; set; }
        public decimal valor_fiscal_neto { get; set; }
    
        public virtual revaluo_detalle revaluo_detalle { get; set; }
    }
}
