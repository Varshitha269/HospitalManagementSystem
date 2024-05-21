using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    //internal class Appointment
    //{
    //}
    public class Appointment
    {
        private int appointmentId;
        private int patientId;
        private int doctorId;
        private DateOnly appointmentDate;
        private string description;

        public Appointment() { }
        public Appointment(int appointmentId, int patientId, int doctorId, DateOnly appointmentDate, string description)
        {
            this.appointmentId = appointmentId;
            this.patientId = patientId;
            this.doctorId = doctorId;
            this.appointmentDate = appointmentDate;
            this.description = description;
        }
        public int AppointmentId
        {
            get { return appointmentId; }
            set { appointmentId = value; }
        }
        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }
        public int DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }
        public DateOnly AppointmentDate
        {
            get { return appointmentDate; }
            set { appointmentDate = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public void PrintDetails()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Appointment [appointmentId={appointmentId}, patientId={patientId}, doctorId={doctorId}, appointmentDateOnly={appointmentDate.ToString("yyyy-MM-dd")}, description={description}]";
        }

    }
}
