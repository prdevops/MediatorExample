using MediatorExample.Med.Commands;
using MediatorExample.Med.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        [Route("api/product/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetProductByIdQuery()
            {
                Id = id
            };
            return Ok(await mediator.Send(query));
        } 

        [HttpGet]
        public async Task<IActionResult> GetAll(Guid id)
        {
            var query = new GetAllProductQuery();
            return Ok(await mediator.Send(query));
        }
        
        [HttpPost()]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
