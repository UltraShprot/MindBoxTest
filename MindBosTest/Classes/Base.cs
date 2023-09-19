using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Classes
{
	public abstract class Base
	{
		public double Area { get; protected set; }
		public bool isRectangular { get; protected set; } = false;
		protected abstract double CalcArea();
	}
}
