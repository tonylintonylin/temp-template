
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MediatR;
using System.Collections.Generic;
using temp.Domain;

namespace temp.Controllers.Customer
{
    [ApiController]
    [Menu("Customer")]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator; 
        }

        [HttpGet]
        public async Task<ActionResult<List<Domain.Customer>>> List()
        {
            return await _mediator.Send(new List.Query());
        }
        // [HttpGet]
        // public async Task<IActionResult> List([FromQuery]List.Query query)
        // {
        //      return await _mediator.Send(new List.Query());
        // }

        // #region Pages

        // [HttpGet]
        // public async Task<IActionResult> List([FromQuery] List model) => await model.GetAsync();

        // [HttpGet("{id}", Order = 10)]
        // public async Task<IActionResult> Detail(Detail model) => await model.GetAsync();

        // [HttpGet("edit/{id?}")]
        // public async Task<IActionResult> Edit(int id) => await new Edit { Id = id }.GetAsync();

        // [HttpPost("edit/{id?}")]
        // public async Task<IActionResult> Edit(Edit model) => await model.PostAsync();
        
        // [HttpPost("delete"), AjaxOnly]
        // public async Task<IActionResult> Delete(Delete model) => await model.PostAsync();

        // // Ancillary actions

        // [HttpGet("import")]  // Step 1
        // public IActionResult Import() => new Import().Get();

        // [HttpPost("import")]  // Step 2
        // public async Task<IActionResult> Import(IFormFile file) => await new Import { FormFile = file }.UploadAsync();

        // [HttpPost("import/go")]   // Step 3
        // public async Task<IActionResult> Import(Import model) => await model.PostAsync();

        // [HttpGet("export")]
        // public async Task<IActionResult> Export(Export model) => await model.GetAsync();

        // #endregion
    }
}
