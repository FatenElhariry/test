using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRProject.Models
{
    public class PostComments
    {
        public string UserID { get; set; }
        public int PostID { get; set; }
        public string  Text { get; set; }

        public DateTime Time { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Post Post { get; set; }

    }
}