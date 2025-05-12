using Wpflab10.Model;
using Wpflab10.ViewModel;

namespace TestViewModel
{
    public class UnitTest1
    {
        public class FakeStudentRepository : IStudentRepository
        {
            public List<Student>  Students { get; set; } = new List<Student>();
            public void AddStudent(Student student)
            {
                Students.Add(student);
            }

            public Student Get(int id)
            {
                return Students.Single(s=> s.Id == id);
            }

            public List<Student> GetAll()
            {
                return Students;
            }

            public void RemoveStudent(int id)
            {
                throw new NotImplementedException();
            }

            public void UpdateStudent(Student student)
            {
                throw new NotImplementedException();
            }
        }
        [Fact]
        public void Test1()
        {
            var repo = new FakeStudentRepository();
            repo.AddStudent(new Student() { Id = 5, Name = "Kowal" });
            var svm = new StudentViewModel( repo);

            svm.GetAll();

            Assert.NotEmpty(svm.StudentRecord.StudentRecords);
            
            Assert.True(svm.StudentRecord.StudentRecords.Any(s=>s.Id ==5));
        }
    }
}