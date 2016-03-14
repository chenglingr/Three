using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
  public  class AdminBLL
    {
        private AdminDAL dal = new AdminDAL();

        public bool isExist(string name, string pwd)
        {
          return  dal.isExist(name, pwd);
        }
        public int add(Admin ad)
        {
          return  dal.add(ad);
        }
    }
}
