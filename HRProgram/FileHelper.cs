using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace HRProgram
{
    public class FileHelper
    {

        public  static string filePath = Path.Combine(Environment.CurrentDirectory, "Employees.json");

        public static List<Employee> GetEmployeesFromJSON()
        {
            if (File.Exists(filePath)) {
                string textToConvert = File.ReadAllText(filePath);
                var employees = JsonConvert.DeserializeObject<List<Employee>>(textToConvert);
                return employees;
            }
            else { File.Create(filePath);
                return new List<Employee>();
            }
                    
        }

        public static void SerializeJSON(List<Employee> employees)
        {
            var ser = JsonConvert.SerializeObject(employees);
            File.WriteAllText(filePath, ser); 
        }
    }
}
