using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string pwd = TextBox2.Text;
            AdminBLL bll = new AdminBLL();
            bool r=  bll.isExist(name, pwd);
            if (r == true)
            {
                Response.Redirect("ok.html");
            }
            else
            {
                Label1.Text = "错误";
            }
        }
    }
}