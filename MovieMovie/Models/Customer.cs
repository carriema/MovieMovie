using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMovie.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscrib { get; set; }
        public byte MembershipId { get; set; }
        public Membership Membership { get; set; }
        public DateTime? Birthday { get; set; }
    }
}