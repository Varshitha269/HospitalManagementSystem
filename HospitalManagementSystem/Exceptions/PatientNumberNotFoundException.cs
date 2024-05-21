using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Exceptions
{
   
    public class PatientNumberNotFoundException : Exception
    {
        public PatientNumberNotFoundException() 
        {
        }
        public PatientNumberNotFoundException(string msg) : base(msg)
        {
        }
        public PatientNumberNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
