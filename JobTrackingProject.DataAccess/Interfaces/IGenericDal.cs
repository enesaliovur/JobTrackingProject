using JobTrackingProject.Entities.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Interfaces
{
    public interface IGenericDal<Entity> where Entity : class, IEntity, new()
    {
        public void Add(Entity entity);
        public void Delete(Entity entity);
        public void Update(Entity entity);
        public Entity GetId(int id);
        public List<Entity> GetAll();

    }
}
