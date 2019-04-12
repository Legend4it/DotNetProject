using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using ExcelDataReader;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleAppExcelToJsonParser
{
    public static class ExcelDataParser
    {

        public static object GetJsonFromExcelFile(string filename)
        {
            var rows = ParseDataToRowItemsFromExcelFile(filename);
            //Deserialized JsonObject-String to RowItem Collection, need to Check for exceptions
            //return JsonConvert.DeserializeObject<ICollection<RowItem>>(JsonConvert.SerializeObject(rows));
            return JsonConvert.DeserializeObject(JsonConvert.SerializeObject(rows));
        }
        public static List<RowItem> ParseDataToRowItemsFromExcelFile(string filename)
        {
            List<RowItem> outList=new List<RowItem>();

            using (var stream = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    var dataSet = GetDataSetFromExcelDataReader(reader);
                    var dataTable = dataSet.Tables[0];

                    for (var i = 2; i < dataTable.Rows.Count; i++)
                    {
                        RowItem ri=new RowItem(i);
                        for (var j = 0; j < dataTable.Columns.Count; j++)
                        {
                            ri.Columns.Add(new ColumnItem(dataTable.Rows[i][j].ToString()));
                        }
                        outList.Add(ri);
                    }
                }
            }
            return outList;
        }

        private static DataSet GetDataSetFromExcelDataReader(IExcelDataReader reader)
        {
            //// reader.IsFirstRowAsColumnNames
            //var conf = new ExcelDataSetConfiguration
            //{
            //    ConfigureDataTable = _ => new ExcelDataTableConfiguration
            //    {
            //        UseHeaderRow = false
            //    }
            //};
            return reader.AsDataSet();

        }
        //TODO: Make this method more generic...!
        public static WorkType ExcelDataToWorkTypeObjectMapper(RowItem excelData)
        {
            int index = 0;
            WorkType wt = new WorkType
            {
                Name = excelData.Columns.Select(x=>x.ColumnValue).First(),
                UnitOfWorkTime = new MeasurementUnits(double.Parse(excelData.Columns.ElementAt(++index).ColumnValue), excelData.Columns.ElementAt(++index).ColumnValue),
            };

            return wt;
        }

        public static ICollection<WorkType> RowsDataToWorkItemMapper(ICollection<RowItem> rowItems)
        {
            ICollection<WorkType> workItems=new List<WorkType>();
            foreach (var item in rowItems)
            {
                workItems.Add(ExcelDataToWorkTypeObjectMapper(item));
            }

            return workItems;
        }
    }
}
