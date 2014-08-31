namespace UniversitySystem.Data.Repositories
{
    using UniversitySystem.Models;

    public class StudentsRepository : GenericRepository<Student>, IGenericRepository<Student>
    {
        public StudentsRepository(IUniversitySystemDbContext context)
            : base(context)
        {

        }
    }
}
