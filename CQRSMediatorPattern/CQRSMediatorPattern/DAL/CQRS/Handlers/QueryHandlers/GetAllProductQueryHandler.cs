using CQRSMediatorPattern.DAL.CQRS.Queries.Request;
using CQRSMediatorPattern.DAL.CQRS.Queries.Response;
using CQRSMediatorPattern.DAL.DatabaseContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatorPattern.DAL.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        private AppDbContext _context { get; }

        public GetAllProductQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {

            return await _context.Products.Select(product => new GetAllProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quentity = product.Qunetity,
                CreateTime = product.CreateTime
            }).ToListAsync();

            #region Another method

            //var products = await _context.Products.ToListAsync();
            //List<GetAllProductQueryResponse> productsResponse = new List<GetAllProductQueryResponse>();

            //foreach (var item in products)
            //{
            //    var model = new GetAllProductQueryResponse()
            //    {
            //        Id = item.Id,
            //        Name = item.Name,
            //        Price = item.Price,
            //        Quentity = item.Qunetity,
            //        CreateTime = item.CreateTime
            //    };
            //    productsResponse.Add(model);
            //}

            //return productsResponse;

            #endregion



        }
    }
}
