using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolModel
{
    public class Teachers
    {
        [Key]
        public int teacherid { get; set; }
        public string FullName { get; set; }

      
    }
}
