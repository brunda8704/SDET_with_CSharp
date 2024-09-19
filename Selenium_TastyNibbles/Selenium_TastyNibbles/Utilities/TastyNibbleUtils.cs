using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_TastyNibbles.Utilities
{
    internal class TastyNibbleUtils
    {
        public static List<TastyNibbleData> ReadExcelData(string excelFilePath, string sheetName)
        {
            List<TastyNibbleData> excelDataList = new List<TastyNibbleData>();
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true,
                        }
                    });

                    var dataTable = result.Tables[sheetName];

                    if (dataTable != null)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            TastyNibbleData excelData = new TastyNibbleData
                            {
                                SearchInput = GetValueOrDefault(row, "searchinput"),
                                Email = GetValueOrDefault(row, "email"),
                                FirstName = GetValueOrDefault(row, "firstname"),
                                LastName = GetValueOrDefault(row, "lastname"),
                                Address = GetValueOrDefault(row, "address"),
                                City = GetValueOrDefault(row, "city"),
                                Pincode = GetValueOrDefault(row, "pincode"),
                                PhoneNumber= GetValueOrDefault(row,"phonenumber")

                            };

                            excelDataList.Add(excelData);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sheet '{sheetName}' not found in the Excel file.");
                    }
                }
            }

            return excelDataList;
        }

        static string GetValueOrDefault(DataRow row, string columnName)
        {
            Console.WriteLine(row + "  " + columnName);
            return row.Table.Columns.Contains(columnName) ? row[columnName]?.ToString() : null;
        }
    }
}
