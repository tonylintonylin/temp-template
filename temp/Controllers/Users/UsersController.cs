// using Microsoft.AspNetCore.Mvc;
// using System.Threading.Tasks;
// using MediatR;
// using temp.Domain;
// using System.Collections.Generic;
// using System;

// namespace temp.Controllers.Projects
// {
//     [ApiController]
//     [Menu("Project")]
//     [Route("api/[controller]")]
//     public class ProjectsController : Controller
//     {
//         private readonly IMediator _mediator;

//         public ProjectsController(IMediator mediator)
//         {
//             _mediator = mediator; 
//         }

//         [HttpGet]
//         public async Task<ActionResult<List<Project>>> List()
//         {
//             return await _mediator.Send(new List.Query());
//         }

//         [HttpGet("{id}")]
//         public async Task<ActionResult<Project>> Details(Guid id)
//         {
//             return await _mediator.Send(new Details.Query{Id = id});
//         }

//         [HttpPost]
//         public async Task<ActionResult<Unit>> Create()
//         {
//             return await _mediator.Send(new Create.Command());
//         }

//         [HttpPut("{id}")]
//         public async Task<ActionResult<Unit>> Edit(Guid id, Edit.Command command)
//         {
//             command.Id = id;
//             return await _mediator.Send(command);
//         }

//         [HttpDelete("{id}")]
//         public async Task<ActionResult<Unit>> Delete(Guid id) // change to guid later
//         {
//             return await _mediator.Send(new Delete.Command{Id = id});
//         }

//         // Ancillary actions

//         // [HttpGet("import")]  // Step 1
//         // public IActionResult Import() => new Import().Get();

//         // [HttpPost("import")]  // Step 2
//         // public async Task<IActionResult> Import(IFormFile file) => await new Import { FormFile = file }.UploadAsync();

//         // [HttpPost("import/go")]   // Step 3
//         // public async Task<IActionResult> Import(Import model) => await model.PostAsync();

//         // [HttpGet("export")]
//         // public async Task<IActionResult> Export(Export model) => await model.GetAsync();

//         // #endregion
//     }
// }

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using temp.Domain;

namespace temp.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> List()
        {
            return await _mediator.Send(new List.Query());
        }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<Project>> Details(Guid id)
        // {
        //     return await _mediator.Send(new Details.Query{Id = id});
        // }

        // [HttpPost]
        // public async Task<ActionResult<Unit>> Create(Create.Command command)
        // {
        //     return await _mediator.Send(command);
        // }

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