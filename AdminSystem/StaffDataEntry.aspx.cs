using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create an instance of clsStaff
        clsStaff AStaff = new clsStaff();
        string FullName = txtFullName.Text;
        string Salary = txtSalary.Text;
        string DateOfJoining = txtDateOfJoining.Text;
        string Position = txtPositon.Text;
        string Error = "";
        Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
        if (Error == "")
        {
            //capture staffId
            //AStaff.StaffID = int.Parse(txtStaffID.Text);
            //capture fullname
            AStaff.FullName = txtFullName.Text;
            //capture salary
            AStaff.Salary = double.Parse(txtSalary.Text);
            //capture date of leaving
            AStaff.DateOfJoining = DateTime.Parse(txtDateOfJoining.Text);
            //capture position
            AStaff.Positon = txtPositon.Text;
            //capture full time
            AStaff.FullTime = chkFullTime.Checked;
            //capture active
            AStaff.Active = chkActive.Checked;
            //store the staff in the session object
            Session["AStaff"] = AStaff;
            //nagivate to viewer page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create and instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key 
        Int32 StaffID;
        //Variable to store the result of the find operation
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(StaffID);
        //if found 
        if (Found == true)
        {
            txtStaffID.Text = AStaff.StaffID.ToString();
            txtFullName.Text = AStaff.FullName;
            txtSalary.Text = AStaff.Salary.ToString();
            txtDateOfJoining.Text = AStaff.DateOfJoining.ToString();
            txtPositon.Text = AStaff.Positon;
            chkFullTime.Checked = AStaff.FullTime;
            chkActive.Checked = AStaff.Active;
        }
    }
}