using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class DANHSACHSANPHAM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\Quanlybanhang\Quanlybanhang\WebApplication1\WebApplication1\App_Data\DbQuanlybanhang.mdf;Integrated Security=True";
            cn.Open();
            string madm = Request.QueryString.Get("MADANHMUC");
            if(madm != null)
            {
                string SQL = "select * from [tbSANPHAM] where MADANHMUC= "+ madm;
                SqlDataAdapter adp = new SqlDataAdapter(SQL, cn);
                DataTable tbSANPHAM = new DataTable();
                adp.Fill(tbSANPHAM);
                DataList1.DataSource = tbSANPHAM;
                DataList1.DataBind();
                DataList1.RepeatColumns = 3;
               
            }
            cn.Close();
        }
    }
}