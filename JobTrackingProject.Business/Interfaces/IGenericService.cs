 using JobTrackingProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Business.Interfaces
{
    public interface IGenericService<Entity> where Entity : class, IEntity, new()
    {
        public void Add(Entity entity);
        public void Delete(Entity entity);
        public void Update(Entity entity);
        public Entity GetId(int id);
        public List<Entity> GetAll();
    }
}
