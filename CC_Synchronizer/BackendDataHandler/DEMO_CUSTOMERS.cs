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
    
    public partial class DEMO_CUSTOMERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEMO_CUSTOMERS()
        {
            this.DEMO_ORDERS = new HashSet<DEMO_ORDERS>();
        }
    
        public decimal CUSTOMER_ID { get; set; }
        public string CUST_FIRST_NAME { get; set; }
        public string CUST_LAST_NAME { get; set; }
        public string CUST_STREET_ADDRESS1 { get; set; }
        public string CUST_STREET_ADDRESS2 { get; set; }
        public string CUST_CITY { get; set; }
        public string CUST_STATE { get; set; }
        public string CUST_POSTAL_CODE { get; set; }
        public string CUST_EMAIL { get; set; }
        public string PHONE_NUMBER1 { get; set; }
        public string PHONE_NUMBER2 { get; set; }
        public string URL { get; set; }
        public Nullable<decimal> CREDIT_LIMIT { get; set; }
        public string TAGS { get; set; }
        public Nullable<decimal> MANUFACTURER_ID { get; set; }
        public Nullable<decimal> FRONTEND_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEMO_ORDERS> DEMO_ORDERS { get; set; }
    }
}
