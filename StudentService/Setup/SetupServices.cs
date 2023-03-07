using Microsoft.Extensions.DependencyInjection;
using StudentService.IRepository;
using StudentService.Repository;

namespace StudentService.Setup
{
    public static class SetupServices
    {
        public static void SetupApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(_IBaseRepository<>),typeof(_BaseRepository<>));
            services.AddScoped(typeof(IStudentRepository),typeof(StudentRepository));
        }
    }
}
