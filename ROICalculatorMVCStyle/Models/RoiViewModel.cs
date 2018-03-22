using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ROICalculatorMVCStyle.Models
{
    public class RoiViewModel
    {
        [DisplayName("Total Cost of the Project")]
        public decimal Cost { get; set; }
        [DisplayName("Yearly Benefit From the Project")]
        public decimal Benefit { get; set; }
        [DisplayName("Date That the Project Goes Live")]
        public DateTime Date { get; set; }
        public string EndDate { get; set; }
        public string  Percentage { get; set; }
    }
}