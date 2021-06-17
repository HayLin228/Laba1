using Laba1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.OptimizationMethods
{
	public class GradFast
	{
		double ed = 0.001;
		double ex = 0.001;
		double ef = 0.001;
		private double Funct(Point p)
		{
			//return Math.Pow(p.x, 2) + Math.Pow(p.y, 2);
			return -1 * (-Math.Pow(p.x - 1.1, 2) / 2 - Math.Pow(p.y - 2, 2) / 6);
		}

		private Tuple<double, double> Grad(Point p)
		{
			//return Math.Pow(p.x, 2) + Math.Pow(p.y, 2);
			return new Tuple<double, double>(p.x - 1.1, p.y / 3 - 2 / 3);
		}
		public List<Tuple<Point, double>> FindMinimum(Point startPoint)
		{
			var prevPoint = new Point(startPoint.x, startPoint.y);
			var prevVal = Funct(startPoint);
			var oldPoint = new Point(startPoint.x, startPoint.y);
			var oldVal = Funct(startPoint);
			List<Tuple<Point, double>> trace = new List<Tuple<Point, double>> { new Tuple<Point, double>(startPoint, Funct(startPoint)) };
			while (true)
			{
				if (trace.Count > 1)
				{
					prevPoint = new Point(trace[trace.Count - 1].Item1.x, trace[trace.Count - 1].Item1.y);
					prevVal = trace[trace.Count - 1].Item2;
					//oldPoint = new Point(trace[trace.Count - 1].Item1.x, trace[trace.Count - 1].Item1.y);
					//oldVal = trace[trace.Count - 1].Item2;
				}
				var direction = Grad(prevPoint);
				if (GetLength(direction) < ed)
				{
					if (trace.Count == 1)
					{
						return trace;
					}
					if (trace.Count > 2)
					{
						oldPoint = new Point(trace[trace.Count - 2].Item1.x, trace[trace.Count - 2].Item1.y);
						oldVal = trace[trace.Count - 2].Item2;
					}
					if (GetDistance(oldPoint, prevPoint) <= ex && Math.Abs(oldVal - prevVal) <= ef)
					{
						return trace;
					}
				}
				var l = 
			}
		}
		private double GetLength(Tuple<double, double> vect)
		{
			double distance = 0;
			distance += Math.Pow(vect.Item1, 2);
			distance += Math.Pow(vect.Item2, 2);
			return Math.Sqrt(distance);
		}
		private double GetDistance(Point p1, Point p2)
		{
			double distance = 0;
			distance += Math.Pow((p1.x - p2.x), 2);
			distance += Math.Pow((p1.y - p2.y), 2);
			return Math.Sqrt(distance);
		}
	}
}
