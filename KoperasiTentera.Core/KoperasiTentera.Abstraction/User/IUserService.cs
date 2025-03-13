using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoperasiTentera.Contracts.User;
using KoperasiTentera.User.Service.Response;

namespace KoperasiTentera.User.Abstraction.User
{
    public interface IUserService
    {
        ResponseDto GetAllUsers();
    }
}
