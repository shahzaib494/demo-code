using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using KoperasiTentera.Contracts.User;
using KoperasiTentera.User.Abstraction.User;
using KoperasiTentera.User.Service.Response;
using KoperasiTentra.DAL.EF.Context;

namespace KoperasiTentera.User.Service.User
{
    public class UserService : IUserService
    {

        private readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ResponseDto GetAllUsers()
        {
            var usersList = _dbContext.Users.ToList();
            return new ResponseDto
            {
                statusCode = 200,
                message = "ok",
                data = usersList
            };
        }
    }
}
