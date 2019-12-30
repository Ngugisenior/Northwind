using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Northwind
{
    public partial class ProductsByCategory : System.Web.UI.Page
    {
        private NorthwindEntities entities = new NorthwindEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DrpCategory.DataSource = entities.Categories.ToList();
                DrpCategory.DataTextField = "CategoryName";
                DrpCategory.DataValueField = "CategoryID";
                DrpCategory.DataBind();
            }
        }

        protected void DrpCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedID = int.Parse(DrpCategory.SelectedValue);

            if(selectedID == -1)
            {
                GridProducts.DataSource = null;
            }
            else
            {
                //filter the products belonging to the selected category
                var products = from product in entities.Products
                               where product.CategoryID == selectedID
                               select new
                               {
                                   Name = product.ProductName,
                                   Quantity_unit = product.QuantityPerUnit,
                                   Stock = product.UnitsInStock
                               };
                GridProducts.DataSource = products.ToArray();
            }
            GridProducts.DataBind();
        }
    }
}