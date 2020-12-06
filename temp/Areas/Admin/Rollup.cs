using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace temp.Areas.Admin
{
    public class Rollup : BaseModel
    {
        public override async Task<IActionResult> GetAsync()
        {
            await _rollup.RollupAllAsync();
            Success = "Rollups have been completed";
            
            return LocalRedirect("/admin");
        }
    }
}
