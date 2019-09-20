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

        public void Add(Contact c)
        {
            c.Id = DB.LastId++;
            c.IsActive = true;

            DB.contacts.Add(c);
        }

        public Contact Details(int id)
        {
            return DB.contacts.Where(x => x.Id == id).Single();
        }

        public void Delete(int id){
            //edit the IsActive value of Contact with same Id
            DB.contacts.Where(x => x.Id == id).Single().IsActive = false;
            
        }

    }
}
