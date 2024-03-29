//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthenticateIMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock_Withdraw
    {
        public int id { get; set; }
        public string withdraw_ID { get; set; }
        public string stock_code { get; set; }
        public int quantity { get; set; }
        public string unit_of_withdraw { get; set; }
        public string withdrawer { get; set; }
        public System.DateTime date_of_withdraw { get; set; }
        public string compartment_ID { get; set; }
        public string stock_type { get; set; }
        public Nullable<System.DateTime> expiry_date { get; set; }
        public string category_ID { get; set; }
        public string comment { get; set; }
    
        public virtual Employee_Details Employee_Details { get; set; }
        public virtual Shelf_Compartment Shelf_Compartment { get; set; }
        public virtual Stock_Category Stock_Category { get; set; }
        public virtual Stock_Details Stock_Details { get; set; }
        public virtual Stock_Type Stock_Type1 { get; set; }
    }
}
