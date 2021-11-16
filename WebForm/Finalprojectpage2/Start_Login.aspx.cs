using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalprojectpage2
{
    public partial class Start_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(User.Identity.Name))
                this.Label1.Text = User.Identity.Name;
            else
                Response.Redirect("Start_Member.aspx");

        }

        protected void register_bt_Click(object sender, EventArgs e)
        {
            Response.Redirect("Start_Member.aspx");
        }
        int c = 0;
        protected void login_bt_Click(object sender, EventArgs e)
        {

            
            if (acc_tb.Text == "" && password_tb.Text == "")
            {
                Session["UserName"] = "遊客";
                //Response.Redirect("Chat.aspx");
                Response.Redirect("Choose.aspx");
               
            }
            else
            {
                String str = "Data Source=(LocalDB)\\MSSQLLocalDB;" + "AttachDbFilename=" +
                      Server.MapPath("App_Data\\Database1.mdf") + ";Integrated Security=True";
                SqlConnection cn = new SqlConnection(str);


                //3
                SqlCommand login_cm = new SqlCommand("Select * From Member where Account in ('" 
                    + acc_tb.Text + "') and password in ('" + password_tb.Text + "')", cn); 

                cn.Open();

                SqlDataReader dr;
                dr = login_cm.ExecuteReader();

                if (dr.Read())
                {
                    test.Text = "登入成功!";
                    Session["UserName"] = dr[1].ToString();
                    Response.Redirect("Choose.aspx");

                }
                else
                {
                    test.Text = "登入失敗! 請確認您的帳號密碼是否正確!";
                    
                }

            }
            
        }
    }
}