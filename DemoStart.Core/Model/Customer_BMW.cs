//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoStart.Core.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer_BMW
    {
        public int ID { get; set; }
        public string Cust_Name { get; set; }
        public string Cust_Email { get; set; }
        public Nullable<int> Car_ID { get; set; }
        public Nullable<int> AGE { get; set; }
    
        public virtual Cars_BMW Cars_BMW { get; set; }
    }
}
