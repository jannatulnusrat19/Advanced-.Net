//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab3.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Account
    {
        internal int id;
        [Required]
        [MaxLength(50, ErrorMessage = "Name must be Less than (Char)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please provide Date of Birth")]
        public System.DateTime Date_of_Birth { get; set; }
        [Required(ErrorMessage = "Please provide address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please provide mobile_number")]
        public string Mobile_Number { get; set; }

        [Required(ErrorMessage = "Please provide ID")]
        public int ID { get; set; }
    }
}
