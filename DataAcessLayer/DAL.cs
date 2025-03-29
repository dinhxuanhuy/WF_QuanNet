﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public static class DAL
    {
        static string ConnStr = "Data Source=localhost;Initial Catalog=QuanLyTiemNet;Integrated Security=True";
        //static string ConnStr = "Data Source=MSI\\HUY;Initial Catalog=QuanLyTiemNet;Integrated Security=True";

        static SqlConnection conn = null;
        static SqlCommand comm = null;
        static SqlDataAdapter da = null;

        // Static constructor
        static DAL()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand(); //create command
        }

        //Khai bao ham thuc thi tang ket noi
        public static DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            comm.Parameters.Clear(); // Xóa các tham số cũ trước khi thêm mới
            comm.CommandText = strSQL;
            comm.CommandType = ct;

            if (p != null && p.Length > 0)
            {
                comm.Parameters.AddRange(p);
                foreach (var param in p)
                {
                    Console.WriteLine($"Thêm tham số: {param.ParameterName} = {param.Value}");
                }
            }

            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Close();
            return ds;
        }

        // Action Query = Insert | Delete | Update | Stored Procedure
        public static bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand comm = new SqlCommand(strSQL, conn))
                {
                    comm.CommandType = ct;
                    comm.Parameters.AddRange(param);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        f = true;
                    }
                    catch (SqlException ex)
                    {
                        error = ex.Message;
                    }
                }
            }
            return f;
        }

        public static DataTable ExecuteQueryDataTable(string sql, CommandType type, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = type;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}