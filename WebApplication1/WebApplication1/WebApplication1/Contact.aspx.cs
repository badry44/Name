using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            divmess.Attributes.Add("style", "color :red;font-size: 30px;");

        }

        protected void BtnActive_Click(object sender, EventArgs e)
        {
            

        }
    }
}