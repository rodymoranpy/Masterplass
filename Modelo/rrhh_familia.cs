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
    
    public partial class rrhh_familia
    {
        public decimal fam_cod_empresa { get; set; }
        public decimal fam_cod_empleado { get; set; }
        public decimal fam_item { get; set; }
        public decimal fam_tipo_familia { get; set; }
        public string fam_nombre { get; set; }
        public Nullable<System.DateTime> fam_fecha_nacimiento { get; set; }
        public Nullable<decimal> fam_nacionalidad { get; set; }
        public Nullable<decimal> fam_tipo_documento { get; set; }
        public Nullable<decimal> fam_nro_documento { get; set; }
        public decimal fam_estado { get; set; }
        public string fam_lugar_trabajo { get; set; }
        public string fam_telefono_trabajo { get; set; }
        public decimal fam_emergencia { get; set; }
        public decimal fam_nro_entrada { get; set; }
        public string fam_usuario { get; set; }
    
        public virtual rrhh_empleados rrhh_empleados { get; set; }
        public virtual rrhh_tipo_familia rrhh_tipo_familia { get; set; }
        public virtual tipos_identificadores tipos_identificadores { get; set; }
    }
}
