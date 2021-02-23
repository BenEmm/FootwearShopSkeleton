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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //Find the customer name
        AnOrder.CustomerName = txtCustomerName.Text;
        AnOrder.Email = txtEmail.Text;
        AnOrder.TrackingNumber = txtTrackingNo.Text;
        AnOrder.TotalPrice = int.Parse(txtTotalPrice.Text);
        AnOrder.Quantity = int.Parse(txtQuantity.Text);
        AnOrder.ShippingDate = DateTime.Parse(txtShippingDate.Text);
        AnOrder.OrderNumber = int.Parse(txtOrderNo.Text);
      


        //Store customer name in the session object
        Session["AnOrder"] = AnOrder;
        //Navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }



}