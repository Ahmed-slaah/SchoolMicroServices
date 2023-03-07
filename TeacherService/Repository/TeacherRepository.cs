using TeacherService.IRepository;
using TeacherService.Models;

namespace TeacherService.Repository
{
    public class TeacherRepository:ITeacherRepository
    {
        List<Teacher> teachers;
        public TeacherRepository() 
        {
            Teacher teacher1 = new Teacher()
            {
                Id = 1,
                Email = "engahmedsalah311@gmail.com",
                Name = "Ahmed Salah"
            };

            Teacher teacher2 = new Teacher()
            {
                Id = 2,
                Email = "Mohamed_Salah@gmail.com",
                Name = "Mohamed Salah"
            };

            this.teachers = new List<Teacher> { teacher1, teacher2 };
        }

        public Teacher Get(int id)
        {
            var teacher = teachers.Where(i=>i.Id== id).FirstOrDefault();   
            return teacher;
        }

        public List<Teacher> GetAll()
        {
            return teachers;
        }
        public List<Teacher> Add(Teacher teacher)
        {
            teachers.Add(teacher);
            return teachers;
        }
    }
}
