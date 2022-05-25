using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Clinic_Main.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Clinic_Main.DAL
{
    public class ClinicDAL
    {
        public string cnn = "";

        public ClinicDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                    (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:conn").Value;
        }
        public List<Appointment> GetAllDoctor()
        {
            List<Appointment> listAppoint = new List<Appointment>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("clAppoint", con))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listAppoint.Add(new Appointment()
                        {
                            AppointID = int.Parse(reader["AppointId"].ToString()),
                            PatientID = int.Parse(reader["PatientId"].ToString()),
                            PatientName =reader["PatientName"].ToString(),
                            Specialization = reader["Spec"].ToString(),
                            DoctorList = reader["DoctorName"].ToString(),
                            VisitDate = DateTime.Parse(reader["VisitDate"].ToString()),
                            AppointmenTime = reader["AppointTime"].ToString(),
                        });
                    }
                }
            }
            return listAppoint;
        }
        public List<Patient> PatList()
        {
            List<Patient> listAppoint = new List<Patient>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("PatList", con))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listAppoint.Add(new Patient()
                        {
                            PatientId = int.Parse(reader["PatientId"].ToString()),
                            
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["Lastname"].ToString(),
                            Sex = reader["Sex"].ToString(),
                            Age = reader["Age"].ToString(),
                            DOB = reader["DOB"].ToString(),
                        });
                    }
                }
            }
            return listAppoint;
        }
        public List<Doctor> DoctorList()
        {
            List<Doctor> listAppoint = new List<Doctor>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("specs", con))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listAppoint.Add(new Doctor()
                        {
                            DoctorId = int.Parse(reader["DoctorId"].ToString()),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Specialization = reader["Spec"].ToString(),
                            VistingHours = reader["VisitingTime"].ToString(),
                            
                        });
                    }
                }
            }
            return listAppoint;
        }
        public List<Login> users()
        {
            List<Login> listAppoint = new List<Login>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("viewuser", con))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listAppoint.Add(new Login()
                        {
                            
                            UserName= reader["UserName"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                        });
                    }
                }
            }
            return listAppoint;
        }

        public int validatelogin(Login l)
        {
            //int pass;
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("validatelogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", l.UserName);
            cmd.Parameters.AddWithValue("@password", l.Password);
            con.Open();
            IDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                return (1);
            con.Close();
            return (0);
        }
        public int InsertDoctor(Doctor l)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("InsertDoctor", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstname", l.FirstName);
            cmd.Parameters.AddWithValue("@lastname", l.LastName);
            cmd.Parameters.AddWithValue("@sex", l.Sex);
            cmd.Parameters.AddWithValue("@spec", l.Specialization);
            cmd.Parameters.AddWithValue("@visittime", l.VistingHours);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        //public int spec(Doctor d)
        //{
        //    SqlConnection con = new SqlConnection(cnn);
        //    SqlCommand cmd = new SqlCommand("specs", con);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@spec", d.Specialization);
        //    con.Open();
        //    int result = cmd.ExecuteNonQuery();
        //    con.Close();
        //    return result;
        //}
        public int InsertPatient(Patient l)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("InsertPatient", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstname", l.FirstName);
            cmd.Parameters.AddWithValue("@lastname", l.LastName);
            cmd.Parameters.AddWithValue("@sex", l.Sex);
            cmd.Parameters.AddWithValue("@age", l.Age);
            cmd.Parameters.AddWithValue("@dob", l.DOB);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int ScheduleAppoint(Appointment l)
        {
            int result;
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("SpAppoint", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@patientid", l.PatientID);
            cmd.Parameters.AddWithValue("@patientname", l.PatientName);
            cmd.Parameters.AddWithValue("@spec", l.Specialization);
            cmd.Parameters.AddWithValue("@doctorname", l.DoctorList);
            cmd.Parameters.AddWithValue("@visitdate", l.VisitDate);
            cmd.Parameters.AddWithValue("@appointtime", l.AppointmenTime);
            con.Open();
            result = cmd.ExecuteNonQuery();
            if (result==0)
            {
                return (1);
            }
            con.Close();
            return (0);
           
        }
        public int CancelByDate(string str)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("delbydate", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@visitdate", str);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }
        public int CancelAppoint(int id)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("DelAppoint", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@appointid", id);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
    }
}
