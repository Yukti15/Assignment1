using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;
using NUnit.Framework;

namespace Assignment1_Test
{
    [TestFixture]
    public class Assignment1_Tests
    {
        [Test]
        public static void GetLength_inputs()
        {
            //Arrage//
            int l = 4;
            int w = 7;
            Rectangle Rectangle_test = new Rectangle(l, w);

            //Act//
            int length = Rectangle_test.GetLength();

            //Assert//
            Assert.AreEqual(length, l);
        }

        [Test]
        public void SetLength_inputs()
        {
            //Arrage//
            int l = 3;
            int w = 4;
            Rectangle Rectangle_test = new Rectangle(l, w);

            //Act//
            int length = Rectangle_test.SetLength(l);

            //Assert//
            Assert.AreEqual(length, l);
        }

        [Test]
        public void GetLength_inputs1()
        {
            //Arrage//
            int l = 5;
            int w = 8;
            Rectangle Rectangle_test = new Rectangle(l, w);

            //Act//
            int width = Rectangle_test.GetWidth();

            //Assert//
            Assert.AreEqual(width, w);
        }

        [Test]
        public void SetWidth_inputs2()
        {
            //Arrage//
            int l = 10;
            int w = 7;
            Rectangle Rectangle_test = new Rectangle(l, w);

            //Act//
            int width = Rectangle_test.SetWidth(w);

            //Assert//
            Assert.AreEqual(width, w);
        }

        [Test]
        public void GetPerimeter_inputs3()
        {
            //Arrage//
            int l = 7;
            int w = 7;
            int p = 28;
            Rectangle Rectangle_test = new Rectangle(l, w);

            //Act//
            int perimeter = Rectangle_test.Getperimeter();

            //Assert//
            Assert.AreEqual(perimeter, p);
        }

        [Test]
        public void GetArea_inputs4()
        {
            //Arrage//
            int l = 20;
            int w = 20;
            int a = 400;
            Rectangle Rectangle_test = new Rectangle(l, w);

            //Act//
            int perimeter = Rectangle_test.Getarea();

            //Assert//
            Assert.AreEqual(perimeter, a);
        }


    }
}
