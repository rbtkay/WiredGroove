using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiredGroove.Classes
{
    public class Event
    {
        public string eventName { get; set; }
        public string eventType { get; set; }
        public DateTime eventDateStart { get; set; }
        public DateTime eventDateEnd { get; set; }
        public string eventLocation { get; set; }
    }
}