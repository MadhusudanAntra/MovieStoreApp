using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class AccountRepository:IAccountRepository
    {
        private readonly UserManager<MovieUser> _userManager;
        private readonly SignInManager<MovieUser> _signInManager;
        public AccountRepository(UserManager<MovieUser> userManager, SignInManager<MovieUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IdentityResult> SignUpAsync(MovieUserModel model) {
            MovieUser user = new MovieUser() {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.EmailId,
                UserName = model.EmailId
            };
          return await _userManager.CreateAsync(user, model.Password);
        }

        public async Task<SignInResult> Login(LoginModel login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.Username, login.Password, false, false);
            return result;
                    
        }
    }
}
