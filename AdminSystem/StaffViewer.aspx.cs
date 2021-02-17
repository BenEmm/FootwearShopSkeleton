using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creates a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get data from session object 
        AStaff = (clsStaff)Session["AStaff"];
        //display details
        Response.Write(AStaff.StaffID + "\n");
        Response.Write(AStaff.FullName + "\n");
        Response.Write(AStaff.Salary + "\n");
        Response.Write(AStaff.DateOfJoining + "\n");
        Response.Write(AStaff.Positon + "\n");
        Response.Write(AStaff.FullTime + "\n");
        Response.Write(AStaff.Active + "\n");
    }
}