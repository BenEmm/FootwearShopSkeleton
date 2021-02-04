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
        //Creates an instance of clsStock
        clsStock AStock = new clsStock();

        //retrieves the data from the session object 
        AStock = (clsStock)Session["AStock"];

        //Display data
        Response.Write(AStock.StockID + "\n");
        Response.Write(AStock.StockDescription + "\n");
        Response.Write(AStock.StockColour + "\n");
        Response.Write(AStock.StockAmount + "\n");
        Response.Write(AStock.StockPrice + "\n");
        Response.Write(AStock.DateOrdered + "\n");
        Response.Write(AStock.Available + "\n");
    }
}