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

        // public Subjects subject;

        //public int Gradeid { get;set }
        //public ICollection<Class> Grade { get; set; }
        public ICollection<Students> students { get; set; }
    }
}
