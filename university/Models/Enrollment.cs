//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace university.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        public int enId { get; set; }
        public int courseId { get; set; }
        public int studentId { get; set; }
        public Nullable<decimal> Grade { get; set; }
    
        public virtual course course { get; set; }
        public virtual student student { get; set; }
    }
}
