using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using WebApplication2.DAL;

namespace WebApplication2.BLL
{
    public class UsersManager
    {

        private UsersServices users = new UsersServices();
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Register(Users user)
        {

            int re = users.Register(user);
            return re;

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="loginPwd"></param>
        /// <returns></returns>
        public Users Login(string userName, string loginPwd)
        {

            return users.Login(userName, loginPwd);
        }
    }
}