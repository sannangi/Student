using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentRepository studentRepository;
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            StudentRepository studentRepository = new StudentRepository();
            return studentRepository.Create(new Student());
          
        }
        [HttpPost]
        public IEnumerable<Student> Post()
        {

           // StudentRepository studentRepository = new StudentRepository();
            
            return studentRepository.Remove(1);
        }
        [HttpGet("{id}")]
        public IEnumerable<Student> Get(int id)
        {
            StudentRepository studentRepository = new StudentRepository();

            return studentRepository.GetByID(id);
        }

        [HttpPut]
        public IEnumerable<Student> Put()
        {
            StudentRepository studentRepository = new StudentRepository();
            Student student = new Student();
            student.RollNumber = 4;
            student.FirstName = "Hello";
            student.LastName = "Annangi";
            return studentRepository.Insert(student);
        }
    }
}
