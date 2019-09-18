using ContactBLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sheet3.Models
{
    public class Model
    {
        private Business bll = new Business();
        public List<Contact> GetList()
        {
            return bll.GetContacts();
        }
    }
}