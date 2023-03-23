using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models
{
    public interface IStudentRepository
    {
        Task<int> Create(Student student);
        Task<List<Student>> GetAll();
        Task<Student> GetById(int id);
        Task<string> Update(int id, Student student);
        Task<string> Delete(int id);
    }
}
