using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using AngularJSDemo.ViewModel;
using System.Data;

namespace AngularJSDemo.WCFService
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class TaxService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json)]
        public SubTotal LoadMainTaxFormData()
        {
            var subTotal = new SubTotal();
            subTotal.TotalBusinessIncome = 10000;
            subTotal.Salary = 15000;
            subTotal.Bonus = 5000;
            subTotal.GrandTotalDeductions = 30000;
            subTotal.txtTotalOtherIncome = 40000;

            return subTotal;
        }


        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public SubTotal LoadMainTaxFormSession()
        {
            var subTotal = HttpContext.Current.Session["TaxData"] as SubTotal;

            return subTotal;
        }

        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string LoadMainTaxFormDataSet()
        {
            var ds = new DataSet();
            var dtSubTotal = new DataTable();

            dtSubTotal.Columns.Add("TotalBusinessIncome");
            dtSubTotal.Columns.Add("TotalEmploymentIncome");
            dtSubTotal.Columns.Add("GrandTotalDeductions");
            dtSubTotal.Columns.Add("txtTotalOtherIncome");

            var drSubTotal = dtSubTotal.NewRow();
            drSubTotal["TotalBusinessIncome"] = 10000;
            drSubTotal["TotalEmploymentIncome"] = 20000;
            drSubTotal["GrandTotalDeductions"] = 30000;
            drSubTotal["txtTotalOtherIncome"] = 40000;
            dtSubTotal.Rows.Add(drSubTotal);

            ds.Tables.Add(dtSubTotal);


            var jsonString = Helper.DataSetMapper.ConvertDataRowToJsonString(dtSubTotal.Rows[0]);
            return jsonString;
        }

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void UpdateMainTaxFormData(SubTotal taxData)
        {
            HttpContext.Current.Session["TaxData"] = taxData;
        }
    }
}
