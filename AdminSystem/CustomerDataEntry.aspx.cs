using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{   // variable to store the primary key with page level scope
     Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the customer to be processsed
        CustomerID = Convert.ToInt32(Session["Customer_ID"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (CustomerID != -1)
            {
                // Display the current data for the record
                DisplayCustomer(); 
            }
        }
    }

    void DisplayCustomer()
    {
        // create an instance of the customer list
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        // find the record to update
        CustomerList.ThisCustomer.Find(CustomerID);
        // Display the data for this record
        txtCustomerID.Text = CustomerList.ThisCustomer.CustomerID.ToString();
        txtFirstName.Text = CustomerList.ThisCustomer.FirstName;
        txtSurname.Text = CustomerList.ThisCustomer.Surname;
        txtAddressNo.Text = CustomerList.ThisCustomer.AddressNo.ToString();
        txtAddress.Text = CustomerList.ThisCustomer.Address;
        txtPostcode.Text = CustomerList.ThisCustomer.PostCode;
        txtEmail.Text = CustomerList.ThisCustomer.Email;
        txtDate.Text = CustomerList.ThisCustomer.AccountCreationDate.ToString();
        txtTotalSpent.Text = CustomerList.ThisCustomer.TotalSpent.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        // Capture the first name
        string First_Name = txtFirstName.Text;
        // Capture the surname
        string Surname = txtSurname.Text;
        // Capture the address no
        string AddressNo = txtAddressNo.Text;
        // Capture the Address
        string Address = txtAddress.Text;
        // Capture the postcode
        string Postcode = txtPostcode.Text;
        // Capture the email 
        string Email = txtEmail.Text;
        // Capture the account creation date
        string AccountCreationDate = txtDate.Text;
        // variable to store any error messages
        string Error = "";

        // Validate the data
        Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, AccountCreationDate);
        if (Error == "")
        {
            // Captures the customerID
            ACustomer.CustomerID = CustomerID;
            // Captures the First Name
            ACustomer.FirstName = First_Name;
            // Captures the Surname
            ACustomer.Surname = Surname;
            // Capture the house number
            ACustomer.AddressNo = int.Parse(AddressNo);
            // Captures the Address
            ACustomer.Address = Address;
            // Captures the Postcode
            ACustomer.PostCode = Postcode;
            // Captures the Email
            ACustomer.Email = Email;
            // Captures the Account Creation Date 
            ACustomer.AccountCreationDate = DateTime.Parse(AccountCreationDate);
            // Captures whether the person is a customer or not
            ACustomer.IsCustomer = chkConfirm.Checked;
            //Captures the total a customer has spent
            ACustomer.TotalSpent = decimal.Parse(txtTotalSpent.Text);
            // ----------------------------------------------------------------- //
            // Create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            
            // if this is a new record i.e CustomerID = -1 then add the data
            if (CustomerID == -1)
            {
                // set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                // Add the new record
                CustomerList.Add();
            }
            // Otherwise it must be an update
            else
            {
                // Find the record to update
                CustomerList.ThisCustomer.Find(CustomerID);
                // Set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                // Update the record
                CustomerList.Update();
            }
            // redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
        }
    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        // Variable to store the primary key
        Int32 CustomerID;
        // Variable to store the result of the find operation
        Boolean Found = false;
        // Get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        // Find the record
        Found = ACustomer.Find(CustomerID);
        // If found
        if (Found == true)
        {
            // Display the values of the properties in the form
            txtFirstName.Text = ACustomer.FirstName;
            txtSurname.Text = ACustomer.Surname;
            txtAddressNo.Text = ACustomer.AddressNo.ToString();
            txtAddress.Text = ACustomer.Address;
            txtPostcode.Text = ACustomer.PostCode;
            txtEmail.Text = ACustomer.Email;
            txtDate.Text = ACustomer.AccountCreationDate.ToString();
            txtTotalSpent.Text = ACustomer.TotalSpent.ToString();
        } else
        {
            // Alternative text for error messages
            txtFirstName.Text = "Record not found";
            txtSurname.Text = "Record not found";
            txtAddressNo.Text = "Record not found";
            txtAddress.Text = "Record not found";
            txtPostcode.Text = "Record not found";
            txtEmail.Text = "Record not found"; ;
            txtDate.Text = "Record not found";
            txtTotalSpent.Text = "Record not found";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}