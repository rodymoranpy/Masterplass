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
    
    public partial class rrhh_empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rrhh_empleados()
        {
            this.rrhh_conceptos_fijos = new HashSet<rrhh_conceptos_fijos>();
            this.rrhh_estudios = new HashSet<rrhh_estudios>();
            this.rrhh_familia = new HashSet<rrhh_familia>();
            this.rrhh_marcaciones = new HashSet<rrhh_marcaciones>();
            this.rrhh_referencias = new HashSet<rrhh_referencias>();
            this.rrhh_liquidaciones_cabeza = new HashSet<rrhh_liquidaciones_cabeza>();
            this.rrhh_solicitud_vacaciones = new HashSet<rrhh_solicitud_vacaciones>();
            this.rrhh_solicitudes = new HashSet<rrhh_solicitudes>();
            this.rrhh_trabajos_anteriores = new HashSet<rrhh_trabajos_anteriores>();
            this.rrhh_vacaciones = new HashSet<rrhh_vacaciones>();
        }
    
        public decimal emp_cod_empresa { get; set; }
        public decimal emp_cod_empleado { get; set; }
        public string emp_nombres { get; set; }
        public string emp_apellidos { get; set; }
        public string emp_nombre_completo { get; set; }
        public decimal emp_cod_pais { get; set; }
        public decimal emp_cod_dpto { get; set; }
        public decimal emp_cod_ciudad { get; set; }
        public string emp_barrio { get; set; }
        public string emp_direccion { get; set; }
        public string emp_telefono { get; set; }
        public string emp_celular { get; set; }
        public Nullable<decimal> emp_registro_cond { get; set; }
        public Nullable<decimal> emp_categoria_registro { get; set; }
        public Nullable<decimal> emp_cod_ciudad_registro { get; set; }
        public string emp_email { get; set; }
        public decimal emp_cod_estado_civil { get; set; }
        public decimal emp_cod_sexo { get; set; }
        public string emp_grupo_sanguineo { get; set; }
        public System.DateTime emp_fecha_nacimiento { get; set; }
        public decimal emp_cod_nacionalidad { get; set; }
        public decimal emp_tipo_documento { get; set; }
        public decimal emp_nro_documento { get; set; }
        public decimal emp_iva { get; set; }
        public string emp_ruc { get; set; }
        public decimal emp_cod_profesion { get; set; }
        public decimal emp_cod_nivel_estudio { get; set; }
        public string emp_observacion { get; set; }
        public System.DateTime emp_fecha_ingreso { get; set; }
        public decimal emp_cod_forma_pago { get; set; }
        public decimal emp_tipo_pago { get; set; }
        public string emp_cod_banco { get; set; }
        public string emp_nro_cuenta { get; set; }
        public Nullable<decimal> emp_cod_proveedor { get; set; }
        public decimal emp_categoria { get; set; }
        public decimal emp_cod_situacion { get; set; }
        public decimal emp_centro_costo { get; set; }
        public decimal emp_cod_depart_empresa { get; set; }
        public decimal emp_cod_cargo { get; set; }
        public decimal emp_ips { get; set; }
        public Nullable<System.DateTime> emp_fecha_ingreso_ips { get; set; }
        public Nullable<decimal> emp_nro_seguro_ips { get; set; }
        public decimal emp_cod_categoria_mjt { get; set; }
        public decimal emp_salario { get; set; }
        public decimal emp_salario_hora_normal { get; set; }
        public decimal emp_salario_hora_extra_normal { get; set; }
        public decimal emp_salario_hora_extra_noct { get; set; }
        public decimal emp_salario_hora_extra_feriado { get; set; }
        public Nullable<System.DateTime> emp_fecha_salida { get; set; }
        public Nullable<decimal> emp_cod_motivo_salida { get; set; }
        public Nullable<decimal> emp_control_asistencia { get; set; }
        public decimal emp_configuracion_horario_gen { get; set; }
        public Nullable<System.TimeSpan> emp_hora_entrada { get; set; }
        public Nullable<System.TimeSpan> emp_hora_salida_almuerzo { get; set; }
        public Nullable<System.TimeSpan> emp_hora_entrada_almuerzo { get; set; }
        public Nullable<System.TimeSpan> emp_hora_salida { get; set; }
        public Nullable<System.TimeSpan> emp_hora_entrada_sabado { get; set; }
        public Nullable<System.TimeSpan> emp_hora_salida_sabado { get; set; }
        public decimal emp_nro_entrada { get; set; }
        public string emp_usuario { get; set; }
        public Nullable<decimal> saldo_limite_super { get; set; }
        public Nullable<decimal> saldo_actual_super { get; set; }
        public Nullable<decimal> saldo_limite_patio { get; set; }
        public Nullable<decimal> saldo_actual_patio { get; set; }
        public Nullable<decimal> emp_plus_asignado { get; set; }
        public Nullable<decimal> emp_nro_tarjeta { get; set; }
        public string emp_legajo { get; set; }
        public Nullable<decimal> emp_cod_agcia_contrato { get; set; }
        public Nullable<decimal> emp_cod_agcia_presencia { get; set; }
        public Nullable<decimal> emp_nro_patronal { get; set; }
        public decimal emp_id_reloj { get; set; }
        public Nullable<decimal> emp_cod_reloj { get; set; }
        public Nullable<decimal> emp_cod_ciudad_nacimiento { get; set; }
        public Nullable<System.DateTime> emp_vencimiento_documento { get; set; }
    
        public virtual rrhh_cargos rrhh_cargos { get; set; }
        public virtual rrhh_categorias_mjt rrhh_categorias_mjt { get; set; }
        public virtual rrhh_categorias_registro rrhh_categorias_registro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_conceptos_fijos> rrhh_conceptos_fijos { get; set; }
        public virtual rrhh_departamentos_empresa rrhh_departamentos_empresa { get; set; }
        public virtual rrhh_estados_civiles rrhh_estados_civiles { get; set; }
        public virtual rrhh_formas_pago rrhh_formas_pago { get; set; }
        public virtual rrhh_motivos_salida rrhh_motivos_salida { get; set; }
        public virtual rrhh_paises rrhh_paises { get; set; }
        public virtual rrhh_niveles_estudio rrhh_niveles_estudio { get; set; }
        public virtual rrhh_profesiones rrhh_profesiones { get; set; }
        public virtual rrhh_sexos rrhh_sexos { get; set; }
        public virtual rrhh_situaciones rrhh_situaciones { get; set; }
        public virtual tipos_identificadores tipos_identificadores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_estudios> rrhh_estudios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_familia> rrhh_familia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_marcaciones> rrhh_marcaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_referencias> rrhh_referencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_liquidaciones_cabeza> rrhh_liquidaciones_cabeza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_solicitud_vacaciones> rrhh_solicitud_vacaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_solicitudes> rrhh_solicitudes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_trabajos_anteriores> rrhh_trabajos_anteriores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rrhh_vacaciones> rrhh_vacaciones { get; set; }
    }
}
