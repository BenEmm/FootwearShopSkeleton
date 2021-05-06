using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayBrands();
        }

        
    }
    void DisplayBrands()
    {
        //create a collection of brands instance
        clsBrandCollection AllBrands = new clsBrandCollection();
        //set data source to retrieve from middle layer brandlist
        lstBrandList.DataSource = AllBrands.BrandList;
        // set name of PK
        lstBrandList.DataValueField = "BrandID";
        // set the data field to display
        lstBrandList.DataTextField = "BrandName";
        lstBrandList.DataBind();
    }

    protected void lstBrandList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into session object to show this is a new record
        Session["BrandID"] = -1;
        // redirect to data entry page
        Response.Redirect("BrandsDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store Brand ID value
        Int32 BrandID;
        // if a record has been selected
        if (lstBrandList.SelectedIndex != -1)
        {
            // get PK value of the record selected
            BrandID = Convert.ToInt32(lstBrandList.SelectedValue);
            //store the data in session object
            Session["BrandID"] = BrandID;
            // redirect to edit
            Response.Redirect("BrandsDataEntry.aspx");
        }
        else
        {
            //display error message
            lblError.Text = "Please select a record from the list.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store PK of brand to be deleted
        Int32 BrandID;
        if (lstBrandList.SelectedIndex != -1)
        {
            // get PK value of record to delete
            BrandID = Convert.ToInt32(lstBrandList.SelectedValue);
            // store data in Session
            Session["BrandID"] = BrandID;
            //redirect to delete
            Response.Redirect("BrandsConfirmDelete.aspx");
        }
        else
        {
            // display the error
            lblError.Text = "Please select a brand to delete from the list.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsBrandCollection Brands = new clsBrandCollection();
        // capture input text
        Brands.ReportByBrandName(txtBrandNameInput.Text);
        lstBrandList.DataSource = Brands.BrandList;
        //set PK name
        lstBrandList.DataValueField = "BrandID";
        lstBrandList.DataTextField = "BrandName";
        //bind data to list
        lstBrandList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // create collection
        clsBrandCollection Brands = new clsBrandCollection();
        //Clear any existing filter
        txtBrandNameInput.Text = "";
        lstBrandList.DataSource = Brands.BrandList;
        // set Pk name
        lstBrandList.DataValueField = "BrandID";
        //set name of field to display
        lstBrandList.DataTextField = "BrandName";
        // bind data to list
        lstBrandList.DataBind();
    }
}