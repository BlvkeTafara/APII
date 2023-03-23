using Microsoft.AspNetCore.Mvc;
using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Students.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        // GET: api/<StudentsController>
        [HttpGet]
        public async Task<List<Student>> GetAll()
        {
            return await _studentRepository.GetAll();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public async Task<Student> GetById(int id)
        {
            return await _studentRepository.GetById(id);

        }

        // POST api/<StudentsController>
        [HttpPost]
        public async Task<int> Post([FromBody] Student value)
        {
            return await _studentRepository.Create(value);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public async Task<string> Put(int id, [FromBody] Student value)
        {
            return await _studentRepository.Update(id,value);
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await _studentRepository.Delete (id);
        }
    }
}
