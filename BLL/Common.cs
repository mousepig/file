using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;


namespace WebApplication2.BLL
{
    public class Common
    {
        public string Htmlcnt(string str)
        {
            //string htcnt = HttpContext.Current.Server.HtmlEncode(str);
            str = str.Replace("&", "&amp;");
            str = str.Replace(" ", "&nbsp;");
            str = str.Replace("<", "&lt");
            str = str.Replace(">", "&gt");
            str = str.Replace("'", "＇");
            str = str.Replace("\n", "<br>");
            return str;

        }
        public string Messbox(int tmer, string meserr, string urlname)
        {
            return "<meta http-equiv='refresh' content='" + tmer + ";URL=" + urlname + "' /><BR><BR><BR><BR><BR><center>" + meserr + "正在自动跳转," + "<a href='" + urlname + "'>手动</a>　！";
        }
        public Boolean Isnumeric(string str)
        {
            if (Regex.IsMatch(str, @"^\d+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}