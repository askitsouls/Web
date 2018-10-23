using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Father Name")]
        public string FatherName { get; set; }
        public string Class { get; set; }
       
    }
}