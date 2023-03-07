using TeacherService.Models;

namespace TeacherService.IRepository
{
    public interface ITeacherRepository:_IBaseService<Teacher>
    {
        List<Teacher> GetAll();
        Teacher Get(int id);
        List<Teacher> Add(Teacher teacher);
    }
}
