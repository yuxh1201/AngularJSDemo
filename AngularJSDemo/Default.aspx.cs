using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AngularJSDemo.ViewModel;

namespace AngularJSDemo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // retrieve data from database
            var subTotal = new SubTotal();
            subTotal.TotalBusinessIncome = 10000;
            subTotal.GrandTotalDeductions = 30000;
            subTotal.txtTotalOtherIncome = 40000;

            subTotal.Salary = 15000;
            subTotal.Bonus = 5000;


            // load to session
            if (Session["TaxData"] == null)
                Session["TaxData"] = subTotal;
        }
    }
}
