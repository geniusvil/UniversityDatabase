namespace UniversitySystem.Data.Repositories
{
    using UniversitySystem.Models;

    public class HomeworksRepository : GenericRepository<Homework>, IGenericRepository<Homework>
    {
        public HomeworksRepository(IUniversitySystemDbContext context)
            : base(context)
        {

        }
    }
}
