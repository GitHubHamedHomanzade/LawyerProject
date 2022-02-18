using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lawyer.VComponent
{
    [ViewComponent(Name = "MainSlider")]
    public class MainSliderComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {

             return View("MainSlider");

        }

    }
}
