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
    
    public partial class RULE_CATEGORIES
    {
        public decimal ID { get; set; }
    
        public virtual INGREDIENT_CATEGORY INGREDIENT_CATEGORY { get; set; }
        public virtual RULE RULE { get; set; }
    }
}
