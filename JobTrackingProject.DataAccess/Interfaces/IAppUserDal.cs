using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Interfaces
{
    public interface IAppUserDal
    {
        public List<AppUser> GetMember();
        public List<AppUser> GetMember(out int toplamSayfa, string aranacakKelime, int aktifSayfa = 1);


    }
}
