namespace GigHubNext.Models
{
    public class Attendance
    {
        public Gig Gig { get; set; }

        public GigUser Attendee { get; set; }

        public int GigId { get; set; }

        public string AttendeeId { get; set; }
    }
}
