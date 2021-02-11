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
        //create a new instance of the class
        clsOrder AnOrder = new clsOrder();
        //Get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //Display the customer name on the page
        Response.Write(AnOrder.CustomerName);
        Response.Write(AnOrder.Email);
        Response.Write(AnOrder.OrderNumber);
        Response.Write(AnOrder.ShippingDate);
        Response.Write(AnOrder.TrackingNumber);
        Response.Write(AnOrder.TotalPrice);
        Response.Write(AnOrder.Quantity);
       



    }


}