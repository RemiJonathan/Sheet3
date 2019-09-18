using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string CellNum { get; set; }
        public string HomeNum { get; set; }
        public string WorkNum { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
    }
}
