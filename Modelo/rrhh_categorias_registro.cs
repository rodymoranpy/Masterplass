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
    
    public partial class rrhh_categorias_registro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rrhh_categorias_registro()
        {
            this.rrhh_empleados = new HashSet<rrhh_empleados>();
        }
    
        public decimal cat_cod_empresa { get; set; }
        public decimal cat_codigo { get; set; }
        public string cat_descripcion { get; set; }
        public decimal cat_nro_entrada { get; set; }
        public string cat_usuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_empleados> rrhh_empleados { get; set; }
    }
}
