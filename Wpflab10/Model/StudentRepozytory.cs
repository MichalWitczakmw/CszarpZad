using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpflab10.Model
{
    public class StudentRepository:IStudentRepository
    {
        private DbUniversity db = null;

        public StudentRepository()
        {
            db = new DbUniversity();
        }

        public Student Get(int id)
        {
            return db.Students.Find(id);
        }

        public List<Student> GetAll()
        {
            return db.Students.ToList();
        }

        public void AddStudent(Student student)
        {
            if (student != null)
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public void UpdateStudent(Student student)
        {
            var studentFind = this.Get(student.Id);
            if (studentFind != null)
            {
                studentFind.Name = student.Name;
                studentFind.Contact = student.Contact;
                studentFind.Age = student.Age;
                studentFind.Address = student.Address;
                db.SaveChanges();
            }
        }

        public void RemoveStudent(int id)
        {
            var studObj = db.Students.Find(id);
            if (studObj != null)
            {
                db.Students.Remove(studObj);
                db.SaveChanges();
            }
        }
    }
}
