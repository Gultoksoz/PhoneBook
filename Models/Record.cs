using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Phonebook.Models
{
    [Table("Records")]
    public class Record
    {
        [Required(ErrorMessage = "Name is required. It cannot be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lastname is required. It cannot be empty")]
        public string LastName { get; set; }

        [Key]
        public string Phone { get; set; }
    }
}