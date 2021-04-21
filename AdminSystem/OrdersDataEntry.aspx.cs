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
        string CustomerName = txtCustomerName.Text;
        string Email = txtEmail.Text;
        string TrackingNumber = txtTrackingNo.Text;
        string TotalPrice = txtTotalPrice.Text;
        string Quantity = txtQuantity.Text;
        string ShippingDate = txtShippingDate.Text;
        string OrderNumber = txtOrderNo.Text;



        //Store customer name in the session object
        Session["AnOrder"] = AnOrder;
        //Navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();

        Int32 OrderNumber;

        Boolean Found = false;

        OrderNumber = Convert.ToInt32(txtOrderNo.Text);

        Found = AnOrder.Find(OrderNumber);

        if (Found == true)
        {
            txtCustomerName.Text = AnOrder.CustomerName;
            txtEmail.Text = AnOrder.Email;
            txtTrackingNo.Text = AnOrder.TrackingNumber;
            txtOrderNo.Text = AnOrder.OrderNumber.ToString();
            txtQuantity.Text = AnOrder.Quantity.ToString();
            txtShippingDate.Text = AnOrder.ShippingDate.ToString();
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            txtTrackingNo.Text = AnOrder.TrackingNumber;

        }

    }
}