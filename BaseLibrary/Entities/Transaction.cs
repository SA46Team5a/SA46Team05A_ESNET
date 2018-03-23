//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA46Team05A_Project.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            this.Availability = new HashSet<Availability>();
        }
    
        public int TransactionID { get; set; }
        public string FacilityID { get; set; }
        public int MemberID { get; set; }
        public System.DateTime TransDate { get; set; }
        public short StartTime { get; set; }
        public short EndTime { get; set; }
        public bool Cancelled { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Availability> Availability { get; set; }
        public virtual Facility Facilities { get; set; }
        public virtual Member Members { get; set; }
    }
}