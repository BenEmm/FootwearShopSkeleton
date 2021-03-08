using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create a new instance of the class you want to create
        clsStaffCollection AllStaff = new clsStaffCollection();
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = AllStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data field to display
        lstStaffList.DataTextField = "FullName";
        //bind the data to the list
        lstStaffList.DataBind();

    }
}