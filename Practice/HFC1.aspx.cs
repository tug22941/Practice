using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice
{
    public partial class HFC1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string name = Request["txtName"];

                Response.Write("Hi " + name + ", Welcome to my Practice Examples. <br/ >");
                Response.Write("Greetings, from server-side!");
            }
        }
    }
}