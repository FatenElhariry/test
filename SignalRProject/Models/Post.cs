using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRProject.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }


        public virtual List<PostComments> PostComments { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual List<ApplicationUser> UserLikes { get; set; }

    }
}