using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cw.Data
{
    public class Member
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int OrderCount { get; set; }
        public bool IsRedemptionAvailable { get; set; }
        public bool IsRegular { get; set; }


    }
    internal class AllMembersList
    {
        public List<Member> AllMembers { get; set; }
        public AllMembersList()
        {
            this.AllMembers = new();
        }
    }

    


}
