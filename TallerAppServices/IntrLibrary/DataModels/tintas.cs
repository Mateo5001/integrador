//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntrLibrary.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class tintas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tintas()
        {
            this.ubicacionesDetalleLote = new HashSet<ubicacionesDetalleLote>();
        }
    
        public int idTinta { get; set; }
        public string nombreTinta { get; set; }
        public string codigoTinta { get; set; }
        public int idLinea { get; set; }
        public int idUsuarioCreacion { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public bool inactivo { get; set; }
    
        public virtual lineas lineas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ubicacionesDetalleLote> ubicacionesDetalleLote { get; set; }
    }
}