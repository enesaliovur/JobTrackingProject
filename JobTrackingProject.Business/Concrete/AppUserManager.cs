using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {

        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public List<AppUser> GetMember()
        {
            return _appUserDal.GetMember();
        }

        public List<AppUser> GetMember(out int totalPage, string wordToSearch, int activePage = 1)
        {
            return _appUserDal.GetMember(out totalPage, wordToSearch, activePage);
        }
    }
}
