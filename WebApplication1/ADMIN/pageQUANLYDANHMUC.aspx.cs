using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1.ADMIN
{
    public partial class pageQUANLYDANHMUC : System.Web.UI.Page
    {
        App_Code.XuLyDuLieu xulydulieu;
        public void LoadDanhMuc()
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MADANHMUC", DBNull.Value);
            this.grvDANHMUC.DataSource = xulydulieu.getTable("psGetDanhMuc", pr);
            this.grvDANHMUC.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            xulydulieu = new App_Code.XuLyDuLieu();
            LoadDanhMuc();

        }

        protected void grvDANHMUC_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grvDANHMUC.PageIndex = e.NewPageIndex;
            LoadDanhMuc();
        }

        protected void btn_luu_Click(object sender, EventArgs e)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@TENDANHMUC", txtTenDanhMuc.Text);
            int k = xulydulieu.ExeCute("psAddDanhmuc", pr);
            LoadDanhMuc();
        }
    }
}