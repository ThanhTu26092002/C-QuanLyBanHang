using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class GIOHANG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!IsPostBack)
            {
                LoadCart();
            }

        }
        public void LoadCart()
        {
            try
            {
            App_Code.CART cart = (App_Code.CART)Session["CART"];
            this.grvCART.DataSource = cart.LISTCARTTS.Values.ToList();
            this.grvCART.DataBind();
            this.grvCART.FooterRow.Cells[0].Text = "Tổng tiền =";
            this.grvCART.FooterRow.Cells[4].Text = cart.TotalBill().ToString();
        }
            catch (Exception e)
            {

            }
        }


        protected void btn_RemoveItem_Click1(object sender, EventArgs e)
        {
            if ((App_Code.CART)Session["CART"] != null)
            {
                App_Code.CART cart = (App_Code.CART)Session["Cart"];
                foreach (GridViewRow row in grvCART.Rows)
                {
                    CheckBox checkbox = (CheckBox)row.FindControl("ckbREMOVEITEM");
                    if (checkbox.Checked)
                    {
                        String masanpham = row.Cells[0].Text;
                        cart.RemoveCart(masanpham);
                    }
                }
                Session["CART"] = cart;
                LoadCart();
            }
            else
            {
                Response.Redirect("pageDANHSACHSANPHAM.aspx");
            }
        }

    }
 }
