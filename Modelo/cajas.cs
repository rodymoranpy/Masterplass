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
    
    public partial class cajas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cajas()
        {
            this.cajas_habilitaciones = new HashSet<cajas_habilitaciones>();
            this.cajas_tipos_documentos = new HashSet<cajas_tipos_documentos>();
            this.cajas_tipos_ingresos = new HashSet<cajas_tipos_ingresos>();
        }
    
        public decimal cod_empresa { get; set; }
        public decimal cod_agcia { get; set; }
        public decimal nro_caja { get; set; }
        public string descripcion { get; set; }
        public string nombre_maquina { get; set; }
        public string direccion_ip { get; set; }
        public decimal nro_sucursal { get; set; }
        public decimal nro_boca { get; set; }
        public decimal nro_timbrado { get; set; }
        public System.DateTime fecha_vto_timbrado { get; set; }
        public string estado { get; set; }
        public string usuario { get; set; }
        public decimal nro_entrada { get; set; }
        public Nullable<decimal> patio { get; set; }
        public Nullable<System.DateTime> fecha_ini_timbrado { get; set; }
        public string usuario_encargado { get; set; }
    
        public virtual agencias agencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cajas_habilitaciones> cajas_habilitaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cajas_tipos_documentos> cajas_tipos_documentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cajas_tipos_ingresos> cajas_tipos_ingresos { get; set; }
    }
}
