//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASLBarcoding.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Test()
        {
            this.TestInRequest = new HashSet<TestInRequest>();
            this.TestCheck = new HashSet<TestCheck>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> TestTypeId { get; set; }
        public string UserId { get; set; }
        public Nullable<decimal> Cost { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual TestType TestType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestInRequest> TestInRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestCheck> TestCheck { get; set; }
    }
}
