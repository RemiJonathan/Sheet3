using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ContactDAL
{
    public static class DB
    {
        public static List<Contact> contacts = new List<Contact>()
        {
            new Contact(){Id = 1, FName = "Remi", LName = "Jonathan", CellNum="+1 (514) 555-6333", Notes = "High Priority Contact", IsActive=true}
        };

        public static int LastId = 1;

        
    }
}
