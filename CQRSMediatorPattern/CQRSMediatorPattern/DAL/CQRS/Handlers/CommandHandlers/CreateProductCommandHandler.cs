using CQRSMediatorPattern.DAL.CQRS.Commands.Request;
using CQRSMediatorPattern.DAL.CQRS.Commands.Response;
using CQRSMediatorPattern.DAL.DatabaseContext;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatorPattern.DAL.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private AppDbContext _context { get; set; }

        public CreateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var Product = await _context.Products.AddAsync(new Entity.Product
            {
                Name = request.Name,
                Price = request.Price,
                Qunetity = request.Quantity,
                CreateTime = DateTime.Now
            });

            await _context.SaveChangesAsync();

            return new CreateProductCommandResponse
            {
                IsSuccess = true
            };

        }
    }
}
