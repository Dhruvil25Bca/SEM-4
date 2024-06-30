using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3P4
{
    class book
    {
        int bookid;
        string title;
        long price;
        public void getdata(int id)
        {
            bookid= id;
        }
        public void getdata(int id,string bname)
        {
            bookid = id;
            title = bname;
        }
        public void getdata(int id, string bname,long bprice)
        {
            bookid = id;
            title = bname;
            price = bprice;
        }

        public string showdata()
        {
            string str;
            str = "bookid: "+bookid+"\ntitle: "+title+"\nprice: "+price;
            return str;
        }
    }
}
