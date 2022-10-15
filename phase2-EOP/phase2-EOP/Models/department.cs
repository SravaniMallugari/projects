using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace phase2_EOP.Models
{
    public class department
    {
        [Required()]
        public int deptcode { get; set; }
        [MaxLength(30, ErrorMessage = "Cannot  be more than thirty words")]
        public string deptname { get; set; }
    }
}