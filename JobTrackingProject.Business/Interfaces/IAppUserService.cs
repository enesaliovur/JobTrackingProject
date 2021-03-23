using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Business.Interfaces
{
    public interface IAppUserService
    {
        public List<AppUser> GetMember();
        public List<AppUser> GetMember(out int totalPage, string wordToSearch, int activePage = 1);
    }
}
