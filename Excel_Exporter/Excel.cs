using System.Collections.Generic;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace Excel_Exporter
{
    public class Excel
    {
        public static void ExportToExcel(List<object> dataList)
        {

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel._Worksheet worksheet = workbook.ActiveSheet;
            PropertyInfo[] properties = dataList[0].GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                worksheet.Cells[1, i + 1] = properties[i].Name;
            }
            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < properties.Length; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = properties[j].GetValue(dataList[i]);
                }
            }
        }
    }
}
