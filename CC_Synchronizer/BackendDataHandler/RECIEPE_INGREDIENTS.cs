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
    
    public partial class RECIEPE_INGREDIENTS
    {
        public decimal ID { get; set; }
        public decimal RECIEPE_ID { get; set; }
        public int QUANTITY { get; set; }
        public decimal UNIT_PRICE { get; set; }
        public decimal INGREDIENT_ID { get; set; }
        public Nullable<decimal> FRONTEND_ID { get; set; }
        public Nullable<decimal> MANUFACTURER_ID { get; set; }
    
        public virtual INGREDIENT INGREDIENT { get; set; }
        public virtual RECIEPE RECIEPE { get; set; }
    }
}
