using TeacherService.IRepository;

namespace TeacherService.Repository
{
    public class BaseService<T>:_IBaseService<T> where T : class
    {
    }
}
