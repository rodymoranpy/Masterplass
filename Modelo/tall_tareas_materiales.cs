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
    
    public partial class tall_tareas_materiales
    {
        public decimal tam_codigo { get; set; }
        public decimal tam_item { get; set; }
        public decimal tam_cod_producto { get; set; }
        public decimal tam_cantidad { get; set; }
        public decimal tam_nro_entrada { get; set; }
    
        public virtual tall_tareas_tiempos tall_tareas_tiempos { get; set; }
    }
}
