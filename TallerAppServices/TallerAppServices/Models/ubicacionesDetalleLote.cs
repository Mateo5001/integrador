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
    
    public partial class ubicacionesDetalleLote
    {
        public int idLote { get; set; }
        public Nullable<int> idTinta { get; set; }
        public Nullable<int> idColor { get; set; }
        public double cantidad { get; set; }
        public int idUbicacionDetalle { get; set; }
        public string codigoLote { get; set; }
        public int idUsuarioCreacion { get; set; }
    
        public virtual colores colores { get; set; }
        public virtual tintas tintas { get; set; }
        public virtual ubicacionesDetalle ubicacionesDetalle { get; set; }
        public virtual usuarios usuarios { get; set; }
    }
}
