using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;

namespace JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Repositories
{
    public class EfAppUserRepository : IAppUserDal
    {
        public List<AppUser> GetMember()
        {
            var context = new JobTrackingProjectContext();
            var result = from user in context.Users
                         join userRoles in context.UserRoles on user.Id equals userRoles.UserId
                         join roles in context.Roles on userRoles.RoleId equals roles.Id
                         where roles.Name == "Member"
                         select new AppUser()
                         {
                             Id = user.Id,
                             Name = user.Name,
                             Surname = user.Surname,
                             ImageUrl = user.ImageUrl,
                             Email = user.Email,
                             UserName = user.UserName
                         };
            return result.ToList();

        }
        public List<AppUser> GetMember(out int totalPage, string wordToSearch, int activePage = 1)
        {

            using var context = new JobTrackingProjectContext();

            var result = context.Users.Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
            {
                user = resultUser,
                userRole = resultUserRole
            }).Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id, (resultTable, resultRole) => new
            {
                user = resultTable.user,
                userRoles = resultTable.userRole,
                roles = resultRole
            }).Where(I => I.roles.Name == "Member").Select(I => new AppUser()
            {
                Id = I.user.Id,
                Name = I.user.Name,
                Surname = I.user.Surname,
                ImageUrl = I.user.ImageUrl,
                Email = I.user.Email,
                UserName = I.user.UserName

            });

            totalPage = (int)Math.Ceiling((double)result.Count() / 3);

            if (!string.IsNullOrWhiteSpace(wordToSearch))
            {
                result = result.Where(I => I.Name.ToLower().Contains(wordToSearch.ToLower()) || I.Surname.ToLower().Contains(wordToSearch.ToLower()));
                totalPage = (int)Math.Ceiling((double)result.Count() / 3);

            }



            result = result.Skip((activePage - 1) * 3).Take(3);

            return result.ToList();
        }

    }
}
