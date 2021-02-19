﻿using System;
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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        // Captures the customerID
        ACustomer.CustomerID = int.Parse(txtCustomerID.Text);
        // Captures the First Name
        ACustomer.FirstName = txtFirstName.Text;
        // Captures the Surname
        ACustomer.Surname = txtSurname.Text;
        // Capture the house number
        ACustomer.AddressNo = int.Parse(txtAddressNo.Text);
        // Captures the Address
        ACustomer.Address = txtAddress.Text;
        // Captures the Postcode
        ACustomer.PostCode = txtPostcode.Text;
        // Captures the Email
        ACustomer.Email = txtEmail.Text;
        // Captures the Account Creation Date 
        ACustomer.AccountCreationDate = DateTime.Parse(txtDate.Text);
        // Captures whether the person is a customer or not
        ACustomer.IsCustomer = chkConfirm.Checked;
        //Captures the total a customer has spent
        ACustomer.TotalSpent = decimal.Parse(txtTotalSpent.Text);
 // ----------------------------------------------------------------- //
        // Stores all the captured data in the session object
        Session["ACustomer"] = ACustomer;
        // Navigates to the CustomerViewer page
        Response.Redirect("CustomerViewer.aspx");
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
}