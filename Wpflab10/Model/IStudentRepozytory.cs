using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpflab10.Model
{
    public interface IStudentRepository
    {


        public Student Get(int id);


        public List<Student> GetAll();


        public void AddStudent(Student student);


        public void UpdateStudent(Student student);


        public void RemoveStudent(int id);
        
    }
}
