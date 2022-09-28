using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace MVCPract.DataAccessLayer.Common
{
    public static class DBCommand
    {
        public static DataTable GetData(string query) 
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query,dal.connection))
            {
                cmd.CommandType = CommandType.Text;    
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                }
            }
            dal.CloseConnection();
            
            return dt;
        }
        public static void UpDateData(string query,List<SqlParameter> parameters)
        {
            DAL dAL = new DAL();
            using (SqlCommand cmd = new SqlCommand(query,dAL.connection))
            { 
                cmd.CommandType = CommandType.Text;
                if(parameters!=null)
                {
                    parameters.ForEach( parameter => { cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                    });
                }
                cmd.ExecuteNonQuery();
            }
            dAL.CloseConnection();
        }
        public static DataTable GetDataWithConditions(string query,List<SqlParameter> parameters)
        {
            DataTable dt = new DataTable();
            DAL dAL = new DAL();
            
            using (SqlCommand cmd = new SqlCommand(query, dAL.connection))
            {
                cmd.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    parameters.ForEach(parameter =>
                    {
                        cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                    });
                }
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                }
            }
            dAL.CloseConnection();

            return dt;
        }
    }
}