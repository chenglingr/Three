using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Admin
    {
        private int adminid;
        private string loginid;
        private string loginpwd;
        private string adminName;
        private bool sex;

        public int Adminid
        {
            get
            {
                return adminid;
            }

            set
            {
                adminid = value;
            }
        }

        public string Loginid
        {
            get
            {
                return loginid;
            }

            set
            {
                loginid = value;
            }
        }

        public string Loginpwd
        {
            get
            {
                return loginpwd;
            }

            set
            {
                loginpwd = value;
            }
        }

        public string AdminName
        {
            get
            {
                return adminName;
            }

            set
            {
                adminName = value;
            }
        }

        public bool Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }
    }
}
