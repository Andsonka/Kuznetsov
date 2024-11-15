using WebApplication1.Database;
using WebApplication1.Models;
using WebApplication1.Filters.StudentFilters;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Interfaces.CoursesInterfaces
{
    public interface ICoursesService
    {
        public Task<Course[]> GetCoursesByGroupAsync(CourseFilter filter, CancellationToken cancellationToken);
    }
    public class CourseService : ICoursesService
    {
        private readonly StudentDbContext _dbContext;
        public CourseService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Course[]> GetCoursesByGroupAsync(CourseFilter filter, CancellationToken cancellationToken = default)
        {
            var courses = _dbContext.Set<Course>().Where(w => w.Group.GroupName == filter.GroupName).ToArrayAsync(cancellationToken);

            return courses;
        }
    }
}
