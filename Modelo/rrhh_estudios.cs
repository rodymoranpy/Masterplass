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
    
    public partial class rrhh_estudios
    {
        public decimal est_cod_empresa { get; set; }
        public decimal est_cod_empleado { get; set; }
        public decimal est_item { get; set; }
        public decimal est_tipo_estudio { get; set; }
        public string est_instituto { get; set; }
        public decimal est_ano_inicio { get; set; }
        public Nullable<decimal> est_ano_fin { get; set; }
        public string est_titulo { get; set; }
        public string est_observaciones { get; set; }
        public decimal est_nro_entrada { get; set; }
        public string est_usuario { get; set; }
    
        public virtual rrhh_empleados rrhh_empleados { get; set; }
        public virtual rrhh_tipos_estudios rrhh_tipos_estudios { get; set; }
    }
}
