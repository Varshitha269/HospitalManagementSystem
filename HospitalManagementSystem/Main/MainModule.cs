using HospitalManagementSystem.dao;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Main
{

    public class MainModule
    {
        private IHospitalServiceImpl hospital;

        public MainModule()
        {
            hospital = new HospitalServiceImpl();
        }

        public void App()
        {
            Console.WriteLine("\n\n                Hiii !!! I am an HOSPITAL MANAGEMENT SYSTEM PORTAL\n\n\n ");
            Console.WriteLine("Select the operation you want to perform: \n");
            Console.WriteLine("1. GetAppointmentById \n 2. GetAppointmentsForPatient \n 3. GetAppointmentsForDoctor \n 4. CancelAppointment \n 5. ScheduleAppointment \n ");
            Console.Write("Now You can enter your choice (1-5): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the appointment ID: ");
                    int appointmentId = Convert.ToInt32(Console.ReadLine());
                    hospital.GetAppointmentById();
                    break;
                case 2:
                    Console.Write("Enter the patient ID: ");
                    int patientId = Convert.ToInt32(Console.ReadLine());
                    hospital.GetAppointmentForPatient();
                    break;
                case 3:
                    Console.Write("Enter the doctor ID: ");
                    int doctorId = Convert.ToInt32(Console.ReadLine());
                    hospital.GetAppointmentsForDoctors();
                    break;
                case 4:
                    Console.Write("Enter the appointment ID to cancel: ");
                    int appointmentIdToCancel = Convert.ToInt32(Console.ReadLine());
                    hospital.CancelAppointment();
                    break;
                case 5:
                    Appointment newAppointment = new Appointment();
                    hospital.ScheduleAppointment();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
