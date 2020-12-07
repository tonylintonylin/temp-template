using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using temp.Domain;

namespace temp.Controllers.Issues
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public IssuesController(IMediator mediator)
        {
            _mediator = mediator;
        }
//         [HttpGet]
//         public async Task<ActionResult<List<Project>>> List()
//         {
//             return await _mediator.Send(new List.Query());
//         }
        [HttpGet]
        public async Task<ActionResult<List<Issue>>> List()
        {
            return await _mediator.Send(new List.Query());
        }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<Issue>> Details(Guid id)
        // {
        //     return await _mediator.Send(new Details.Query{Id = id});
        // }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(Create.Command command)
        {
            return await _mediator.Send(command);
        }

        // [HttpPut("{id}")]
        // public async Task<ActionResult<Unit>> Edit(Guid id, Edit.Command command)
        // {
        //     command.Id = id;
        //     return await _mediator.Send(command);
        // }
        
        // [HttpDelete("{id}")]
        // public async Task<ActionResult<Unit>> Delete(Guid id)
        // {
        //     return await _mediator.Send(new Delete.Command{Id = id});
        // }
    }
}