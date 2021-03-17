using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteAddress : System.Web.UI.Page
{
    // var to store the primary key value of the record to be deleted
    Int32 CustomerID;

    // event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the customer to be deleted from the seassion object
        CustomerID = Convert.ToInt32(Session["Customer_ID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Create a new instance of the address book
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        // find the record to delete
        CustomerList.ThisCustomer.Find(CustomerID);
        // Delete the record
        CustomerList.Delete();
        // Redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }
}