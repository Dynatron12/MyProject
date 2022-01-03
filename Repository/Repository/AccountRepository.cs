using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class AccountRepository
    {
        private readonly ProjectDBContext _context;

        public AccountRepository()
        {
            _context = new ProjectDBContext();
        }

        public Account SignedAccount(LoginDataViewModel model)
        {
            return _context.Accounts
                    .Where(x => x.AccountName == model.UserName
                   && x.AccountPassword == model.Password)
                    .Select(e => new Account
                    {
                        AccountId = e.AccountId,
                        AccountName = e.AccountName,
                        AccountPassword = e.AccountPassword,
                        Email = e.Email,
                        AccountTypeId = e.AccountTypeId,
                        IsAccountApprove = e.IsAccountApprove
                    }).FirstOrDefault();
        }

        public void Registration(RegistrationDataViewModel model)
        {
            _context.Accounts.Add(new Account
            {
                AccountName = model.UserName,
                AccountPassword = model.Password,
                Email = model.Email,
                IsAccountApprove = 0,
                AccountTypeId = 0
            });
            _context.SaveChanges();
        }
    }
}
