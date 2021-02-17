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
        // Create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();

        // Get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];

        // Display the Customer ID for this entry
        Response.Write(ACustomer.CustomerID + "\r\n");
        // Display the First Name for this entry
        Response.Write(ACustomer.FirstName + "\r\n");
        // Display the Surname for this entry
        Response.Write(ACustomer.Surname + "\r\n");
        // Display the House Number for this entry
        Response.Write(ACustomer.AddressNo + "\r\n");
        // Display the Address for this entry
        Response.Write(ACustomer.Address + "\r\n");
        // Display the Postcode for this entry
        Response.Write(ACustomer.PostCode + "\r\n");
        // Display the Account Creation Date for this entry
        Response.Write(ACustomer.AccountCreationDate + "\r\n");
        // Display the IsCustomer (If the person is a customer or not) for this entry
        Response.Write(ACustomer.IsCustomer + "\r\n");
        // Display the Total Spent for this entry
        Response.Write(ACustomer.TotalSpent + "\r\n");



    }
}