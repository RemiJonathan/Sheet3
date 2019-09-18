using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using ContactDAL;

namespace ContactBLL
{
    public class Business
    {
        public List<Contact> GetContacts()
        {
            return DB.contacts;
        }
    }
}
