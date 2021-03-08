using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int mStaffID;
        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

        private string mFullName;
        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }

        private double mSalary;
        public double Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }

        private DateTime mDateOfJoining;
        public DateTime DateOfJoining
        {
            get
            {
                return mDateOfJoining;
            }
            set
            {
                mDateOfJoining = value;
            }
        }

        private string mPosition;
        public string Positon
        {
            get
            {
                return mPosition;
            }
            set
            {
                mPosition = value;
            }
        }

        private bool mFullTime;
        public bool FullTime
        {
            get
            {
                return mFullTime;
            }
            set
            {
                mFullTime = value;
            }
        }

        private bool mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public bool Find(int StaffID)
        {

            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for 
            DB.AddParameter("@StaffID", StaffID);
            //execute stored procedure 
            DB.Execute("sproc_tblStaffdb_FilterByStaffID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy and paste from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);
                mDateOfJoining = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfJoining"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mFullTime = Convert.ToBoolean(DB.DataTable.Rows[0]["FullTime"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string Valid(string FullName, string Salary, string DateOfJoining, string Position)
        {
            String Error = "";
            DateTime DateTemp;
            Double SalaryTemp;

            //is the fullname blank
            if (FullName.Length == 0)
            {
                Error = Error + "The FullName may not be blank : ";
            }

            //is the fullname too long
            if (FullName.Length > 50)
            {
                Error = Error + "The FullName must be less than 50 characters : ";
            }

            try
            {
                //try a type conversion on the original data
                SalaryTemp = Convert.ToDouble(Salary);
                //is salary < 0
                if(SalaryTemp< 0)
                {
                    Error=Error + "The Salary cannot be less than 0 : ";
                }
                //is the salary too high
                if (SalaryTemp > 1000000.00)
                {
                    Error = Error + "The salary must be less than £1000000.00 : ";
                }
            }
            catch
            {
                Error = Error + "Salary is not valid salary: ";
            }

            try
            {
                //Copy the dateofjoinging value to the datetemp variable
                DateTemp = Convert.ToDateTime(DateOfJoining);
                //in the past
                if(DateTemp < DateTime.Now.Date)
                {
                   Error = Error + "The date cannot be in the past : ";
                }
                //in the future
                if (DateTemp> DateTime.Now.Date)
                {
                   Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The Date was not a valid date : ";
            }

            //is the position blank
            if (Position.Length == 0)
            {
                Error = Error + "The Position may not be blank : ";
            }

            //is the position too long
            if (Position.Length > 50)
            {
                Error = Error + "The Position must be less than 50 characters : ";
            }

            return Error;
        }
    }
}