using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //tao socket
            Server sv = new Server();
            //lang nghe client
            sv.listen();
            //chap nhan
            sv.accept();
            //gui
            //nhan file
            sv.Nhanfile();
        }
    }
}
