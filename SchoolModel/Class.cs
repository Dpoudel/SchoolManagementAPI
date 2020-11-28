using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolModel
{
    public class Class
    {
        [Key]
        public int Gradeid { get; set; }
        public int Grade { get; set; }

        

    }
}
