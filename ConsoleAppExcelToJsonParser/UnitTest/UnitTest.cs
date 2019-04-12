using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleAppExcelToJsonParser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
       
        private string filename= AppDomain.CurrentDomain.BaseDirectory+"../../../../Template.xlsx";


        [TestMethod]
        public void GetJsonObjectFromExcelFileIsSuccess()
        {
            try
            {
                var exp = ExcelDataParser.GetJsonFromExcelFile(filename);
            }
            catch (Exception ex)
            {
                Assert.Fail("Json Parsing Exception:",ex.Message);
            }
        }
        [TestMethod]
        public void GetJsonObjectFromExcelFileSuccess()
        {
            string json = HelpClass.GetJsonObjectFromExcelFile();
            Assert.IsNotNull(json);
        }

        [TestMethod]
        public void ReadExcelFileSuccess()
        {
            ICollection<RowItem> outList = PrepareDataListFromExcelFile(filename).ToList();
            Assert.IsTrue(outList.Count>0);
        }

        [TestMethod]
        public void MapExcelResultToObjectIsSuccess()
        {
            ICollection<RowItem> outList = PrepareDataListFromExcelFile(filename).ToList();
            var actName = "Conveyor assembly with sliderail and chain X45-X65-X85-XH-XK";
            var firstItem = ExcelDataParser.RowsDataToWorkItemMapper(outList).First();
            Assert.AreEqual(actName,firstItem.Name);
        }

        [TestMethod]
        public void CreateWorkTypeObjectIsSuccess()
        {

            WorkType act = new WorkType
            {
                Name = "Conveyor assembly with sliderail and chain X45-X65-X85-XH-XK",
                UnitOfWorkTime = new MeasurementUnits(10, "m"),
                NeededQuantity = new MeasurementUnits(1, "cm"),
                WorkHours = new MeasurementUnits(0.1, "m")
            };

            ICollection<RowItem> outList = PrepareDataListFromExcelFile(filename);
            WorkType exp = ExcelDataParser.ExcelDataToWorkTypeObjectMapper(outList.AsQueryable().First());
            Assert.AreEqual(act.Name, exp.Name);

        }
        private ICollection<RowItem> PrepareDataListFromExcelFile(string fileName)
        {
            return new List<RowItem>(ExcelDataParser.ParseDataToRowItemsFromExcelFile(filename));
        }



        
    }
}
