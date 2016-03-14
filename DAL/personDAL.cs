using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
  public  class personDAL
    {
        public person getperson()
        {
            person p1 = new person();
            p1.Age = 18;
            p1.Name = "zhangsan";

            return p1;
        }
    }
}
