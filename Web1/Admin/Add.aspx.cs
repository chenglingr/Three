using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Web
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string id1 = id.Text;
            string pwd = Password.Text;
            string real = realname.Text;
            bool sex = true;
            if (sexm.Checked) { sex = true; }
            if (sexf.Checked) { sex = false; }

           Model.Admin ad = new Model.Admin();
            ad.Adminid = 0;
            ad.Loginid = id1;
            ad.Loginpwd = pwd;
            ad.AdminName = real;
            ad.Sex = sex;

            AdminBLL bll = new AdminBLL();
            int n=  bll.add(ad);

            if (n > 0)
            {
                MessageBox.Show(this,"ok");
                Response.Redirect("../ok.html");
         
            }
        }
    }
}