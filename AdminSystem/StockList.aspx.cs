using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if(IsPostBack == false)
        {
            //Update the list box
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //create an instance of the stock description collection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to the list of stock descriptions in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "StockDescription";
        //bind the data to the list
        lstStockList.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new session record 
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited 
        Int32 StockID;
        //if a record has been selected from the list
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StockID;
        //if a record has been selected from the list
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}