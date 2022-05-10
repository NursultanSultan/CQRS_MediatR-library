using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatorPattern.DAL.CQRS.Queries.Response
{
    public class GetAllProductQueryResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int  Quentity { get; set; }

        public decimal Price { get; set; }

        public DateTime CreateTime { get; set; }    
    }
}
