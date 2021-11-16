using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalprojectpage2
{
    public partial class Chat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            name_lb.Text = Session["UserName"].ToString();
           
        }
        

        protected void send_bt_Click(object sender, EventArgs e)
        {
            String message = "<b>" + name_lb.Text + "</b>("+ DateTime.Now + "): "+ message_tb.Text;
            //message_lb.Text += message + "\r\n" + "<br>";

            Application.Lock();
            Application["mes1"] = Application["mes2"];
            Application["mes2"] = Application["mes3"];
            Application["mes3"] = Application["mes4"];
            Application["mes4"] = Application["mes5"];
            Application["mes5"] = Application["mes6"];
            Application["mes6"] = Application["mes7"];
            Application["mes7"] = Application["mes8"];
            Application["mes8"] = message;
            Application.UnLock();

            message_lb.Text = Application["mes8"] + "<br>";
            message_lb.Text += Application["mes7"] + "<br>";
            message_lb.Text += Application["mes6"] + "<br>";
            message_lb.Text += Application["mes5"] + "<br>";
            message_lb.Text += Application["mes4"] + "<br>";
            message_lb.Text += Application["mes3"] + "<br>";
            message_lb.Text += Application["mes2"] + "<br>";
            message_lb.Text += Application["mes1"] + "<br>";




        }
    }
}