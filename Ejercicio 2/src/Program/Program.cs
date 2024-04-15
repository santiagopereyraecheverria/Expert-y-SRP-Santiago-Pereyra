using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // No se está utilizando el identificador único para la cita, lo que podría causar problemas en la gestión y seguimiento de las citas.
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            // Al pasar cadenas vacías para el ID y el nombre del médico, no detecta estos errores, lo que podría resultar en citas incorrectas o incompletas.
            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
        }
    }
}
