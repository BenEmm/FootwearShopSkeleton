using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // private DateTime date;
    private bool listed = false;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void dropTop_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void cbList_CheckedChanged(object sender, EventArgs e)
    {
       
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        /*
        DateTime date = cdrRestock.SelectedDate;
        int day = date.Day;
        int month = date.Month;
        int year = date.Year;
        string name = tbName.Text;
        int topProduct = Convert.ToInt32(dropTop.SelectedValue);
        int latestProduct = Convert.ToInt32(dropLatest.SelectedValue);
        bool listBrandIsChecked = cbList.Checked;
        clsBrand brand = new clsBrand(name, topProduct, latestProduct, new DateTime(year, month, day), listBrandIsChecked); */
        clsBrand Brand = new clsBrand();
        Brand.BrandName = tbName.Text;
        //store Brand in session object
        Session["Brand"] = Brand;
        Response.Redirect("BrandsViewer.aspx");
    }

    protected void cdrRestock_SelectionChanged(object sender, EventArgs e)
    {
        // date = cdrRestock.SelectedDate;
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}