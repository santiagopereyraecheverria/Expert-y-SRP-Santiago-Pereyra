public class AppointmentService
{
    public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
    {
        AppointmentValidator validator = new AppointmentValidator();
        if (!validator.ValidateAppointmentData(name, id, phoneNumber, appointmentPlace, doctorName))
        {
            return "Unable to schedule appointment, some data is missing or invalid";
        }

        
        string appointmentId = Guid.NewGuid().ToString();

        
        MedicalAppointment appointment = new MedicalAppointment(name, id, phoneNumber, date, appointmentPlace, doctorName, appointmentId);

        return "Appointment scheduled successfully";
    }
}
