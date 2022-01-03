using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Account
{
    public class RegistrationDataViewModel
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Пароли не совпадают!!!")]
        [DataType(DataType.Password)]
        public string PasswordSecond { get; set; }
        public string Email { get; set; }
    }
}
