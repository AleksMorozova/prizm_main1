﻿using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Construction
{
    public interface IComponentTypeRepository : IRepository<Guid, ComponentType>
    {
    }
}
