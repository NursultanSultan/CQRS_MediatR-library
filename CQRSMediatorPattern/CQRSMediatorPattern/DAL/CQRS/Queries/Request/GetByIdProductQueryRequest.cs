﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatorPattern.DAL.CQRS.Queries.Request
{
    public class GetByIdProductQueryRequest
    {
        public Guid Id { get; set; }
    }
}
