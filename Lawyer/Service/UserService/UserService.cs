using Lawyer.Context;
using Lawyer.Generic.Repository;
using Lawyer.Models.Account;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.Service.UserService
{
    public class UserService : IUserService
    {

        #region constractor
        private IGenericRepository<User> _userRepository;
        private MyContext _context;
        private DbSet<User> dbSet;
        public UserService(IGenericRepository<User> userRepository, MyContext context)
        {
            _userRepository = userRepository;
            _context = context;
            this.dbSet = this._context.Set<User>();
        }
        #endregion


        #region UserSection

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetEntitiesQuery().ToListAsync();
        }
        public IQueryable<User> GetAllUsersForGrid()
        {
            return dbSet.AsQueryable();
        }

        #endregion


        #region dispose
        public void Dispose()
        {
            _userRepository?.Dispose();
        }

      


        #endregion

    }
}
