using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Practice
{
    public partial class Gridview_P1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridview();
            }
        }

        public void LoadGridview()
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAllBooks";

            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);
            gvBooks.DataSource = ds;

            Session["theDataSet"] = ds;
            gvBooks.DataBind();
        }

        protected void gvBooks_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBooks.PageIndex = e.NewPageIndex;
            DataSet myDS = (DataSet)Session["theDataSet"];
            gvBooks.DataSource = myDS;
            gvBooks.DataBind();
        }
    }
}