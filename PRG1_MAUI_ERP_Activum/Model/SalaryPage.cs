using System;
using System.Collections.Generic;
using System.Text;

namespace PRG1_MAUI_ERP_Activum.Model
{
    public class SalaryPageClass
    {
        public static int CurrentUser = 0;
    }
    
    public class Employee
    {
        public int BaseSalary { get; set; }
        public int CommissionEarnedThisMonth { get; set; }
        public double CommissionRate { get; set; }
        public required string Email { get; set; }
        public required string Name { get; set; }
        public required string Password { get; set; }
        public int TotalEarnedThisYear { get; set; }
    }
}
