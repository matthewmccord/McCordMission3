using McCordMission3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McCordMission3.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult grade_calculator ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult grade_calculator (GradeCalcModel model)
        {
            return View();
        }
    }
}
