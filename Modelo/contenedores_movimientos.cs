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
    
    public partial class contenedores_movimientos
    {
        public decimal com_cod_empresa { get; set; }
        public decimal com_identificador { get; set; }
        public Nullable<decimal> com_operacion { get; set; }
        public decimal com_item { get; set; }
        public string com_observacion { get; set; }
        public Nullable<double> latitud { get; set; }
        public Nullable<double> longitud { get; set; }
        public Nullable<System.TimeSpan> com_hora { get; set; }
        public Nullable<System.DateTime> com_fecha { get; set; }
        public string com_usuario_app { get; set; }
        public string com_numero_documento { get; set; }
        public Nullable<System.DateTime> com_fecha_desde { get; set; }
        public Nullable<System.DateTime> com_fecha_hasta { get; set; }
        public string com_cliente { get; set; }
        public string com_duplicado { get; set; }
    }
}
