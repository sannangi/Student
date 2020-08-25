using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIProject.Models
{
    public class StudentRepository : IStudent
    {

        public List<Student> liststudents = new List<Student>();// { get; set; }
        //Create
        public IEnumerable<Student> Create(Student student)
        {
            liststudents = new List<Student>()
           {
               new Student{RollNumber=1,FirstName="Sai",LastName="Annangi"},
               new Student{RollNumber=2,FirstName="Vamsi",LastName="Annangi"},
               new Student{RollNumber=3,FirstName="Kiran",LastName="Annangi"},
           };
            return liststudents;
        }
        //delete
        public IEnumerable<Student> Remove(int id)
        {

            foreach (Student item in liststudents)
            {
                if (item.RollNumber == id)
                {
                    // liststudents.RemoveAt(0);
                    liststudents.Remove(item);
                }
            }
            return liststudents;
        }
        //Read
        public IEnumerable<Student> GetByID(int id)
        {
            int i = 0;
            foreach (Student item in liststudents)
            {
                if (item.RollNumber == id)
                {
                    i = 1;

                }
            }
            if (i == 1)
            {
                return liststudents;
            }
            else
            {
                liststudents = new List<Student>();
                return liststudents;
            }

        }
        //Insert
        public IEnumerable<Student> Insert(Student student)
        {
            liststudents.Add(student);
            return liststudents;
        }
    }
}
