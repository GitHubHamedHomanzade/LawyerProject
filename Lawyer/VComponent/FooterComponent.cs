using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lawyer.VComponent
{
    [ViewComponent(Name = "Footer")]

    public class FooterComponent:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {

           // ViewData["Data"] = "fffffffffffffffffffffffffff";
            return View("Footer");

        }

    }
}
