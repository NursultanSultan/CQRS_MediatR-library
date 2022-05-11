using CQRSMediatorPattern.DAL.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatorPattern.DAL.CQRS.Commands.Request
{
    public class DeleteProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
