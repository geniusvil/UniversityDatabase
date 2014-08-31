namespace UniversitySystem.Data
{
    using System;
    using System.Collections.Generic;

    using UniversitySystem.Data.Repositories;
    using UniversitySystem.Models;

    public class UniversitySystemData : IUniversitySystemData
    {
        private IUniversitySystemDbContext context;
        private IDictionary<Type, object> repositories;

        public UniversitySystemData()
            : this(new UniversitySystemDbContext())
        {
        }
        public UniversitySystemData(IUniversitySystemDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }
        public IGenericRepository<Course> Courses
        {
            get
            {
                return this.GetRepository<Course>();
            }
        }

        public IGenericRepository<Student> Students
        {
            get
            {
                return this.GetRepository<Student>();
            }
        }

       public IGenericRepository<Homework> Homeworks
       {
           get 
           {
               return this.GetRepository<Homework>(); 
           }
       }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);

                if (typeOfModel.IsAssignableFrom(typeof(Student)))
                {
                    type = typeof(StudentsRepository);
                }
                else if (typeOfModel.IsAssignableFrom(typeof(Course)))
                {
                    type = typeof(CoursesRepository);
                }
                else if (typeOfModel.IsAssignableFrom(typeof(Homework)))
                {
                    type = typeof(HomeworksRepository);
                }

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}
