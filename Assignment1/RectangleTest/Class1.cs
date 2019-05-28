using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment1;

namespace RectangleTest
{
    [TestFixture]
    class RectangleTests
    {
        [Test]
        public void GetLength_Input5_expectedLengthEquals5()
        {

            //Arrange

            int l = 5;
            int w = 1;  
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
       
            int length = testRectangle.GetLength();

            //Assert

            Assert.AreEqual(l, length);
        }
        [Test]
        public void SetLength_Input6_expectedLengthEquals6()
        {

            //Arrange

            int l = 6;
            int w = 1;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act

            int length = testRectangle.SetLength(l);

            //Assert

            Assert.AreEqual(l, length);
        }
        [Test]
        public void GetWidth_Input7_expectedWidthEquals7()
        {

            //Arrange

            int l = 1;
            int w = 7;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act

            int width = testRectangle.GetWidth();

            //Assert

            Assert.AreEqual(w, width);
        }
        [Test]
        public void SetWidth_Input9_expectedWidthEquals9()
        {

            //Arrange

            int l = 1;
            int w = 9;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act

            int width = testRectangle.SetWidth(w);

            //Assert

            Assert.AreEqual(w, width);
        }
        
        [Test]
        public void GetPerimeter_Input3and5_expectedPerimeterEquals16()
        {

            //Arrange

            int l = 3;
            int w = 5;
            int expectedResult = (l * 2) + (w * 2);
            Rectangle testRectangle = new Rectangle(l, w);

            //Act

            int actualResult = testRectangle.GetPerimeter();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetArea_Input2and5_expectedAreaEquals10()
        {

            //Arrange

            int l = 2;
            int w = 5;
            int expectedResult = l * w;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act

            int actualResult = testRectangle.GetArea();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}