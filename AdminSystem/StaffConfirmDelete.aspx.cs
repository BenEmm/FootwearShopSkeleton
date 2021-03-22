using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted 
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get th enumber of the adress to be deleted from th esession object
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff collection
        clsStaffCollection StaffListing = new clsStaffCollection();
        //find the record to delete
        StaffListing.ThisStaff.Find(StaffID);
        //delete the record
        StaffListing.Delete();
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //no change and goes back to the list page
        Response.Redirect("StaffList.aspx");
    }
}