using ROICalculatorMVCStyle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ROICalculatorMVCStyle.Services
{
    public static class Calculators
    {
        public static string BenefitDate(RoiViewModel roi)
        {
            return BenefitDate(roi.Cost, roi.Benefit, roi.Date);
        }

        public static string BenefitDate(decimal cost, decimal payback, DateTime startDate)
        {
            int daysInAYear = 365;
            decimal dailyPayback = payback / daysInAYear;
            decimal payedBack = 0;
            startDate = startDate.AddDays(-1);

            while (payedBack < cost)
            {
                payedBack += dailyPayback;
                startDate = startDate.AddDays(1);
            }

            return startDate.ToString("dd/MM/yyyy");
        }

        public static string CalcROI(RoiViewModel roi)
        {
            return CalcROI(roi.Cost, roi.Benefit);
        }
        public static string CalcROI(decimal cost, decimal payback)
        {
            if (cost > 0 && payback > 0)
            {
                decimal ROI = (((payback - cost) / cost) * 100);

                return ROI.ToString() + "%";
            }
            return "Please enter a number that is greater than zero";

        }
    }
}