﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{

    
  public  class personBLL
    {
        private personDAL dal = new personDAL();
        public person getmodel()
        {
          return  dal.getperson();
        }

    }
}
