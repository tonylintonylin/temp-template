using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using temp.Domain;
using static temp.Controllers.ThingsASecondMethod.List;

namespace temp.Controllers.ThingsASecondMethod
{
    [ApiController]
    [Menu("ThingsA")]
    [Route("api/[controller]")]
    public class ThingsASecondMethodController : Controller
    {
        // #region Pages
        // private readonly tempContext _context;

        // public ThingsASecondMethodController(tempContext context)
        // {
        //     _context = context;
        // }

        // // GET: api/ThingsA
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<ThingA>>> GetThingsA()
        // {
        //     return await _context.ThingA.ToListAsync();
        // }

        // [HttpGet]
        // public async Task<IActionResult> List([FromQuery] List model) {
        //     return await model.GetAsync();
        // } 
        [HttpGet]
        public async Task<ActionResult<Result>> List([FromQuery] List model)
        {
            return await model.GetAsync();
        }

        // from booking cqrs
        // [HttpGet]
        // public async Task<IActionResult> List([FromQuery]List.Query query)
        // {
        //     var model = await _mediator.Send(query);
        //     return View(model);
        // }
        //end of booking cqrs

        // [HttpGet("{id}", Order = 10)]
        // public async Task<IActionResult> Detail(Detail model) => await model.GetAsync();
        [HttpGet("{id}", Order = 10)]
        public async Task<ActionResult<Detail.Result>> Detail([FromQuery] Detail model, int id)
        {
            return await model.GetAsync(id);
        }

// cqrs mediator reactivities
        //         [HttpGet("{id}")]
        // [Authorize]
        // public async Task<ActionResult<ActivityDto>> Details(Guid id)
        // {
        //     return await Mediator.Send(new Details.Query{Id = id});
        // }
        // [HttpGet("edit/{id?}")]
        // public async Task<IActionResult> Edit(int id) => await new Edit { Id = id }.GetAsync();

        // [HttpPost("edit/{id?}")]
        // public async Task<IActionResult> Edit(Edit model) => await model.PostAsync();

        // [HttpPost("delete"), AjaxOnly]
        // public async Task<IActionResult> Delete(Delete model) => await model.PostAsync();
        // [HttpPost("delete")]
        // public async Task<IActionResult> Delete(Delete model) => await model.PostAsync();
        // [HttpPost("{id}")]
        // public async Task<IActionResult> Delete(Delete model, int id) => await model.PostAsync(id);
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
