using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw.Data
{
    internal class Staff
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
    }

    internal class AllStaffsList
    {
        public List<Staff> AllStaffs { get; set; }
        public AllStaffsList()
        {
            this.AllStaffs = new();
        }
    }
}

