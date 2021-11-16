using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalprojectpage2
{
    public partial class Choose : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Chat.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("QA_Item.aspx");
        }
    }
}