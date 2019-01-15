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
        public string eventDateStart { get; set; }
        public string eventDateEnd { get; set; }
        public string eventLocation { get; set; }
        public string eventGenre { get; set; }
        public string eventMusician { get; set; }
    }
}