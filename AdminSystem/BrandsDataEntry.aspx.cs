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

        string BrandName = tbName.Text;
        string TopProduct = dropTop.SelectedValue;
        string LatestProduct = dropLatest.SelectedValue;
        string LastRestock = cdrRestock.SelectedDate.ToString();

        // avgPrice property needs to be calculated from a mean of a brand's products

        //store Brand in session object
        // if valid passes
        string ErrorMsg = "";
        ErrorMsg = Brand.Valid(BrandName, TopProduct, LatestProduct, LastRestock);
        if (ErrorMsg == "")
        {
            Brand.BrandName = BrandName;
            Brand.TopProduct = int.Parse(TopProduct);
            Brand.LatestProduct = int.Parse(LatestProduct);
            Brand.LastRestock = Convert.ToDateTime(LastRestock);
            Brand.IsListed = cbList.Checked; 

            Session["Brand"] = Brand;
            Response.Write("BrandsViewer.aspx");
        }
        else
        {
            lblValidateError.Visible = true;
            lblValidateError.Text = ErrorMsg;
        }
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
            lblErrorAlert.Visible = true;
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
            lblErrorAlert.Visible = false;
        }
        else
        {
            lblErrorAlert.Visible = true;
            lblErrorAlert.Text = "Brand " + tbName.Text + " was not found in the database.";
        }

        
    }
}