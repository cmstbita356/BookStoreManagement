//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_BookstoreManagement.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class DamagedBook
    {
        public string BookId { get; set; }
        public Nullable<int> DamagedQuantity { get; set; }
        public Nullable<int> DamagedTotal { get; set; }
        public Nullable<int> Liquidated { get; set; }
        public bool Status { get; set; }
    }
}