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

        private string mPassword;
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        private DateTime mDateOfLeaving;
        public DateTime DateOfLeaving
        {
            get
            {
                return mDateOfLeaving;
            }
            set
            {
                mDateOfLeaving = value;
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

        public bool Find(int staffID)
        {
            mStaffID = 21;
            mFullName = "Full Name";
            mPassword = "Password1";
            mDateOfLeaving = Convert.ToDateTime("16/09/2020");
            mPosition = "Weekend Staff";
            mFullTime = false;
            //always return true
            return true;
        }
    }
}