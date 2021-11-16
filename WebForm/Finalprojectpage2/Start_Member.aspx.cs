using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace Finalprojectpage2
{
    public partial class Start_Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {

           

            Session["UserName"] = name_tb.Text.ToString();
            String Sex = sex_ddl.Text;
            switch (Sex)
            {
                case "女":
                    Sex = "小姐";
                    break;
                case "男":
                    Sex = "先生";
                    break;
            }
            Session["Sex"] = Sex;


            //Response.Write("<script>alert('歡迎加入!')</script>");




            //3
            //SqlCommand cmd = new SqlCommand("Select * From Member", cn);
            //cn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();


            // while (dr.Read())
            // {
            //     for (int i = 0; i < dr.FieldCount; i++)
            //     {
            //        Test_lb.Text += dr[i].ToString() + "   ";
            //        Test_lb.Text += "<br>";


            //     }
            // }
            //cn.Close();

            //3


            //Test

            //cmd_Add.Parameters.Add(new SqlParameter("@mId", SqlDbType.Char));
            //cmd_Add.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
            //cmd_Add.Parameters.Add(new SqlParameter("@sex", SqlDbType.NVarChar));
            //cmd_Add.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar));
            //cmd_Add.Parameters.Add(new SqlParameter("@account", SqlDbType.Char));
            //cmd_Add.Parameters.Add(new SqlParameter("@password", SqlDbType.Char));

            //cmd_Add.Parameters["@mId"].Value = 1;
            //cmd_Add.Parameters["@name"].Value = name_tb.Text;
            //cmd_Add.Parameters["@sex"].Value = sex_ddl.Text;
            //cmd_Add.Parameters["@email"].Value = mail_tb.Text;
            //cmd_Add.Parameters["@account"].Value = acc_tb.Text;
            //cmd_Add.Parameters["@password"].Value = passwd_tb.Text;

            //cmd_Add.ExecuteNonQuery();
            String str = "Data Source=(LocalDB)\\MSSQLLocalDB;" + "AttachDbFilename=" +
                     Server.MapPath("App_Data\\Database1.mdf") + ";Integrated Security=True";
            SqlConnection cn = new SqlConnection(str);



            SqlCommand cmd_check_acc = new SqlCommand("Select * From Member"
                + " Where Account ='" + acc_tb.Text + "'", cn);

            cn.Open();

            SqlDataReader dr;
            dr = cmd_check_acc.ExecuteReader();

            if(dr.Read())
            {
                Test_lb.Text = "此帳號已存在!";
               
            }
            else
            {
                Test_lb.Text = "成功創建";
                gonext();
            }


            cn.Close();
            
        }

        public void gonext()
        {
            if (check_cb.Checked != true)
            {
                OK_lb.Text = "請先詳閱網站權益事項，並打勾！";
            }
            else
            {
                String str = "Data Source=(LocalDB)\\MSSQLLocalDB;" + "AttachDbFilename=" +
                     Server.MapPath("App_Data\\Database1.mdf") + ";Integrated Security=True";
                SqlConnection cn = new SqlConnection(str);

                SqlCommand cmd_Add = new SqlCommand("Insert Into Member (Name, Sex, Email, Account, Password)"
                + " Values ('" + name_tb.Text + "','" + sex_ddl.Text + "','" + mail_tb.Text + "','" +
                acc_tb.Text + "','" + passwd_tb.Text + "')", cn);


                //SqlCommand cmd_Add = new SqlCommand("Insert Into Member (Name, Sex, Email, Account, Password)"
                //    + " Values ( 2, 1, 333, 444, 555)", cn);
                cn.Open();

                cmd_Add.ExecuteNonQuery();

                cn.Close();

                Session["UserName"] = name_tb.Text.ToString();
                Response.Redirect("Choose.aspx");
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Session["UserName"] = name_tb.Text.ToString();
            Response.Redirect("Chat.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Start_Login.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
          

        }
    }
}