using MindBoxTest.Classes;
using MindBoxTest.Structs;

namespace MindBoxTest.Tests
{
	public class TriangleTests
	{
		[Fact]
		public void CalcArea_A_negative10_0_B_10_0_C_0_15_150returned()
		{
			Point pointA = new Point(-10, 0);
			Point pointB = new Point(10, 0);
			Point pointC = new Point(0, 15);
			Side side1 = new Side(pointC, pointA);
			Side side2 = new Side(pointC, pointB);
			Side side3 = new Side(pointB, pointA);
			Side[] sides = { side1, side2, side3 };
			Base triangle = new Triangle(sides);
			double expected = 150;
			double actial = triangle.Area;
			Assert.Equal(expected, actial);
		}
		[Fact]
		public void isRectangular_A_0_0_B_15_0_C_0_15_TRUE_returned()
		{
			Point pointA = new Point(0, 0);
			Point pointB = new Point(1233, 0);
			Point pointC = new Point(0, 123);
			Side side1 = new Side(pointC, pointA);
			Side side2 = new Side(pointC, pointB);
			Side side3 = new Side(pointB, pointA);
			Side[] sides = { side1, side2, side3 };
			Base triangle = new Triangle(sides);
			bool expected = true;
			bool actial = triangle.isRectangular;
			Assert.Equal(expected, actial);
		}
	}

}