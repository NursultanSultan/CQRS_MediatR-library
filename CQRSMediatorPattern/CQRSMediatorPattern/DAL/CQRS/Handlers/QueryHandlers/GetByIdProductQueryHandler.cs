using CQRSMediatorPattern.DAL.CQRS.Queries.Request;
using CQRSMediatorPattern.DAL.CQRS.Queries.Response;
using CQRSMediatorPattern.DAL.DatabaseContext;
using CQRSMediatorPattern.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatorPattern.DAL.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        private AppDbContext _context { get; }

        public GetByIdProductQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var dbProduct = _context.Products.Where(p => p.Id == request.Id).FirstOrDefault();

            return new GetByIdProductQueryResponse
            {
                Id = dbProduct.Id,
                Name = dbProduct.Name,
                Price = dbProduct.Price,
                Quantity = dbProduct.Qunetity,
                CreateTime = dbProduct.CreateTime
            };
        }
    }
}
