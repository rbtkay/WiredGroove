using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiredGroove.Classes
{
    public class Message
    {
        public string messageSender { get; set; }
        public string messageContent { get; set; }
        public string messageTimestamp { get; set; }
        public string messageSenderEmail { get; set; }
    }
}