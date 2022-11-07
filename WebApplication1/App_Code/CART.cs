using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Code
{
    public class CART
    {
        Dictionary<String, ITEM> listcarts;
        public Dictionary<string, ITEM> LISTCARTTS
        {
            get { return this.listcarts;  }
        }
    public  CART()
        {
            listcarts = new Dictionary<string, ITEM>();
        }
    public void AddCart(String masanpham, string tensanpham, string hinhanh, double dongia, int soluong)
        {
            ITEM item = new ITEM(masanpham, tensanpham, hinhanh, dongia, soluong);
            if (listcarts.ContainsKey(item.MASANPHAM))
                listcarts[item.MASANPHAM].SOLUONG += item.SOLUONG;
            else
                listcarts.Add(item.MASANPHAM, item);
    
        }
    public void RemoveCart(String masanpham)
        {
            listcarts.Remove(masanpham);
        }
    public double TotalBill()
        {
            double total = 0;
            foreach (ITEM item in listcarts.Values)
                total += item.SOLUONG * item.DONGIA;
            return total;
        }
    }
}