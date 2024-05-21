using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    //internal class Patient
    //{
    //}
    public class Patient
    {
        private int patientId;
        private string firstName;
        private string lastName;
        private string dateofbirth;
        private string gender;
        private string contactNumber;
        private string address;

        public Patient() { }

        public Patient(int patientId, string firstName, string lastName, string DateOfBirth, string gender,
            string contactNumber, string address)
        {
            this.patientId = patientId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateofbirth = DateOfBirth;
            this.gender = gender;
            this.contactNumber = contactNumber;
            this.address = address;
        }
        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
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
        public string DateOfBirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }

        }
        public void PrintDetails()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Patient [patientId={patientId}, firstName={firstName}, lastName={lastName}, DateOfBirth={DateOfBirth}, gender={gender}, contactNumber={contactNumber}, address={address}]";
        }
    }
}
