using HospitalManagementSystem.Exceptions;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.dao
{
  
    public class HospitalServiceImpl : IHospitalServiceImpl
    {
        readonly IHospitalService hospital;

        public HospitalServiceImpl()
        {
            hospital = new HospitalService();
        }

        public void GetAppointmentById()
        {
            Console.WriteLine("Hiii !! This is Getting Appointment by Id\n");
            Console.Write("Enter the Appointment Id: ");
            int appointmentId = Convert.ToInt32(Console.ReadLine());
            Appointment appointment = hospital.GetAppointmentById(appointmentId);
            if (appointment != null)
            {
                Console.WriteLine("Appointment Details:");
                Console.WriteLine($"Appointment ID: {appointment.AppointmentId}");
                Console.WriteLine($"Patient ID: {appointment.PatientId}");
                Console.WriteLine($"Doctor ID: {appointment.DoctorId}");
                Console.WriteLine($"Appointment DateOnly: {appointment.AppointmentDate}");
                Console.WriteLine($"Description: {appointment.Description}");
            }
            else
            {
                Console.WriteLine($"No appointment found with ID: {appointmentId}");
            }
        }
    
        public void GetAppointmentForPatient()
        {
            try
            {
                Appointment appointment = new Appointment();
                Console.WriteLine("Hiii !! this is Getting Appointment For Patients  ");
                Console.WriteLine(" Enter the details :");
                Console.WriteLine("Enter Patient ID:");
                int patientId = Convert.ToInt32(Console.ReadLine());


                List<Appointment> patientAppointments = hospital.GetAppointmentsForDoctor(patientId);
                Console.WriteLine("Appointments for Patients:");
                foreach (Appointment item in patientAppointments)
                {
                    Console.WriteLine(item);
                }
            }
            catch (PatientNumberNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public void GetAppointmentsForDoctors()
        {
            Appointment appointment = new Appointment();
            Console.WriteLine("This is getting appointment for doctors ");
            Console.WriteLine("Enter the details : ");
            Console.WriteLine("Enter doctor ID:");
            int doctorId = Convert.ToInt32(Console.ReadLine());
            List<Appointment> doctorAppointments = hospital.GetAppointmentsForDoctor(doctorId);
            Console.WriteLine("Appointments for Doctor:");
            foreach (Appointment item in doctorAppointments)
            {
                Console.WriteLine(item);
            }
        }
        public void ScheduleAppointment()
        { 
            Console.WriteLine("Enter patient ID:");
            int patientId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter doctor ID:");
            int doctorId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter appointment Date (yyyy-MM-dd)");
            DateOnly appointmentDateOnly = DateOnly.Parse(Console.ReadLine());




            Console.WriteLine("Enter description:");
            string description = Convert.ToString(Console.ReadLine());
            Appointment appointment = new Appointment();
            bool isScheduled = hospital.ScheduleAppointment(appointment);
            if (isScheduled)
            {
                Console.WriteLine("Appointment successfully scheduled.");
            }
            else
            {
                Console.WriteLine("Failed to schedule the appointment.");
            }
        }

        public void CancelAppointment()
        {
            Console.WriteLine("Enter appointment ID to cancel:");
            int appointmentId = Convert.ToInt32(Console.ReadLine());
            bool isCancelled = hospital.CancelAppointment(appointmentId);
            if (isCancelled)
            {
                Console.WriteLine("Appointment successfully cancelled.");
            }
            else
            {
                Console.WriteLine("Failed to cancel the appointment. Appointment ID may not exist.");
            }
        }
    }
}
