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
    
    public partial class articulos_historico_costos
    {
        public decimal cod_empresa { get; set; }
        public decimal cod_articulo { get; set; }
        public decimal nro_item { get; set; }
        public decimal costo_nuevo { get; set; }
        public decimal costo_anterior { get; set; }
        public decimal precio_compra_nuevo { get; set; }
        public decimal precio_compra_anterior { get; set; }
        public decimal nro_movimiento_stock { get; set; }
        public System.DateTime fecha_movimiento { get; set; }
        public string hora_movimiento { get; set; }
        public string usuario_movimiento { get; set; }
    }
}
