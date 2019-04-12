using System;
using System.Collections.Generic;


using Newtonsoft.Json;

namespace ConsoleAppExcelToJsonParser
{
    public static class HelpClass
    {
        public static string GetFileFromFileNameAndPath(string fileName, string path)
        {
            return path+fileName;
        }

        public static string GetJsonObjectFromExcelFile()
        {
            Account account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
                {
                    "User",
                    "Admin"
                }
            };

            string json = JsonConvert.SerializeObject(account, Formatting.Indented);

            return json;
        }
    }
}
