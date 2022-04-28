using Microsoft.AspNetCore.Identity;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Service
{
    public class AccountServiceAsync : IAccountServiceAsync
    {
        private readonly IAccountRepository accountRepository;
        public AccountServiceAsync(IAccountRepository _accountRepository)
        {
            accountRepository = _accountRepository;
        }

        public async Task<SignInResult> Login(LoginModel login)
        {
            return await accountRepository.Login(login);
        }

        public async Task<IdentityResult> SignUpAsync(MovieUserModel model)
        {
            return await accountRepository.SignUpAsync(model);
        }
    }
}
