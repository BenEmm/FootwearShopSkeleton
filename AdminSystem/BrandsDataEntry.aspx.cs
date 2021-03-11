using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{

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
        clsBrand Brand = new clsBrand();

        // BrandID set by database (maybe)

        Brand.BrandName = tbName.Text;
        Brand.TopProduct = int.Parse(dropTop.SelectedValue);
        Brand.LatestProduct = int.Parse(dropLatest.SelectedValue);
        Brand.LastRestock = cdrRestock.SelectedDate;
        Brand.IsListed = cbList.Checked;

        // avgPrice property needs to be calculated from a mean of a brand's products

        //store Brand in session object
        Session["Brand"] = Brand;
        Response.Redirect("BrandsViewer.aspx");
    }

    protected void cdrRestock_SelectionChanged(object sender, EventArgs e)
    {
        
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnShowCalendar_click(object sender, EventArgs e)
    {
        cdrRestock.Visible = true;
    }

    protected void btnFind_Click(object sender, EventArgs e) 
    {
        clsBrand brand = new clsBrand();
        // variable to store PK
        Int32 BrandId;
        // var to store return value of Find()
        Boolean Found = false;

        //Get PK from user input as Int32 obj
        try
        {
            BrandId = Convert.ToInt32(tbBrandID.Text);
            Found = brand.Find(BrandId);
        }
        catch (Exception)
        {
            lblErrorAlert.Text = "Invalid Brand ID: This field must be a positive integer.";
            return;
        }

        if (Found)
        {
            // set the properties of the found brand to appear in the data form
            tbName.Text = brand.BrandName;
            dropTop.SelectedValue = brand.TopProduct.ToString();
            dropLatest.SelectedValue = brand.LatestProduct.ToString();
            cdrRestock.SelectedDate = brand.LastRestock;
            cdrRestock.Visible = true;
            lblSelectedDate.Text = brand.LastRestock.ToString("dd/MM/yyyy");
            cbList.Checked = brand.IsListed;
            lblErrorAlert.Text = "";
        }
        else
        {
            lblErrorAlert.Text = "Brand " + tbName.Text + " was not found in the database.";
        }
    }
}