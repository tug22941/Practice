﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            Response.Write("Hi " + name + ", Welcome to my WFC Practice Example. <br />");
            Response.Write("Greetings from Server-Side!");
        }
    }
}