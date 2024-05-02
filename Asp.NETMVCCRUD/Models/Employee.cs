

namespace Asp.NETMVCCRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public string Position { get; set; }
        
        public Nullable<int> Age { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string EmailID { get; set; }
        public Nullable<int> PhoneNo { get; set; }
    }
}
