using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.App_Code
{
    public class XuLyDuLieu
    {
        SqlConnection con;
        public XuLyDuLieu()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\Quanlybanhang\Quanlybanhang\WebApplication1\WebApplication1\App_Data\DbQuanlybanhang.mdf;Integrated Security=True";

        }

        private void MoKetNoi()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        private void DongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public DataTable getTable(String SQL)
        {
            MoKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, con);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            DongKetNoi();
            return tb;
        }

        public DataTable getTable(String nameprocedurce, SqlParameter[] pr)
        {
            MoKetNoi();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedurce;
            if (pr != null)
                cmd.Parameters.AddRange(pr);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(tb);
            DongKetNoi();
            return tb;
        }

        public void getDataSet(ref DataSet ds, String SQL)
        {
            ds.Tables.Add(this.getTable(SQL));
        }

        public void getDataSet(ref DataSet ds, String nameprocedurce, SqlParameter[] pr)
        {
            ds.Tables.Add(this.getTable(nameprocedurce, pr));
        }

        public int ExeCute(string SQL)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(SQL, this.con);
            this.DongKetNoi();
            int k = (int)cmd.ExecuteNonQuery();
            return k;
        }

        public int ExeCute(String nameprocedurce, SqlParameter[] pr)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedurce;
            if (pr != null)
                cmd.Parameters.AddRange(pr);
            DongKetNoi();
            int k = (int)cmd.ExecuteNonQuery();
            return k;
        }
    }
}