using ClassLibrary;
using System;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsBrand Brand = new clsBrand();
        Brand = (clsBrand) Session["Brand"];
        Response.Write(Brand.BrandName);
    }

    
}