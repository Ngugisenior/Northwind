using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Northwind.NorthWindSetTableAdapters;

namespace Northwind
{
    public partial class Suppliers : System.Web.UI.Page
    {
        SuppliersTableAdapter suppAdapter = new SuppliersTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            SupplierGrid.DataSource = suppAdapter.GetSuppliers();
            SupplierGrid.DataBind();
        }

        protected void TxtCountry_TextChanged(object sender, EventArgs e)
        {
            if (TxtCountry.Text == "")
            {
                SupplierGrid.DataSource = suppAdapter.GetSuppliers();
                SupplierGrid.DataBind();
            }
            else
            {
                SupplierGrid.DataSource = suppAdapter.GetSuppliersByCountry(TxtCountry.Text);
                SupplierGrid.DataBind();
            }
        }
    }
}