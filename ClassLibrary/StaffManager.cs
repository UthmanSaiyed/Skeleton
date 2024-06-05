using System;
using System.Data;

namespace ClassLibrary
{
    public class StaffManager
    {
        private clsDataConnection connection;

        public StaffManager()
        {
            connection = new clsDataConnection();
        }

        public void AddStaff(Staff staff)
        {
            connection.ClearParameters();
            connection.AddParameter("@StaffName", staff.StaffName);
            connection.AddParameter("@Address", staff.Address);
            connection.AddParameter("@DepartmentName", staff.DepartmentName);
            connection.AddParameter("@EmploymentStatus", staff.EmploymentStatus);
            connection.AddParameter("@Salary", staff.Salary);
            connection.AddParameter("@DateofEmployment", staff.DateofEmployment);
            connection.Execute("spAddStaff");
        }

        public void UpdateStaff(Staff staff)
        {
            connection.ClearParameters();
            connection.AddParameter("@StaffID", staff.StaffID);
            connection.AddParameter("@StaffName", staff.StaffName);
            connection.AddParameter("@Address", staff.Address);
            connection.AddParameter("@DepartmentName", staff.DepartmentName);
            connection.AddParameter("@EmploymentStatus", staff.EmploymentStatus);
            connection.AddParameter("@Salary", staff.Salary);
            connection.AddParameter("@DateofEmployment", staff.DateofEmployment);
            connection.Execute("spUpdateStaff");
        }

        public void DeleteStaff(int staffId)
        {
            connection.ClearParameters();
            connection.AddParameter("@StaffID", staffId);
            connection.Execute("spDeleteStaff");
        }

        public DataTable GetAllStaff()
        {
            connection.ClearParameters();
            connection.Execute("spGetAllStaff");
            return connection.DataTable;
        }

        public Staff GetStaffById(int staffId)
        {
            connection.ClearParameters();
            connection.AddParameter("@StaffID", staffId);
            connection.Execute("spGetStaffById");
            var dt = connection.DataTable;

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                return new Staff
                {
                    StaffID = Convert.ToInt32(row["StaffID"]),
                    StaffName = row["StaffName"].ToString(),
                    Address = row["Address"].ToString(),
                    DepartmentName = row["DepartmentName"].ToString(),
                    EmploymentStatus = Convert.ToBoolean(row["EmploymentStatus"]),
                    Salary = Convert.ToInt32(row["Salary"]),
                    DateofEmployment = Convert.ToDateTime(row["DateofEmployment"])
                };
            }
            return null;
        }

        public DataTable FilterStaff(string staffName, string departmentName, bool? employmentStatus)
        {
            connection.ClearParameters();
            connection.AddParameter("@StaffName", staffName);
            connection.AddParameter("@DepartmentName", departmentName);
            connection.AddParameter("@EmploymentStatus", employmentStatus);
            connection.Execute("spFilterStaff");
            return connection.DataTable;
        }
        public DataTable FindStaffByName(string staffName)
        {
            connection.ClearParameters();
            connection.AddParameter("@StaffName", staffName);
            connection.Execute("spFindStaffByName");
            return connection.DataTable;
        }
        public DataTable GetStaffStatistics()
        {
            connection.ClearParameters();
            connection.Execute("spGetStaffStatistics");
            return connection.DataTable;
        }
    }
}
