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
    Int32 StockID;
    //ecent handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        StockID = Convert.ToInt32(Session["StockID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the StockList 
        clsStockCollection StockList = new clsStockCollection();
        //find the record to delete
        StockList.ThisStock.Find(StockID);
        //delete the record
        StockList.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StockList.aspx");

    }
}