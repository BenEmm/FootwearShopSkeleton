using System;
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
            //Stores all the data in the session
            Session["AStock"] = AStock;
            //navigates to the stock viewer page
            Response.Redirect("StockViewer.aspx");
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