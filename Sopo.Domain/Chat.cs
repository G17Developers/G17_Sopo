using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain
{
    class Chat : BaseRecord
    {
        public ICollection<Conversation> Conversations { get; set; }
        public User User { get; set; }
    }
}
