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
    
    public partial class articulos_ctas_contables
    {
        public decimal cod_empresa { get; set; }
        public decimal cod_centro { get; set; }
        public decimal cod_articulo { get; set; }
        public string cta_contable_compras { get; set; }
        public string usuario { get; set; }
        public decimal nro_entrada { get; set; }
        public string cta_contable_costos { get; set; }
        public string cta_contable_ventas { get; set; }
        public string cta_contable_descuentos { get; set; }
        public string cta_contable_devoluciones { get; set; }
        public string cta_contable_inventario { get; set; }
    
        public virtual articulos articulos { get; set; }
        public virtual centros_de_costo centros_de_costo { get; set; }
    }
}
