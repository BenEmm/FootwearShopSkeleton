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
}