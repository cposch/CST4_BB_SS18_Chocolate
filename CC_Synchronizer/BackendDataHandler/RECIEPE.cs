//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackendDataHandler
{
    using System;
    using System.Collections.Generic;
    
    public partial class RECIEPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RECIEPE()
        {
            this.RECIEPE_INGREDIENTS = new HashSet<RECIEPE_INGREDIENTS>();
        }
    
        public decimal ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<decimal> FRONTEND_ID { get; set; }
        public Nullable<decimal> MANUFACTURER_ID { get; set; }
        public string LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_MODIFIED_DATE { get; set; }
    
        public virtual DEMO_PRODUCT_INFO DEMO_PRODUCT_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECIEPE_INGREDIENTS> RECIEPE_INGREDIENTS { get; set; }
    }
}
