using GigHubCore.Areas.Identity.Data;
using System;

namespace GigHubCore.Models
{
    public class Gig
    {
        public GigHubCoreUser Artist { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
        public Genre Genre { get; set; }
    }
}
