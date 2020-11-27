using Microsoft.EntityFrameworkCore;
using SchoolManagementAPI.DataAccess;
using SchoolManagementAPI.InterfaceDefine;
using SchoolModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementAPI.Interfaceimplement
{
    public class StudentRepo : IStudentInterface
    {
        private readonly StudentContext _studentContext;
        public StudentRepo(StudentContext studentcontext)
        {
            _studentContext = studentcontext;
        }
        public async Task<Students> AddStudent(Students student)
        {
           var addstudent= await _studentContext.Students.AddAsync(student);
            await _studentContext.SaveChangesAsync();
            return addstudent.Entity;
        }

        public async Task<Students> GetStudentById(int Student_Id)
        {
            return await _studentContext.Students.FirstOrDefaultAsync(s => s.Id == Student_Id);
        }

        public async Task<IEnumerable<Students>> GetStudents()
        {
            return await _studentContext.Students.ToListAsync();
        }

        public async Task<Students> UpdateStudent(Students student)
        {
            var result = await _studentContext.Students.FirstOrDefaultAsync(s => s.Id == student.Id);

            if(result!=null)
            {
                result.FirstName = student.FirstName;
                result.LastName = student.LastName;
                result.roll_number = student.roll_number;
                //result.subject = student.subject;
                //result.teacher = student.teacher;
                result.Grade = student.Grade;

                await _studentContext.SaveChangesAsync();

                return result;
            }
            return null;
            
        }
    }
}
