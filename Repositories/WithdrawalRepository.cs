using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IWithdrawalRepository: IRepository<Withdrawal>
    {
    }
    public class WithdrawalRepository: Repository<Withdrawal>, IWithdrawalRepository
    {
        public WithdrawalRepository(IConfiguration configuration) 
            : base(configuration, TableNames.Withdrawal) { }
    }
}
