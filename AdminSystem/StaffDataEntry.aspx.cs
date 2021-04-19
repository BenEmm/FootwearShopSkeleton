using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variablle to store the primary key with page level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the adress to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if(StaffID != -1)
            {
                DisplayStaff();
            }
        }
    }

    private void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection AllStaff = new clsStaffCollection();
        //find the record to update 
        AllStaff.ThisStaff.Find(StaffID);
        //display the data for this record
        txtStaffID.Text = AllStaff.ThisStaff.StaffID.ToString();
        txtFullName.Text = AllStaff.ThisStaff.FullName;
        txtSalary.Text = AllStaff.ThisStaff.Salary.ToString();
        txtDateOfJoining.Text = AllStaff.ThisStaff.DateOfJoining.ToString();
        txtPositon.Text = AllStaff.ThisStaff.Position;
        chkFullTime.Checked = AllStaff.ThisStaff.FullTime;
        chkActive.Checked = AllStaff.ThisStaff.Active;
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
            //capture the staffid
            AStaff.StaffID = StaffID;
            //capture fullname
            AStaff.FullName = txtFullName.Text;
            //capture salary
            AStaff.Salary = double.Parse(txtSalary.Text);
            //capture date of leaving
            AStaff.DateOfJoining = DateTime.Parse(txtDateOfJoining.Text);
            //capture position
            AStaff.Position = txtPositon.Text;
            //capture full time
            AStaff.FullTime = chkFullTime.Checked;
            //capture active
            AStaff.Active = chkActive.Checked;
            //store the staff in the session object
            //Session["AStaff"] = AStaff;
            //nagivate to viewer page
            //Response.Redirect("StaffViewer.aspx");
            //create a new instance of the staf collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //if this is a new record
            if (StaffID == -1)
            {
                //set the ThisSTaff property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffID);
                //set thisstaff property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
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
            txtPositon.Text = AStaff.Position;
            chkFullTime.Checked = AStaff.FullTime;
            chkActive.Checked = AStaff.Active;
        }else
        {
            lblError.Text = "Staff member not found";
        }
        
       
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //takes you back to the staff list
        Response.Redirect("StaffList.aspx");

    }
}