//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TableInheritance.Server.Domain.Edmx
{
    using System;
    using System.Collections.Generic;
    
    public abstract partial class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<long> HomeAddressId { get; set; }
    
        public virtual Address Address1 { get; set; }
    }
}
