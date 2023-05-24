using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using DTO_BanHang;
using System.Security.Cryptography;

namespace DAL_BanHang
{
   public class DataProvider
    {
        public static SqlConnection cnn;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;

        public static void moKetNoi()
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["ketnoi"].ToString();
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
            };
        }
        public static void dongKetNoi()
        {
            cnn.Close();
        }
        //Lấy dữ liệu
        public static DataTable getTable(string sql)
        {
            moKetNoi();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, cnn);
            da.Fill(dt);
            dongKetNoi();
            //da.Dispose();
            return dt;
        }
        //Check MaSP
        public static bool checkMaSp(string sql)
        {
            int i = 0;
            moKetNoi();
            cmd = new SqlCommand(sql, cnn);
            i = (int)cmd.ExecuteScalar();
            dongKetNoi();
            return i == 0;
        }
        //Cập nhật dữ liệu
        public static bool updateData(string sql, string[] name = null, object[] value = null)
        {
            try
            {
                moKetNoi();
                cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.Clear();
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                        cmd.Parameters.AddWithValue(name[i], value[i]);
                }

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dongKetNoi();
            }
            return false;

        }
        
      
        
    }
}
