using AppointmentAPI.Data;
using AppointmentAPI.Models;

namespace AppointmentAPI.Services
{
    public class AppointmentService
    {
        public List<Appointment> GetAll()
        {
            return DummyData.Appointments;
        }
        public Appointment GetById(Guid id)
        {
            return DummyData.Appointments.FirstOrDefault(a => a.Id == id);
        }
        public void Add(Appointment appointment)
        {
            DummyData.Appointments.Add(appointment);
        }
        public bool Update(Guid id, Appointment updatedAppointment)
        {
            var appointment = GetById(id);
            if (appointment == null)
                return false;

            appointment.Title = updatedAppointment.Title;
            appointment.Description = updatedAppointment.Description;
            appointment.Date = updatedAppointment.Date;
            appointment.IsConfirmed = updatedAppointment.IsConfirmed;

            return true;
        }
        public bool Delete(Guid id)
        {
            var appointment = GetById(id);
            if (appointment == null)
                return false;

            DummyData.Appointments.Remove(appointment);
            return true;
        }
    }
}
