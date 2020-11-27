using SchoolModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementAPI.InterfaceDefine
{
   public interface IStudentInterface
    {
        Task<IEnumerable<Students>>GetStudents();

        Task<Students> GetStudentById(int Student_Id);

        Task<Students> AddStudent(Students student);

        Task<Students> UpdateStudent(Students student);

    }
}
