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
            // mStaffID = 21;
            // mFullName = "Full Name";
            // mSalary = 7.78;
            // mDateOfLeaving = Convert.ToDateTime("16/09/2020");
            // mPosition = "Weekend Staff";
            // mFullTime = false;
            //always return true
            // return true;

            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for 
            DB.AddParameter("@StaffID", StaffID);
            //execute stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffID");
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
    }
}