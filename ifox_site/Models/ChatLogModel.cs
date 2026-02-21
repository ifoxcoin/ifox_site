using System.Collections.Generic;
using System;

namespace ifox_site.Models
{
    public class ChatLogModel
    {
        public string UserEmail { get; set; }
        public List<ChatMessage> Messages { get; set; }
    }

    public class ChatMessage
    {
        public string Sender { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}
