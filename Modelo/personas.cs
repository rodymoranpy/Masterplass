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
    
    public partial class personas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personas()
        {
            this.cajas_mov_cab = new HashSet<cajas_mov_cab>();
            this.camiones = new HashSet<camiones>();
            this.facturas_cab = new HashSet<facturas_cab>();
        }
    
        public decimal cod_empresa { get; set; }
        public decimal cod_persona { get; set; }
        public string nombre { get; set; }
        public decimal cod_identificador { get; set; }
        public string documento { get; set; }
        public decimal estado { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string fax { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public decimal nro_entrada { get; set; }
        public decimal cliente { get; set; }
        public decimal proveedor { get; set; }
        public string nro_timbrado { get; set; }
        public Nullable<System.DateTime> fecha_vto_timbrado { get; set; }
        public string nro_timbrado_nc { get; set; }
        public Nullable<System.DateTime> fecha_vto_timbrado_nc { get; set; }
        public Nullable<decimal> porc_descuento { get; set; }
        public decimal retencion { get; set; }
        public decimal vendedor { get; set; }
        public decimal cobrador { get; set; }
        public Nullable<decimal> cod_zona { get; set; }
        public decimal empleado { get; set; }
        public decimal chofer { get; set; }
        public decimal transportista { get; set; }
        public Nullable<decimal> hechauka { get; set; }
        public string contacto { get; set; }
        public Nullable<decimal> saldo_limite { get; set; }
        public Nullable<decimal> saldo_actual { get; set; }
        public Nullable<decimal> credito { get; set; }
        public Nullable<decimal> saldo_adelanto { get; set; }
        public string cta_contable { get; set; }
        public Nullable<decimal> cliente_fiel { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public Nullable<decimal> dia { get; set; }
        public string observacion { get; set; }
        public Nullable<decimal> diplomatico { get; set; }
        public Nullable<decimal> extranjero { get; set; }
        public string mision_diplomatico { get; set; }
        public string cargo_diplomatico { get; set; }
        public string carnet_diplomatico { get; set; }
        public Nullable<decimal> dias_vencimiento { get; set; }
        public Nullable<decimal> cod_entidad_bancaria { get; set; }
        public string nro_cuenta_bancaria { get; set; }
        public string titular_cuenta_bancaria { get; set; }
        public Nullable<decimal> cod_persona_anterior { get; set; }
        public Nullable<decimal> cod_sucursal_banco { get; set; }
        public Nullable<decimal> tipo_pago { get; set; }
        public Nullable<decimal> cod_politica_venta { get; set; }
        public string nombre_autorizado_1 { get; set; }
        public string documento_autorizado_1 { get; set; }
        public string nombre_autorizado_2 { get; set; }
        public string documento_autorizado_2 { get; set; }
        public Nullable<System.DateTime> vencimiento_credito { get; set; }
        public string usuario_app { get; set; }
        public string documento_alternativo { get; set; }
        public Nullable<decimal> cobrador_asignado { get; set; }
        public Nullable<decimal> saldo_limite_me { get; set; }
        public Nullable<decimal> saldo_actual_me { get; set; }
        public string cobrador_migra { get; set; }
        public decimal aseguradora { get; set; }
        public decimal asesor { get; set; }
        public decimal tecnico { get; set; }
        public Nullable<decimal> cod_sucursal { get; set; }
        public Nullable<decimal> cod_departamento { get; set; }
        public Nullable<decimal> cod_cliente_anterior { get; set; }
        public string email_cobros { get; set; }
        public Nullable<decimal> despachante { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cajas_mov_cab> cajas_mov_cab { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<camiones> camiones { get; set; }
        public virtual empresas empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<facturas_cab> facturas_cab { get; set; }
        public virtual tipos_identificadores tipos_identificadores { get; set; }
    }
}
