using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExcelToJsonParser
{
    public class WorkType
    {
        public string Name { get; set; }
        public MeasurementUnits UnitOfWorkTime { get; set; }
        public MeasurementUnits NeededQuantity { get; set; }
        public MeasurementUnits WorkHours { get; set; }

        public WorkType()
        {
            UnitOfWorkTime=new MeasurementUnits();
            NeededQuantity=new MeasurementUnits();
            WorkHours=new MeasurementUnits();
        }
    }
}
