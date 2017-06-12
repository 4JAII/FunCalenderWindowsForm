using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunCalenderWF
{    
    class WishListTable
    {
        public string userID { get; set; }
        public string productID { get; set; }
        public string productName { get; set;}
        public int count { get; set; }
        public DateTime date { get; set; }

        public WishListTable(string userID,string productID,string productName,int count,DateTime date) 
        {
            this.userID = userID;
            this.productID = productID;
            this.productName = productName;
            this.count = count;
            this.date = date;
        }

    
        public List<WishListTable> FormatTable(DateTime date)
        {
            var resLinq = from p in DayList.AllWishList
                      where p.date == date
                      select p;
            var res=resLinq.ToList<WishListTable>();
            return res;
        }

        public void SetListDebug()
        {
            WishListTable[] w ={new WishListTable("akimoto","001","aaa",3,DateTime.Now),new WishListTable("akimoto","002","bbb",4,DateTime.Now),new WishListTable("akimoto","003","ccc",5,new DateTime(2017,5,2)),new WishListTable("akimoto","004","ddd",6,new DateTime(2017,4,21))};
            DayList.AllWishList = w.ToList<WishListTable>();
        }
    }


}
