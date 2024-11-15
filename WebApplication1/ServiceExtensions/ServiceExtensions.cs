using WebApplication1.Interfaces.CoursesInterfaces;
using WebApplication1.Interfaces.StudentInterfaces;

namespace WebApplication1.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ICoursesService, CourseService>();

            return services;
        }
    }

}