using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K010Lib
{
    [TestFixture]
    public class Class1
    {
        int age;
        string name;
        string email;

        enum Mua { Xuan=1, Ha=2, Thu=3, Dong=4};


        [Test]
        public void TinhCong()
        {
            int a = 20;
            int b = 20;
            bool c = (a>=b);

            bool d1 = false;
            bool d2 = false;
            bool d3 = !d1;

            Console.WriteLine("c = " + d3);
        }


        [Test]
        public void CauLenhIf()
        {
            int Diem = 40;
            if (Diem >= 85)
            {
                Console.WriteLine("Xếp loại giỏi");
            }   
            else if (Diem >= 70)
            {
                Console.WriteLine("Xếp loại Khá");
            }
            else if (Diem >= 50)
            {
                Console.WriteLine("Xếp loại Trung bình");
            }
            else
            {
                Console.WriteLine("Xếp loại yếu");
            }    
        }


    }
}
