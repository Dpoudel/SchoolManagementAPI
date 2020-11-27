using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolModel
{
   public class Teachers
    {
        public int id { get; set; }
        public string FullName { get; set; }

        public Subjects subject;

        public Class Grade;
    }
}
