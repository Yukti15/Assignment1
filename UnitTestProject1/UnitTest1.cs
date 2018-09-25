using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class Assignment1_Tests
    {
        [Test]
        public void GetLength_input3_expectedLengthEquals3()
        {
            //Arrage
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }

        [Test]
        public void SetLength_input3_expectedSetLengthEquals3()
        {
            //Arrage
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetLength(l);

            //Assert
            Assert.AreEqual(length, l);
        }

        [Test]
        public void GetLength_input4_expectedWidthEquals4()
        {
            //Arrage
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);
        }

        [Test]
        public void SetWidth_input10_expectedSetWidthEquals10()
        {
            //Arrage
            int l = 5;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.SetWidth(w);

            //Assert
            Assert.AreEqual(width, w);
        }

        [Test]
        public void GetPerimeter_input10_expectedPerimeterEquals40()
        {
            //Arrage
            int l = 5;
            int w = 5;
            int p = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(perimeter, p);
        }

        [Test]
        public void GetArea_input10_expectedAreaEquals100()
        {
            //Arrage
            int l = 10;
            int w = 10;
            int a = 100;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int perimeter = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(perimeter, a);
        }


    }
}
