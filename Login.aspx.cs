using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Models;
using WebApplication2.BLL;

namespace WebApplication2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private UsersManager um = new UsersManager();
        private Common comm = new Common();
        protected void btn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            //   string uname = Convert.ToString(Session["Uname"]);

            string handPhone = this.userName.Text;
            string password = this.password.Text;
            Session["handPhone"] = handPhone;
            u = um.Login(handPhone, password);

            if (u != null && u.password == password )
            {

               
                Response.Write(comm.Messbox(1, "登陆成功!", "Login.aspx"));
                Response.End();

            }

            else
            {

                //登录失败
                Response.Write(comm.Messbox(1, "登陆失败,请重新登录!", "Login.aspx"));

                Response.End();

            }
        }
    }
}