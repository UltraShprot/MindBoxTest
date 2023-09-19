using MindBoxTest.Classes;
using MindBoxTest.Structs;

namespace MindBoxTest.Tests
{
	public class CircleTests
	{
		[Fact]
		public void CalcArea_10_314returned()
		{
			double radius = 10;
			double expected = Math.PI * 100;
			Base circle = new Circle(radius);
			double actial = circle.Area;
			Assert.Equal(expected, actial);
		}
	}
}