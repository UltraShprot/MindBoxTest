namespace MindBoxTest.Structs
{
	public struct Side
    {
        private double _length = 0;
        private Point _pointA;
        private Point _pointB;
        public double Length { get { return _length;}}
        public Side(Point A, Point B)
        {
            _pointA = A;
            _pointB = B;
            _length = CalcLength();
        }
        private double CalcLength()
        {
            return Math.Sqrt(Math.Pow(_pointA.X -  _pointB.X, 2) + Math.Pow(_pointA.Y - _pointB.Y, 2));
        }
    }
}
