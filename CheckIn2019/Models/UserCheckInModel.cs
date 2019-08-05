using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckIn2019.Models
{
    public class UserCheckInModel
    {
        public int WarriorID { get; set; }
        public string Planet { get; set; }
        public bool isCheckedIn { get; set; }
    }
}