using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_2.Models
{
    public class Student
    {
        [Required, RegularExpression(@"/^([a-zA-Z\\s]+)$/g", ErrorMessage= "Name contains invalid character")]
       // [ExcludeChar("/.,@#$%^*",ErrorMessage="Name contains invalid character")]
        public string Name { get; set; }

        [Required, RegularExpression(@"/^([0-9]{2}-[0-9]{5}-[1-3]{1})+$", ErrorMessage ="ID must be in XX-XXX-X FORMAT")]
        public string ID { get; set; }

        [Required ]
        public DateTime Date { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]

        public string DOB { get; set; }
        [Required]

        public string Gender { get; set; }
        [Required]

        public string Dept { get; set; }

    }
}