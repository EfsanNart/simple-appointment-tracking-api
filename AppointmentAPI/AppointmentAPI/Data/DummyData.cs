using AppointmentAPI.Models;

namespace AppointmentAPI.Data
{
    public class DummyData
    {
        public static List<Appointment> Appointments { get; } = new List<Appointment>
        {
            new Appointment
            {
                Title = "Diş Hekimi Randevusu",
                Description = "Dişlerimi kontrol ettirmek için randevu aldım.",
                Date = new DateTime(2021, 8, 1),
                IsConfirmed = true
            },
            new Appointment {
                Title = "Doktor Randevusu",
                Description = "Genel sağlık kontrolü için doktora gideceğim.",
                Date = new DateTime(2021, 8, 2),
                IsConfirmed = false
            },
        };
    }
}
