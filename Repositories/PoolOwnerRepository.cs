﻿using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IPoolOwnerRepository : IRepository<PoolOwner>
    {
    }
    public class PoolOwnerRepository : Repository<PoolOwner>, IPoolOwnerRepository
    {
        public PoolOwnerRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolOwner) { }
    }
}
