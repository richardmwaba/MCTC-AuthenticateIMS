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
    
    public partial class StockToReorder_Result
    {
        public int id { get; set; }
        public string stock_code { get; set; }
        public string description_of_items { get; set; }
        public int quantity_available { get; set; }
        public string unit_of_issue { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> expiry_date { get; set; }
        public string compartment_ID { get; set; }
        public string shelf { get; set; }
        public string description1 { get; set; }
        public string status { get; set; }
    }
}
