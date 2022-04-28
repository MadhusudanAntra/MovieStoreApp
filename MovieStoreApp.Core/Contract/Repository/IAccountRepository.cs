using Microsoft.AspNetCore.Identity;
using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(MovieUserModel model);
        Task<SignInResult> Login(LoginModel login);
    }
}
