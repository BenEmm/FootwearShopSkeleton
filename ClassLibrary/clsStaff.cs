using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfLeaving { get; set; }
        public string Positon { get; set; }
        public bool FullTime { get; set; }
    }
}