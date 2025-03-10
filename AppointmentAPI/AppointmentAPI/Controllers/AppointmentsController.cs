using AppointmentAPI.Models;
using AppointmentAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController:ControllerBase
    {
        private readonly AppointmentService appointmentService;
        public AppointmentsController()
        {
            appointmentService = new AppointmentService();
        }
      
        [HttpGet]
        public ActionResult<List<Appointment>> GetAll()
        {
            return Ok(appointmentService.GetAll());
        }
        // ID'ye göre randevu getir
        [HttpGet("{id}")]
        public ActionResult<Appointment> GetById(Guid id)
        {
            var appointment = appointmentService.GetById(id);
            if (appointment == null)
                return NotFound("Randevu bulunamadı.");

            return Ok(appointment);
        }
       
        [HttpPost]
        public ActionResult Add(Appointment appointment)
        {
            appointmentService.Add(appointment);
            return CreatedAtAction(nameof(GetById), new { id = appointment.Id }, appointment);
        }


        [HttpPut("{id}")]
        public ActionResult Update(Guid id, Appointment updatedAppointment)
        {
            var result = appointmentService.Update(id, updatedAppointment);
            if (!result)
                return NotFound("Güncellenecek randevu bulunamadı.");

            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var result = appointmentService.Delete(id);
            if (!result)
                return NotFound("Silinecek randevu bulunamadı.");

            return NoContent();
        }
    }
}
