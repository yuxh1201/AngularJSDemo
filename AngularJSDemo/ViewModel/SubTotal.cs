using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSDemo.ViewModel
{
    public class SubTotal
    {
        public decimal TotalBusinessIncome { get; set; }
        public decimal txtTotalOtherIncome { get; set; }
        public decimal GrandTotalDeductions { get; set; }

        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }

        private decimal totalEmploymentIncome;
        public decimal TotalEmploymentIncome
        {
            get
            {
                return Salary + Bonus;
            }
            set
            {
                totalEmploymentIncome = value;
            }
        }
    }
}