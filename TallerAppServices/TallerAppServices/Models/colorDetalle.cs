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
    
    public partial class colorDetalle
    {
        public int idColorDetalle { get; set; }
        public int idColor { get; set; }
        public int idTinta { get; set; }
        public double cantidadPorcentaje { get; set; }
    
        public virtual colores colores { get; set; }
        public virtual tintas tintas { get; set; }
    }
}