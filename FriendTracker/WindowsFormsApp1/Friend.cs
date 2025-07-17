using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendTracker
{
    public class Friend
    {
        public string Name { get; set; }
        public int Score { get; set; } = 0;
        public string LastContact { get; set; } = null;
    }

}
