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
    
    public partial class sorteos
    {
        public decimal cod_empresa { get; set; }
        public decimal nro_caja { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public Nullable<decimal> cod_persona { get; set; }
        public string nombre_persona { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public decimal total { get; set; }
        public string barrio { get; set; }
        public string observacion { get; set; }
        public Nullable<decimal> cupones { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
    }
}
