using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    // This function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            // Update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        // Create an isntance of the class you want to create
        clsCustomerCollection Customers = new clsCustomerCollection();
        // Set the data source to the lsit of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        // Set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        // Set the data field to display
        lstCustomerList.DataTextField = "FirstName";
        // Bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    // Event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate this is a new record
        Session["Customer_ID"] = -1;
        // Redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }
}