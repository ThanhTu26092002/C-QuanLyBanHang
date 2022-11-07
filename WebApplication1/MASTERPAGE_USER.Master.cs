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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\Quanlybanhang\Quanlybanhang\WebApplication1\WebApplication1\App_Data\DbQuanlybanhang.mdf;Integrated Security=True";
            cn.Open();
            string SQL = "select * from [tbDANHMUC]";
            SqlDataAdapter adp = new SqlDataAdapter(SQL, cn);
            DataTable tbDANHMUC = new DataTable();
            adp.Fill(tbDANHMUC);
            Repeater1.DataSource = tbDANHMUC;
            Repeater1.DataBind();
        }
    }
}