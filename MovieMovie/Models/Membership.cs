using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMovie.Models
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public string MembershipType { get; set; }
        public int MembershipDiscount { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonth { get; set; }
    }
}