using StudentService.IRepository;

namespace StudentService.Repository
{
    public class _BaseRepository<T>: _IBaseRepository<T> where T : class
    {
    }
}
