//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularDemoWebApp.DAL.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string Gender { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    }
}
