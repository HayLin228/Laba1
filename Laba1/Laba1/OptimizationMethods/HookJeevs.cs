using System;
using Laba1.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.OptimizationMethods
{
	public class HookJeevs
	{
		int N = 2;
		private double Funct(Point p)
		{
			return -Math.Pow(p.x - 1.1, 2) / 2 - Math.Pow(p.y - 2, 2) / 6;
		}

		private List<Tuple<Point, double>> FindMinimum(Point startPoint, double delta, double eps, double m)
		{
			var prevPoint = startPoint;
			var prevVal = Funct(startPoint);
			List<Tuple<Point, double>> trace = new List<Tuple<Point, double>> { new Tuple<Point, double>(prevPoint, prevVal) };
			while (true)
			{
				if (trace.Count > 1)
				{
					prevPoint = trace[trace.Count - 2].Item1;
					prevVal = trace[trace.Count - 2].Item2;
				}
				var newPoint = prevPoint;
				double newVal;
				for (int i = 0; i < N; i++)
				{
					if (i == 0)
					{
						newPoint.x += delta;
					}
					else
					{
						newPoint.y += delta;
					}
					newVal = Funct(newPoint);
					if (newVal < prevVal)
					{
						prevVal = newVal;
						continue;
					}
					if (i == 0)
					{
						newPoint.x -= delta * 2;
					}
					else
					{
						newPoint.y -= delta * 2;
					}
					newVal = Funct(newPoint);
					if (newVal < prevVal)
					{
						prevVal = newVal;
						continue;
					}
					if (i == 0)
					{
						newPoint.x += delta;
					}
					else
					{
						newPoint.y += delta;
					}
				}
				Point direction = DiffPoint(newPoint, prevPoint);
				if (direction.x < eps && direction.y < eps)
				{
					if (delta <= eps)
					{
						return trace;
					}
					delta *= m;
					continue;
				}

			}

		}
		private Point DiffPoint(Point p1, Point p2)
		{
			return new Point(Math.Abs(p1.x - p2.x), Math.Abs(p1.y - p2.y));
		}
		private Point SumPoint(Point p1, Point p2)
		{
			return new Point(Math.Abs(p1.x + p2.x), Math.Abs(p1.y + p2.y));
		}
		private Point MulPoint(Point p1, double multipler)
		{
			return new Point(Math.Abs(p1.x * multipler), Math.Abs(p1.y * multipler));
		}
		private Func<double, double> GetSignleVariableFunc(Point prevPoint, Point dir)
		{
			return (x) =>
			{
				Point newPoint = SumPoint(prevPoint, MulPoint(dir, x));
				return Funct(newPoint);
			};
		}
	}
}
