using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.User;

namespace Services.UserServices
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(UserRegister model);

        
    }
}