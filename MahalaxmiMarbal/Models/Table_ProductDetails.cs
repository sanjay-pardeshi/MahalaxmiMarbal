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
    
    public partial class Table_ProductDetails
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> VendorId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Amount { get; set; }
        public string SellingAmount { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public string Quantity { get; set; }
    
        public virtual Table_Product Table_Product { get; set; }
        public virtual Table_Vendor_Registration Table_Vendor_Registration { get; set; }
    }
}
