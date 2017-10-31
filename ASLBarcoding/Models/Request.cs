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
    
    public partial class Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            this.Sample = new HashSet<Sample>();
            this.TestCheckList = new HashSet<TestCheckList>();
            this.TestInRequest = new HashSet<TestInRequest>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public int ClientId { get; set; }
        public int NoofSamples { get; set; }
        public Nullable<int> SampleTypeId { get; set; }
        public int WorkorderNo { get; set; }
        public decimal Cost { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public int SampleFirstNo { get; set; }
        public int SampleLastNo { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public byte[] Timestamp { get; set; }
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual SampleType SampleType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sample> Sample { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestCheckList> TestCheckList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestInRequest> TestInRequest { get; set; }
    }
}
