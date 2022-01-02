using System;


namespace HRProgram
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime DateOfDismissal { get; set; }
        public string Comments { get; set; }
        public decimal Wages { get; set; }        
        public bool IsEmployed { get; set; }
    }
}
