using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.dao
{
    //internal interface IHospitalService
    //{
    //}

/* getAppointmentById()
i.Parameters: appointmentId
ii.ReturnType: Appointment object

b. getAppointmentsForPatient()
i. Parameters: patientId
ii. ReturnType: List of Appointment objects

c.getAppointmentsForDoctor()
i. Parameters: doctorId
ii. ReturnType: List of Appointment objects

d.scheduleAppointment()
i. Parameters: Appointment Object
ii.ReturnType: Boolean

e. upDateOnlyAppointment()
i. Parameters: Appointment Object
ii.ReturnType: Boolean

f. CancelAppointment()
i. Parameters: AppointmentId
ii. ReturnType: Boolean*/


    public interface IHospitalService
    {
        Appointment GetAppointmentById(int appointmentId);
        List<Appointment> GetAppointmentsForPatient(int patientId);
        List<Appointment> GetAppointmentsForDoctor(int doctorId);
        bool ScheduleAppointment(Appointment appointment);
        bool UpDateOnlyAppointment(Appointment appointment);
        bool CancelAppointment(int appointmentId);
    }
}
