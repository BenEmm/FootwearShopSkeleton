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
        //capture staffId
        AStaff.StaffID = int.Parse(txtStaffID.Text);
        //capture fullname
        AStaff.FullName = txtFullName.Text;
        //capture password
        AStaff.Salary = double.Parse(txtSalary.Text);
        //capture date of leaving
        AStaff.DateOfLeaving = DateTime.Parse(txtDateOfLeaving.Text);
        //capture position
        AStaff.Positon = txtPositon.Text;
        //capture full time
        AStaff.FullTime = chkFullTime.Checked;
        //store the staff in the session object
        Session["AStaff"] = AStaff;
        //nagivate to viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}