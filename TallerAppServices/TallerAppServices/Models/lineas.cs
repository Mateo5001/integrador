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
    using System.ComponentModel.DataAnnotations;
    public partial class lineas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lineas()
        {
            this.tintas = new HashSet<tintas>();
        }
    
        public int idLinea { get; set; }
        public string nombreLinea { get; set; }
        public string codigoLinea { get; set; }
        public int idUsuarioCreacion { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime fechaCreacion { get; set; }
    
        public virtual usuarios usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tintas> tintas { get; set; }
    }
}
