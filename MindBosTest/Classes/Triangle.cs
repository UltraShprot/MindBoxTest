using MindBoxTest.Structs;

namespace MindBoxTest.Classes
{
	public class Triangle : Base
	{
		private readonly Side[] _sides;

		public Triangle(Side[] sides)
		{
			_sides = sides;
			if (sides.Length == 3) Area = CalcArea();
			else throw new ArgumentException("triangle does not exist");
		}
		protected sealed override double CalcArea()
		{
			double a = _sides[0].Length;
			double b = _sides[1].Length;
			double c = _sides[2].Length;
			double p, S;
			if (!(a < b + c || b < a + c || c < a + b))
			{
				throw new ArgumentException("triangle does not exist");
			}
			p = (a + b + c) / 2;
			S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			if (Math.Round(a * a + b * b, 10) == Math.Round(c * c, 10) ||
				Math.Round(a * a + c * c, 10) == Math.Round(b * b, 10) ||
				Math.Round(b * b + c * c, 10) == Math.Round(a * a, 10))
			{
				isRectangular = true;
			}
			return S;
		}
	}
}
