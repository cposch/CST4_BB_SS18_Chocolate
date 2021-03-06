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
    
    public partial class DEMO_ORDERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEMO_ORDERS()
        {
            this.DEMO_ORDER_ITEMS = new HashSet<DEMO_ORDER_ITEMS>();
        }
    
        public decimal ORDER_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public Nullable<decimal> ORDER_TOTAL { get; set; }
        public Nullable<System.DateTime> ORDER_TIMESTAMP { get; set; }
        public string USER_NAME { get; set; }
        public string TAGS { get; set; }
        public string STATUS { get; set; }
        public Nullable<decimal> FRONTEND_ID { get; set; }
        public Nullable<decimal> MANUFACTURER_ID { get; set; }
        public Nullable<System.DateTime> DELIVERY_DATE { get; set; }
        public string LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_MODIFIED_DATE { get; set; }
    
        public virtual DEMO_CUSTOMERS DEMO_CUSTOMERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEMO_ORDER_ITEMS> DEMO_ORDER_ITEMS { get; set; }
    }
}
