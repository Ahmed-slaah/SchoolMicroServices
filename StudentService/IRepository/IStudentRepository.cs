using StudentService.Models;

namespace StudentService.IRepository
{
    public interface IStudentRepository:_IBaseRepository<Student>
    {
        List<Student> GetAll();
        Student Get(int id);
        List<Student> Add(Student student);
    }
}
