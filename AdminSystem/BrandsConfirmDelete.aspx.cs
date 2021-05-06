using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 BrandID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the brand to be deleted from session obj
        BrandID = Convert.ToInt32(Session["BrandID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsBrandCollection BrandsList = new clsBrandCollection();
        // find the brand
        BrandsList.ThisBrand.Find(BrandID);
        // delete record
        BrandsList.Delete();
        // redirect back to main page
        Response.Redirect("BrandsList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("BrandsList.aspx");
    }
}