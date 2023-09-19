namespace MindBoxTest.Classes
{
	public class Circle : Base
	{
		private readonly double _radius;
		public Circle(double radius)
		{
			_radius = radius;
			Area = CalcArea();
		}
		protected sealed override double CalcArea()
		{
			return _radius > 0 ? Math.Pow(_radius, 2) * Math.PI : throw new ArgumentException("Radius cannot be less than 0 or equal 0!");
		}
	}
}
