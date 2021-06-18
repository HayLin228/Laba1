using System.Collections.Generic;

namespace Laba1.Entities
{
	public class Point
	{
		private double eps = 0.0000000000001;
		public double x { get; set; }
		
		public double y { get; set; }


		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public bool ComparePoints(Point p2)
		{
			return this.x - p2.x < eps&& this.y - p2.y < eps;
		}
		public Point CollectionToPoint(List<double> list)
		{
			return new Point(list[0], list[1]);
		}
	}
}
