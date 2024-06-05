using System;

namespace ClassLibrary
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string Address { get; set; }
        public string DepartmentName { get; set; }
        public bool EmploymentStatus { get; set; }
        public int Salary { get; set; }
        public DateTime? DateofEmployment { get; set; } // Make this nullable
    }
}
