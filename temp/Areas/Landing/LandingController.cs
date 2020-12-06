using Microsoft.AspNetCore.Mvc;

namespace temp.Areas.Landing
{
    public class LandingController : Controller
    {
        #region Pages

        [HttpGet("")]
        public IActionResult Landing()
        {
            // add User and Admin roles
            //await _identityService.CreateRole("User");
            //await _identityService.CreateUserAsync("Bob", "Pa$$w0rd",);
            // CreateUserAsync()
            // add several users with Admin and User roles
            return View();
        }
        [HttpGet("error")]
        public IActionResult Error(Error model) => model.Get();

        // Catches all requests for which there is no route handler

        [Route("{*url}", Order = 9999)]
        public IActionResult CatchAll(CatchAll model) => model.GetOrPost();

        #endregion
    }
}
