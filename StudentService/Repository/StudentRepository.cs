using StudentService.IRepository;
using StudentService.Models;

namespace StudentService.Repository
{
    public class StudentRepository:IStudentRepository
    {
            List<Student> students;
        public StudentRepository()
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Ahmed Ali",
                Age = 22
            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Fatma Mostafa",
                Age = 20
            };

            this.students = new List<Student> { student1,student2 };
        }
        public Student Get(int id)
        {
            var student = students.Where(a => a.Id == id).FirstOrDefault();
            return student;
        }

        public List<Student> GetAll()
        {
            return students;
        }
        public List<Student> Add(Student student)
        {
            students.Add(student);
            return students;
        }
    }
}
