using HospitalManagementSystem.Models;
using HospitalManagementSystem.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.dao
{
    //internal class HospitalService
    //{
    //}

    //public class HospitalService : IHospitalService
    //{
    //    public HospitalService() { }

    //    public Appointment GetAppointmentById(int appointmentId)
    //    {
    //        Appointment appointment = null;


    //    }
    //    bool IHospitalService.CancelAppointment(int appointmentId)
    //    {
    //        throw new NotImplementedException();
    //    }



    //    List<Appointment> IHospitalService.GetAppointmentsForDoctor(int doctorId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    List<Appointment> IHospitalService.GetAppointmentsForPatient(int patientId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    bool IHospitalService.ScheduleAppointment(Appointment appointment)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    bool IHospitalService.UpDateOnlyAppointment(Appointment appointment)
    //    {
    //        throw new NotImplementedException();
    //    }

    public class HospitalService : IHospitalService
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public HospitalService()
        {

            sqlConnection = new SqlConnection(DBConnection.GetConnectionString());
            cmd = new SqlCommand();
        }

        // GetAppointmentById() 
        public Appointment GetAppointmentById(int appointmentId)
        {
            cmd.Parameters.Clear();
            Appointment appointment = null;
            cmd.CommandText = "SELECT * FROM Appointment WHERE appointmentId = @appointmentId";
            cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            cmd.Connection = sqlConnection;

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                appointment = new Appointment
                {
                    AppointmentId = (int)reader["appointmentId"],
                    PatientId = (int)reader["patientId"],
                    DoctorId = (int)reader["doctorId"],
                    AppointmentDate = (DateOnly)reader["appointmentDate"],
                    Description = (string)reader["description"]
                };
            }
            cmd.Connection.Close();
            return appointment;
        }

        //GetAppointmentForPAtient()

        public List<Appointment> GetAppointmentsForPatient(int patientId) // it should return a list of appointment objects
        {
            cmd.Parameters.Clear();
            List<Appointment> appointments = new List<Appointment>();
            cmd.CommandText = "SELECT * FROM Appointment WHERE patientId = @patientId";
            cmd.Parameters.AddWithValue("@patientId", patientId);
            cmd.Connection = sqlConnection;
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appointments.Add(new Appointment
                {
                    AppointmentId = (int)reader["appointmentId"],
                    PatientId = (int)reader["patientId"],
                    DoctorId = (int)reader["doctorId"],
                    AppointmentDate = (DateOnly)reader["appointmentDate"],
                    Description = (string)reader["description"]
                });
            }
            cmd.Connection.Close();
            return appointments;
        }

        // GetAppointmentsForDoctor

        public List<Appointment> GetAppointmentsForDoctor(int doctorId)
        {
            cmd.Parameters.Clear();
            List<Appointment> appointments = new List<Appointment>();
            cmd.CommandText = "SELECT * FROM Appointment WHERE doctorId = @doctorId";
            cmd.Parameters.AddWithValue("@doctorId", doctorId);
            cmd.Connection = sqlConnection;

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appointments.Add(new Appointment
                {
                    AppointmentId = (int)reader["appointmentId"],
                    PatientId = (int)reader["patientId"],
                    DoctorId = (int)reader["doctorId"],
                    AppointmentDate = (DateOnly)reader["appointmentDate"],
                    Description = (string)reader["description"]
                });
            }
            cmd.Connection.Close();
            return appointments;
        }

        //ScheduleAppointment()

        public bool ScheduleAppointment(Appointment appointment)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO Appointment (patientId, doctorId, appointmentDate, description) VALUES (@patientId, @doctorId, @appointmentDate, @description)";
            cmd.Parameters.AddWithValue("@patientId", appointment.PatientId);
            cmd.Parameters.AddWithValue("@patientId", appointment.PatientId);
            cmd.Parameters.AddWithValue("@doctorId", appointment.DoctorId);
            cmd.Parameters.AddWithValue("@appointmentDateOnly", appointment.AppointmentDate);
            cmd.Parameters.AddWithValue("@description", appointment.Description);
            cmd.Connection = sqlConnection;
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }

      

        //UpDateOnlyAppointment()

        public bool UpDateOnlyAppointment(Appointment appointment)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = " UPDateOnly Appointment SET patientId = @patientId, doctorId = @doctorId, appointmentDate = @appointmentDate, description = @description WHERE appointmentId = @appointmentId";
            cmd.Parameters.AddWithValue("@appointmentId", appointment.AppointmentId);
            cmd.Parameters.AddWithValue("@patientId", appointment.PatientId);
            cmd.Parameters.AddWithValue("@doctorId", appointment.DoctorId);
            cmd.Parameters.AddWithValue("@appointmentDateOnly", appointment.AppointmentDate);
            cmd.Parameters.AddWithValue("@description", appointment.Description);
            cmd.Connection = sqlConnection;
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }


        //CancelAppointment()

        public bool CancelAppointment(int appointmentId)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "DELETE FROM Appointment WHERE appointmentId=@appointmentId";
            cmd.Parameters.AddWithValue("appointmentId", appointmentId);
            cmd.Connection = sqlConnection;
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        }
    }


