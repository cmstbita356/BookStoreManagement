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
    
    public partial class ImportDetail
    {
        public string ImportId { get; set; }
        public string BookId { get; set; }
        public Nullable<int> BookQuantity { get; set; }
        public Nullable<int> UnitCost { get; set; }
        public bool Status { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Import Import { get; set; }
    }
}
