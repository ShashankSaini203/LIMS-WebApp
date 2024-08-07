﻿using LIMS.Domain.Interfaces.Repository.Commands.BaseCommand;
using LIMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Domain.Interfaces.Repository.Commands
{
    public interface ILabCommandRepository : IBaseCommandRepository<Laboratory>
    {
        Laboratory CreateLaboratory(Laboratory laboratory);
    }
}