using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Practices
{
    public class StudentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class StudentRepository
    {
        private List<StudentClass> students;
        public StudentRepository()
        {
            students = new List<StudentClass>();
        }
        public void AddStudent(StudentClass student)
        {
            students.Add(student);
        }
        public List<StudentClass> GetAllStudents()
        {
            return students;
        }
    }
}
