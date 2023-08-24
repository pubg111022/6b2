using pdf6b2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdf6b2.Interfaces
{
    interface IStudent
    {
        List<Student> GetStudents();
        Student FindById();
        Boolean InsertStudent(Student s);
        Boolean UpdateStudent(Student s , int id);
        Boolean DeleteStudent(int id);
    }
}
