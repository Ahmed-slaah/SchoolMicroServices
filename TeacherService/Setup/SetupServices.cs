using TeacherService.IRepository;
using TeacherService.Repository;

namespace TeacherService.Setup
{
    public static class SetupServices
    {
        public static void SetupApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(_IBaseService<>),typeof(BaseService<>));
            services.AddScoped(typeof(ITeacherRepository),typeof(TeacherRepository));
        }
    }
}
