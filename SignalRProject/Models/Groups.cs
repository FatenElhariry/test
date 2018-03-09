using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRProject.Models
{
    public class Groups
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserID { get; set; }


        public List<ApplicationUser> Users { get; set; }

    }
}  