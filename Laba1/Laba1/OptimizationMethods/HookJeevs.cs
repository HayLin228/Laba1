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
            //return Math.Pow(p.x, 2) + Math.Pow(p.y, 2);
            return -1 * (-Math.Pow(p.x - 1.1, 2) / 2 - Math.Pow(p.y - 2, 2) / 6);
        }

		public List<Tuple<Point, double>> FindMinimum(Point startPoint, double delta, double eps, double m = 0.5)
		{
			var prevPoint = startPoint;
			var prevVal = Funct(startPoint);
			Point direction;
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

				if (prevPoint == newPoint)
				{
					if (delta <= eps)
					{
						return trace;
					}
					delta /= 2;
					continue;
				}
				direction = DiffVect(newPoint, prevPoint);
				var funcResult = GoldenRatioMethod(prevPoint.x, newPoint.x, eps, prevPoint, direction);
				newPoint = SumVect(prevPoint, MulVect(direction, funcResult.Item1));
				trace.Add(new Tuple<Point, double>(newPoint, funcResult.Item2));
			}

		}
		private Point DiffVect(Point p1, Point p2)
		{
			return new Point(p1.x - p2.x, p1.y - p2.y);
		}
		private Point SumVect(Point p1, Point p2)
		{
			return new Point(Math.Abs(p1.x + p2.x), Math.Abs(p1.y + p2.y));
		}
		private Point MulVect(Point p1, double multipler)
		{
			return new Point(Math.Abs(p1.x * multipler), Math.Abs(p1.y * multipler));
		}
		private Func<double, double> GetSignleVariableFunc(Point prevPoint, Point dir)
		{
			return (x) =>
			{
				Point newPoint = SumVect(prevPoint, MulVect(dir, x));
				return Funct(newPoint);
			};
		}

		private Tuple<double, double> GoldenRatioMethod(double a, double b, double eps, Point prevPoint, Point dir)
		{
			var t = (Math.Sqrt(5) - 1) / 2;
			var d = b - a;
			var dif = t * d;
			var y = a + dif;
			var x = b - dif;
			var updateFx = true;
			var updateFy = true;
			int iters = 0;
			int measurements = 0;
			var func = GetSignleVariableFunc(prevPoint, dir);
			double fx = 0;
			double fy = 0;
			double xMin = 0;
			double fMin = 0;
			while (true)
			{
				iters++;
				if (updateFx)
				{
					fx = func(x);
					updateFx = false;
					measurements++;
				}
				if (updateFy)
				{
					fy = func(y);
					updateFy = false;
					measurements++;
				}
				if (fx > fy)
				{
					fMin = fy;
					xMin = y;
					a = x;
					x = y;
					fx = fy;
					y = a + b - x;
					updateFy = true;
				}
				else
				{
					fMin = fx;
					xMin = x;
					b = y;
					y = x;
					fy = fx;
					y = a + b - y;
					updateFx = true;
				}
				if (b - a < eps)
				{
					return new Tuple<double, double>(xMin, fMin);
				}

			}
		}
	}
}
