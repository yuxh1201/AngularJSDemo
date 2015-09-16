using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Script.Serialization;

namespace AngularJSDemo.Helper
{
    public class DataSetMapper
    {
        public static string ConvertDataRowToJsonString(DataRow dr)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            foreach (DataColumn col in dr.Table.Columns)
            {
                row.Add(col.ColumnName, dr[col]);
            }

            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(row);
        }

        public static Dictionary<string, object> ConvertDataRowToEntity(DataRow dr)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            foreach (DataColumn col in dr.Table.Columns)
            {
                row.Add(col.ColumnName, dr[col]);
            }
            return row;
        }

        public static string ConvertDataTableToJsonString(DataTable dt)
        {
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }

            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(rows);
        }
    }
}