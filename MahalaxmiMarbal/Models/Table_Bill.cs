//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MahalaxmiMarbal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Bill
    {
        public int Bill_ID { get; set; }
        public Nullable<int> Product_id { get; set; }
        public Nullable<int> Cust_Id { get; set; }
        public string TotalCost { get; set; }
        public string TotalQuantity { get; set; }
        public string Discount { get; set; }
    }
}