﻿using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace temp.Areas.Admin
{
    public class ClearCache : BaseModel
    {
        public override IActionResult Get()
        {
            new Thread(() => { _cache.Clear(); }).Start();
            Success = "Caches have been cleared";
            
            return LocalRedirect("/admin");
        }
    }
}
