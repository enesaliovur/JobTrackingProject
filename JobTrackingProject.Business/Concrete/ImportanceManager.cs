using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Repositories;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Business.Concrete
{
    public class ImportanceManager : IImportanceService
    {
        private readonly IImportanceDal _urgencyDal;

      

        public ImportanceManager(IImportanceDal urgencyDal)
        {
            _urgencyDal = urgencyDal;
        }

        public void Add(Importance entity)
        {
            _urgencyDal.Add(entity);
        }

        public void Delete(Importance entity)
        {
            _urgencyDal.Delete(entity);
        }

        public List<Importance> GetAll()
        {
            return _urgencyDal.GetAll();
        }

        public Importance GetId(int id)
        {
            return _urgencyDal.GetId(id);
        }

        public void Update(Importance entity)
        {
            _urgencyDal.Update(entity);
        }
    }
}
