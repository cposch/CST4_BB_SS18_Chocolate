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
    
    public partial class DEMO_PRODUCT_INFO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEMO_PRODUCT_INFO()
        {
            this.DEMO_ORDER_ITEMS = new HashSet<DEMO_ORDER_ITEMS>();
            this.PACKAGE = new HashSet<PACKAGE>();
            this.RECIEPE = new HashSet<RECIEPE>();
            this.RULE = new HashSet<RULE>();
            this.SHAPE = new HashSet<SHAPE>();
        }
    
        public decimal PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string PRODUCT_DESCRIPTION { get; set; }
        public string CATEGORY { get; set; }
        public string PRODUCT_AVAIL { get; set; }
        public Nullable<decimal> LIST_PRICE { get; set; }
        public byte[] PRODUCT_IMAGE { get; set; }
        public string MIMETYPE { get; set; }
        public string FILENAME { get; set; }
        public Nullable<System.DateTime> IMAGE_LAST_UPDATE { get; set; }
        public string TAGS { get; set; }
        public Nullable<decimal> SALE_PRICE { get; set; }
        public Nullable<System.DateTime> SALE_BEGIN { get; set; }
        public Nullable<System.DateTime> SALE_END { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEMO_ORDER_ITEMS> DEMO_ORDER_ITEMS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PACKAGE> PACKAGE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECIEPE> RECIEPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RULE> RULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHAPE> SHAPE { get; set; }
    }
}
