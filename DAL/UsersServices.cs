using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.Data.SqlClient;
using System.Text;

namespace WebApplication2.DAL
{
    public class UsersServices
    {

        Users users = new Users();
        private DB db = new DB();
        //注册                                                                                                                                                                                                                                                                                       
        public int Register(Users user)
        {
            string sql = string.Format("INSERT INTO Users values('{0}','{1}')",  user.userName, user.password);
            SqlConnection conn = new SqlConnection(DB.connString);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                return comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public Users Login(string userName, string password)
        {

            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" select * from  Users  where userName  =@userName and password=@password");

            SqlParameter[] para = new SqlParameter[] {new SqlParameter ("@userName",userName),
                                                                             new SqlParameter ("@password",password)};
            try
            {
                // 执行查询语句
                SqlDataReader reader = db.Query(sb.ToString(), para);
                //如果检索到则返回true，否则返回false

                if (reader.Read())
                {
                  
                    Users user = new Users();
                   
                    user.password = Convert.ToString(reader["password"]);
                   
                    user.userId = Convert.ToString(reader["userId"]);
                    user.userName = Convert.ToString(reader["userName"]);
                    return user;
                }
                else
                {
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //关闭数据库连接
                db.Close();
            }
            return null;
        }
    }
}