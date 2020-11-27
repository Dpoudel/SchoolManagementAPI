using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolModel
{
   public class Students
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int roll_number { get; set; }

       
        public Class Grade { get; set; }



        public List<Subjects> subject { get; set; }
        //public Teachers teacher { get; set; }

        public ICollection<Teachers> teachers { get; set; }

        
    }
}
