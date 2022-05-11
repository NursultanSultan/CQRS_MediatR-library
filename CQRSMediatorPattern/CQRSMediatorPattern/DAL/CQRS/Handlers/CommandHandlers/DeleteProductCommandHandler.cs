using CQRSMediatorPattern.DAL.CQRS.Commands.Request;
using CQRSMediatorPattern.DAL.CQRS.Commands.Response;
using CQRSMediatorPattern.DAL.DatabaseContext;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatorPattern.DAL.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {

        private AppDbContext _context { get; set; }

        public DeleteProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var dbProduct = _context.Products.Where(p => p.Id == request.Id).FirstOrDefault();

            if (dbProduct is null)
            {
                throw new Exception("Product is Not Found");
            }

            _context.Products.Remove(dbProduct);
            await _context.SaveChangesAsync();

            return new DeleteProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
