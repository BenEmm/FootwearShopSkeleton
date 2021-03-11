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
}