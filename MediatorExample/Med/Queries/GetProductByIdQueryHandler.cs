using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorExample.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            var model = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Mediator CQRS"
            };

            return Task.FromResult(model);
        }
    }
}
