﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                conTiny1.InnerText = "change pls";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Literal1.Text = conTiny1.Value;

        }
    }
}