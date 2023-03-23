using Microsoft.EntityFrameworkCore;
using Students.Data;
using Students.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students
{
    public class StudentRepository : IStudentRepository
    {


        private IApplicationDbContext _dbcontext;
        public StudentRepository(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<int> Create(Student student)
        {
            _dbcontext.Students.Add(student);
            await _dbcontext.SaveChanges();
            return student.Id;
        }

        public async Task<List<Student>> GetAll()
        {
            var students = await _dbcontext.Students.ToListAsync<Student>();
            return students;
        }
        public async Task<Student> GetById(int id)
        {
            var student = await _dbcontext.Students.Where(st => st.Id == id).FirstOrDefaultAsync();
            return student;
        }

        public async Task<string> Update(int id, Student student)
        {
            var studentupt = await _dbcontext.Students.Where(student => student.Id == id).FirstOrDefaultAsync();
            if (studentupt == null) return "Student does not exists";

            studentupt.FirstName = student.FirstName;
            studentupt.LastName = student.LastName;
            studentupt.EmailAddress = student.EmailAddress;
            studentupt.DateOfBirth = student.DateOfBirth;

            await _dbcontext.SaveChanges();
            return "Student details successfully modified";
        }
        public async Task<string> Delete(int id)
        {
            var studentdel = _dbcontext.Students.Where(student => student.Id == id).FirstOrDefault();
            if (studentdel == null) return "Student does not exists";

            _dbcontext.Students.Remove(studentdel);
            await _dbcontext.SaveChanges();
            return "Student details deleted modified";
        }
    }
}

