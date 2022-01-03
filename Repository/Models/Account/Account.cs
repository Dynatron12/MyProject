using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Models.Account
{
    public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public string Email { get; set; }
        public short AccountTypeId { get; set; }
        public short IsAccountApprove { get; set; }
    }
}
