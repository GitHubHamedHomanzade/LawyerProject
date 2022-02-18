using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lawyer.VComponent
{
    [ViewComponent(Name = "Header")]
    public class HeaderComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {

             return View("Header");

        }

    }
}
