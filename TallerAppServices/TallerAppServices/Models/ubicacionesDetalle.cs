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
    
    public partial class ubicacionesDetalle
    {
        public int idUbicacionDetalle { get; set; }
        public int idubicacion { get; set; }
        public string desDetalle { get; set; }
    
        public virtual ubicaciones ubicaciones { get; set; }
    }
}
