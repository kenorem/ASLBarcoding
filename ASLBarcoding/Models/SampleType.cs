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
    
    public partial class SampleType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SampleType()
        {
            this.Request = new HashSet<Request>();
            this.RequestStage = new HashSet<RequestStage>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> TestType_Id { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public byte[] Timestamp { get; set; }
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
        public virtual TestType TestType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestStage> RequestStage { get; set; }
    }
}
