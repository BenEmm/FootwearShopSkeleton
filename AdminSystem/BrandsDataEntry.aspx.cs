using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // PK with access from within this class
    Int32 BrandID;

    protected void Page_Load(object sender, EventArgs e)
    {
        BrandID = Convert.ToInt32(Session["BrandID"]);
        if (!IsPostBack)
        {
            if (BrandID != -1)
            {
                // display data for current record
                DisplayBrand();
            }
            
        }
    }

    protected void dropTop_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void cbList_CheckedChanged(object sender, EventArgs e)
    {
       
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // create brand instance
        clsBrand Brand = new clsBrand();
    
        // retreive field values
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
            // capture brand id
            Brand.BrandID = BrandID;

            Brand.BrandName = BrandName;
            Brand.TopProduct = int.Parse(TopProduct);
            Brand.LatestProduct = int.Parse(LatestProduct);
            Brand.LastRestock = Convert.ToDateTime(LastRestock);
            Brand.IsListed = cbList.Checked;

            // create a collection instance
            clsBrandCollection BrandList = new clsBrandCollection();
            //add
            if (Brand.BrandID == -1) 
            {
                // set ThisBrand
                BrandList.ThisBrand = Brand;
                // add record
                BrandList.Add();
            }

            // otherwise we update
            else
            {
                BrandList.ThisBrand.Find(BrandID);
                // set ThisAddress
                BrandList.ThisBrand = Brand;
                // update
                BrandList.Update();
            }
            // redirect back to list
            Response.Redirect("BrandsList.aspx");
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
        Response.Redirect("BrandsList.aspx");
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

    void DisplayBrand()
    {
        // create brand collection
        clsBrandCollection AllBrands = new clsBrandCollection();
        //find record to update
        AllBrands.ThisBrand.Find(BrandID);
        //display data for this brand
        tbBrandID.Text = AllBrands.ThisBrand.BrandID.ToString();
        tbName.Text = AllBrands.ThisBrand.BrandName.ToString();
        dropTop.SelectedIndex = AllBrands.ThisBrand.TopProduct;
        dropLatest.SelectedIndex = AllBrands.ThisBrand.LatestProduct;
        cdrRestock.SelectedDate = AllBrands.ThisBrand.LastRestock;
        cbList.Checked = AllBrands.ThisBrand.IsListed;
    }
}