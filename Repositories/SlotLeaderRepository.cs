using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface ISlotLeaderRepository : IRepository<SlotLeader>
    {
    }
    public class SlotLeaderRepository : Repository<SlotLeader>, ISlotLeaderRepository
    {
        public SlotLeaderRepository(IConfiguration configuration)
            : base(configuration, TableNames.SlotLeader) { }
    }
}
