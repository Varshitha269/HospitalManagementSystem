using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    //internal class Doctor
    //{
    //}
    public class Doctor
    {
        private int doctorId;
        private string firstName;
        private string lastName;
        private string specialization;
        private string contactNumber;

        public Doctor() { }

        public Doctor(int doctorId, string firstName, string lastName, string specialization, string contactNumber)
        {
            this.doctorId = doctorId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.specialization = specialization;
            this.contactNumber = contactNumber;
        }

        public int DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        public void PrintDetails()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Doctor [doctorId={doctorId}, firstName={firstName}, lastName={lastName}, specialization={specialization}, contactNumber={contactNumber}]";
        }
    }
}
