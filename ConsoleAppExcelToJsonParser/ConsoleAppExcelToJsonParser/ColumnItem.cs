namespace ConsoleAppExcelToJsonParser
{
    public class ColumnItem
    {
        public string ColumnValue { get; set; }

        public ColumnItem(string columnValue)
        {
            ColumnValue = columnValue;
        }
    }
}