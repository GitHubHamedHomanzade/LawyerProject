 using Lawyer.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lawyer.Service.UserService
{
   public  interface IUserService:IDisposable
    {
        Task<List<User>> GetAllUsers();
        IQueryable<User> GetAllUsersForGrid();
 

    }
}
