using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIProject.Models
{
    public interface IStudent
    {
       

        IEnumerable<Student> Create(Student student);

    }
}
