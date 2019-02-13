using GigHubNext.Models;
using System;
using System.Collections.Generic;

namespace GigHubNext.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public DateTime DateTime => DateTime.Parse($"{Date} {Time}");
        public IEnumerable<Genre> Genres { get; set; }
    }
}
