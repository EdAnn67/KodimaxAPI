//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KodimaxAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Golosina
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public double Precio { get; set; }
    
        public virtual Tipo Tipo1 { get; set; }
    }
}
