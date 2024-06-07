
using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string Address { get; set; }
        public string DepartmentName { get; set; }
        public bool EmploymentStatus { get; set; }
        public int Salary { get; set; }
        public DateTime DateofEmployment { get; set; }

        public bool Find(int staffId)
        {
            throw new NotImplementedException();
        }

        public string Valid(string staffID, object name, object address, object departmentName, string salary)
        {
            throw new NotImplementedException();
        }
    }
}