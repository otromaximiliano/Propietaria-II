//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recomendacione
    {
        public int Id { get; set; }
        public string Nombre_Empleado_Recomienda { get; set; }
        public Nullable<int> AplicanteId { get; set; }
    
        public virtual Aplicante Aplicante { get; set; }
    }
}
