﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record CompanyForUpdateDto : CompanyForManipulationDto
    {
        IEnumerable<EmployeeForCreationDto> Employees { get; init; }
    }
}