using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatorPattern.DAL.CQRS.Commands.Request
{
    public class DeleteProductCommandRequest
    {
        public Guid Id { get; set; }
    }
}
