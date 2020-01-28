using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            var font2 = new Font("Arial", 10.0f);
            using (font2)
            {
                font2.GetHeight();
            }
            float f = font2.GetHeight();
        }

    }   
    }
}
