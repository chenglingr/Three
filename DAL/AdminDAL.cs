using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
namespace DAL
{
   public class AdminDAL
    {
        //提供 用户名 密码  。到数据库中查询 是否存在
        /// <summary>
        /// 提供 用户名\密码,判断用户登录是否成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>登陆成功与否</returns>
        public bool isExist(string name, string pwd)
        {
            bool result = true;
            //先写sql语句
            string sql = string.Format("select top 1 adminID  FROM Admin where LoginID='{0}' and LoginPWD='{1}'", name, pwd);

            
            // public static DataSet Query(string SQLString)

            //调用访问数据库的方法。
            DataSet ds= DbHelperSQL.Query(sql);
            //判断 返回结果
            if (ds.Tables[0].Rows.Count==0)
            {
                result = false;
            }
            return result;

        }
        //增加记录
        public int add(Admin ad)
        {
            string sql="";
            int x = 1;
            if (ad.Sex == false)
            { x = 0; }

           sql = string.Format(@"INSERT INTO [Admin]
           ([LoginID]
           ,[LoginPWD]
           ,[AdminName]
           ,[sex])
     VALUES
           ('{0}','{1}','{2}' ,{3})", ad.Loginid, ad.Loginpwd, ad.AdminName, x);


            int n=  DbHelperSQL.ExecuteSql(sql);

            return n;
        }
        
    }
}
