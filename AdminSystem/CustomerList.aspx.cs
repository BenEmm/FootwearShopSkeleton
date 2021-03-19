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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be edited
        Int32 CustomerID;
        // if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            // Store the data in the session object
            Session["Customer_ID"] = CustomerID;
            // Redirect to the edit page 
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else // if no record has been selected
        {
            // display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        // if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            // Store the data in the session object
            Session["Customer_ID"] = CustomerID;
            // Redirect to the delete page
            Response.Redirect("DeleteCustomer.aspx");
        }
        else // if no record hs been selected
        {
            // display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        // Create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportBySurname(txtFilter.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        // Set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "Surname";
        // bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportBySurname("");
        // Clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        // Set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        // set the name of the field to display
        lstCustomerList.DataTextField = "Surname";
        // Bind the data to the list
        lstCustomerList.DataBind();
    }
}