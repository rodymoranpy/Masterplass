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
    
    public partial class tall_versiones_vehiculos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tall_versiones_vehiculos()
        {
            this.tall_vehiculos = new HashSet<tall_vehiculos>();
        }
    
        public decimal ver_cod_marca { get; set; }
        public decimal ver_cod_modelo { get; set; }
        public decimal ver_cod_version { get; set; }
        public string ver_descripcion { get; set; }
        public string ver_codigo_fabricante { get; set; }
        public Nullable<decimal> ver_cod_pais_origen { get; set; }
        public string ver_comentarios { get; set; }
        public decimal ver_estado { get; set; }
        public decimal ver_nro_entrada { get; set; }
    
        public virtual sist_paises sist_paises { get; set; }
        public virtual tall_modelos_vehiculos tall_modelos_vehiculos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tall_vehiculos> tall_vehiculos { get; set; }
    }
}
