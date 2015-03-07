using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sopo.Domain
{
    class Conversation
    {
        public int ID { get; set; }
        public User Partner { get; set; }
        public Chat Chat { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
