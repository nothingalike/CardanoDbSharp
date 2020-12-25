using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IParamProposalRepository : IRepository<ParamProposal>
    {
    }
    public class ParamProposalRepository : Repository<ParamProposal>, IParamProposalRepository
    {
        public ParamProposalRepository(IConfiguration configuration)
            : base(configuration, TableNames.ParamProposal) { }
    }
}
