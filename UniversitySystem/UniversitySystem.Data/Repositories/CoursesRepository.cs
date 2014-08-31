namespace UniversitySystem.Data.Repositories
{
    using UniversitySystem.Models;

    public class CoursesRepository : GenericRepository<Course>, IGenericRepository<Course>
    {
        public CoursesRepository(IUniversitySystemDbContext context)
            : base(context)
        {

        }
    }
}
