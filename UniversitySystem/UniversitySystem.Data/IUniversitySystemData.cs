namespace UniversitySystem.Data
{
    using UniversitySystem.Data.Repositories;
    using UniversitySystem.Models;

    public interface IUniversitySystemData
    {
        IGenericRepository<Course> Courses { get; }

        IGenericRepository<Student> Students { get; }

        IGenericRepository<Homework> Homeworks { get; }

    }
}
