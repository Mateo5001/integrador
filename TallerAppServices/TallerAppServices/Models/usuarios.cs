//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TallerAppServices.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios()
        {
            this.colores = new HashSet<colores>();
            this.cuentas = new HashSet<cuentas>();
            this.inventariosMovimientos = new HashSet<inventariosMovimientos>();
            this.lineas = new HashSet<lineas>();
            this.tintas = new HashSet<tintas>();
            this.ubicaciones = new HashSet<ubicaciones>();
            this.ubicacionesDetalleLote = new HashSet<ubicacionesDetalleLote>();
        }
    
        public int idUsuario { get; set; }
        public int idTipoDocumento { get; set; }
        public string identificacion { get; set; }
        public string nombrePrimero { get; set; }
        public string nombreSegundo { get; set; }
        public string apellidoPrimero { get; set; }
        public string apellidoSegundo { get; set; }
        public int idRole { get; set; }
    
        public virtual roles roles { get; set; }
        public virtual tiposDocumentos tiposDocumentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<colores> colores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuentas> cuentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inventariosMovimientos> inventariosMovimientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lineas> lineas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tintas> tintas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ubicaciones> ubicaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ubicacionesDetalleLote> ubicacionesDetalleLote { get; set; }
    }
}
