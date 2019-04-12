namespace ConsoleAppExcelToJsonParser
{
    public class MeasurementUnits
    {
        public double Quantity { get; set; }
        public string Dimension { get; set; }

        public MeasurementUnits()
        {
            
        }
        public MeasurementUnits(double quantity, string dimension)
        {
            Quantity = quantity;
            Dimension = dimension;
        }
    }
}