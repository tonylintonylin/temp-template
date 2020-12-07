using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using temp.Domain;

namespace temp.Controllers.ThingsASecondMethod
{
    [ApiController]
    [Menu("ThingsA")]
    [Route("api/[controller]")]
    public class ThingsASecondMethodController : Controller
    {
        // #region Pages
        private readonly tempContext _context;

        public ThingsASecondMethodController(tempContext context)
        {
            _context = context;
        }

        // GET: api/Tickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThingA>>> GetThingsA()
        {
            return await _context.ThingA.ToListAsync();
        }

        // [HttpGet]
        // public async Task<IActionResult> List([FromQuery] List model) {
        //     return await model.GetAsync();
        // } 

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