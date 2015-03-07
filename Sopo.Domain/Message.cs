using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sopo.Domain
{
    class Message:BaseRecord
    {
        public MessageType MessageType { get; set; }
        public object Content { get; set; }
        public DateTime SendDate { get; set; }

        public Conversation Conversation { get; set; }
    }
}
