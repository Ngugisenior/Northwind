using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Northwind
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_itemDeleted(object sender, DetailsViewDeletedEventArgs e)
        {
            GridProduct.DataBind();
        }

        protected void DetailsView1_itemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            GridProduct.DataBind();
        }

        protected void DetailsView1_itemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            GridProduct.DataBind();
        }

        protected void InsertProduct_Click(object sender, EventArgs e)
        {
            DetailsView1.ChangeMode(DetailsViewMode.Insert);
        }
    }
}