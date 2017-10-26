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
    
    public partial class Analysis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Analysis()
        {
            this.Result = new HashSet<Result>();
        }
    
        public int Id { get; set; }
        public string Item { get; set; }
        public Nullable<int> SampleId { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> DateDone { get; set; }
    
        public virtual Sample Sample { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Result { get; set; }
    }
}