
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Models;
using WebApplication2.BLL;

namespace WebApplication2
{
    public partial class useradd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private UsersManager um = new UsersManager();
        private Common comm = new Common();
        protected void btn_Click(object sender, EventArgs e)
        {
           
            Users u = new Users();

            u.userName = this.userName.Text;
            u.password = this.txtUpwd.Text;
           
            int res = um.Register(u);


            Response.Write(comm.Messbox(1, "注册成功!", "Login.aspx"));
            Response.End();
        }

        protected void btn_Click3(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        
    }
}
    
