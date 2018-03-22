using ROICalculatorMVCStyle.Models;
using ROICalculatorMVCStyle.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROICalculatorMVCStyle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Roi(RoiViewModel roi)
        {
            roi.EndDate = Calculators.BenefitDate(roi);
            roi.Percentage = Calculators.CalcROI(roi);
            return View("Index", roi);
        }
    }
}