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
    
    public partial class corte_inventario_det
    {
        public decimal cod_empresa { get; set; }
        public decimal nro_inventario { get; set; }
        public decimal cod_deposito { get; set; }
        public decimal cod_area { get; set; }
        public decimal cod_articulo { get; set; }
        public decimal cant_sistema { get; set; }
        public decimal cant_real { get; set; }
        public Nullable<System.DateTime> fecha_mod { get; set; }
        public string hora_mod { get; set; }
        public string usuario_mod { get; set; }
        public decimal nro_ajuste { get; set; }
        public Nullable<System.DateTime> fecha_ajuste { get; set; }
        public string hora_ajuste { get; set; }
        public string usuario_ajuste { get; set; }
    
        public virtual articulos articulos { get; set; }
        public virtual corte_inventario_cab corte_inventario_cab { get; set; }
        public virtual depositos_areas depositos_areas { get; set; }
    }
}
