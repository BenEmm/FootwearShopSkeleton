using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //Variable to store the primary key with page level scope
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        StockID = Convert.ToInt32(Session["StockID"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if(StockID != -1)
            {
                //displays the current data for the record
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        //create an instance of the stock list
        clsStockCollection StockList = new clsStockCollection();
        //find the record to update
        StockList.ThisStock.Find(StockID);
        //display the data for the record
        txtStockID.Text = StockList.ThisStock.StockID.ToString();
        txtStockDescription.Text = StockList.ThisStock.StockDescription.ToString();
        txtStockColour.Text = StockList.ThisStock.StockColour.ToString();
        txtStockAmount.Text = StockList.ThisStock.StockAmount.ToString();
        txtStockPrice.Text = StockList.ThisStock.StockPrice.ToString();
        chkAvailable.Checked = StockList.ThisStock.Available;
        txtDateOrdered.Text = StockList.ThisStock.DateOrdered.ToString();

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //Creates a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the description
        string stockDescription = txtStockDescription.Text;
        //capture the colour
        string stockColour = txtStockColour.Text;
        //capture the amount
        string stockAmount = txtStockAmount.Text;
        //capture the price
        string stockPrice = txtStockPrice.Text;
        //capture the date ordered
        string dateOrdered = txtDateOrdered.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(stockDescription, stockColour, stockAmount, stockPrice, dateOrdered);
        if (Error == "")
        {
            //capture the StockID
            AStock.StockID = StockID;
            //Captures the stockID data
            AStock.StockID = int.Parse(txtStockID.Text);
            //Captures the Stock description data
            AStock.StockDescription = txtStockDescription.Text;
            //Captures the Stock colour data
            AStock.StockColour = txtStockColour.Text;
            //Captures the Stock quantity data
            AStock.StockAmount = int.Parse(txtStockAmount.Text);
            //Captures the Stock price data
            AStock.StockPrice = decimal.Parse(txtStockPrice.Text);
            //Captures the date ordered data
            AStock.DateOrdered = DateTime.Parse(txtDateOrdered.Text);
            //Captures the stock availability data
            AStock.Available = chkAvailable.Checked;
            //create an new instance of the address collection 
            clsStockCollection StockList = new clsStockCollection();

            if(StockID == -1)
            {
                //set the thisstock property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update 
                StockList.ThisStock.Find(StockID);
                //set the thisstock property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }
            

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        Int32 StockID;
        Boolean Found = false;
        StockID = Convert.ToInt32(txtStockID.Text);
        Found = AStock.Find(StockID);
        if(Found == true)
        {
            txtStockDescription.Text = AStock.StockDescription;
            txtStockColour.Text = AStock.StockColour;
            txtStockAmount.Text = AStock.StockAmount.ToString();
            txtStockPrice.Text = AStock.StockPrice.ToString();
            txtDateOrdered.Text = AStock.DateOrdered.ToString();
            chkAvailable.Checked = AStock.Available;
        }

    }
}