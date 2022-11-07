using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class CHITIET : System.Web.UI.Page
    {
        WebApplication1.App_Code.XuLyDuLieu xulydulieu;
        DataTable tbSANPHAM;
        protected void Page_Load(object sender, EventArgs e)
        {
            xulydulieu = new App_Code.XuLyDuLieu();
            string masanpham = Request.QueryString.Get("MSP");
            SqlParameter[] pr;
            if (masanpham != null)
                pr = new SqlParameter[] {
                   new SqlParameter("@MASANPHAM", masanpham)
               };
            else
                pr = new SqlParameter[] {
                   new SqlParameter("@MASANPHAM", DBNull.Value)
               };
             tbSANPHAM = xulydulieu.getTable("psGetChiTietSanPham", pr);
            Repeater2.DataSource = tbSANPHAM;
            Repeater2.DataBind();

            int soluong = Convert.ToInt32(tbSANPHAM.Rows[0]["SOLUONG"].ToString());
            for (int i = 1; i <= soluong; i++)
                this.drlSOLUONG.Items.Add(i.ToString());
        }

        protected void bth_GioHang_Click(object sender, EventArgs e)
        {
            Session.Timeout = 2;
            App_Code.CART cart = new App_Code.CART();
            if (tbSANPHAM != null)
        {
                String masanpham = tbSANPHAM.Rows[0]["MASANPHAM"].ToString();
                String tensanpham = tbSANPHAM.Rows[0]["TENSANPHAM"].ToString();
                double dongia = Double.Parse(tbSANPHAM.Rows[0]["DONGIA"].ToString());
                String hinhanh = tbSANPHAM.Rows[0]["HINHANH"].ToString();
                int soluong = Int16.Parse(this.drlSOLUONG.SelectedItem.Text);
                if (Session["CART"] != null)
                    cart = (App_Code.CART)Session["CART"];
                cart.AddCart(masanpham, tensanpham, hinhanh, dongia, soluong);
                Session["CART"] = cart;
                Response.Redirect("GIOHANG.aspx");

            }
        }
    }
  }  