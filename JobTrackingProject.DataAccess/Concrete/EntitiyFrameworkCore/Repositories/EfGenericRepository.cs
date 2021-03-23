using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Repositories
{
    public class EfGenericRepository<Entity> : IGenericDal<Entity> where Entity : class, IEntity, new()
    {
        public void Add(Entity entity)
        {
            using var context = new JobTrackingProjectContext();
            context.Set<Entity>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(Entity entity)
        {
            using var context = new JobTrackingProjectContext();
            context.Set<Entity>().Remove(entity);
            context.SaveChanges();
        }

        public void Update(Entity entity)
        {
            using var context = new JobTrackingProjectContext();
            context.Set<Entity>().Update(entity);
            context.SaveChanges();
                
        }

        public List<Entity> GetAll()
        {
            using var context = new JobTrackingProjectContext();
            return context.Set<Entity>().ToList();
        }

        public Entity GetId(int id)
        {
            using var context = new JobTrackingProjectContext();
            return context.Set<Entity>().Find(id);

        }

       
    }
}
