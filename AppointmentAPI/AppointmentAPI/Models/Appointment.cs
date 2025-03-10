namespace AppointmentAPI.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsConfirmed { get; set; }

        public Appointment()
        {
            Id = Guid.NewGuid();// Automatic ID will be given when adding a new appointment
        }
    }
}
