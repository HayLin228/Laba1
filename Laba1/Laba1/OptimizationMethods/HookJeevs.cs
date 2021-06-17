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
			List<Point> pointsForDrawing = new List<Point>();
			var prevPoint = new Point(startPoint.x, startPoint.y);
			var prevVal = Funct(startPoint);
			pointsForDrawing.Add(prevPoint);
			Point direction = new Point(1, 1);
			List<Tuple<Point, double>> trace = new List<Tuple<Point, double>> { new Tuple<Point, double>(prevPoint, prevVal) };
			while (true)
			{
				if (trace.Count > 1)
				{
					prevPoint = new Point(trace[trace.Count - 1].Item1.x, trace[trace.Count - 1].Item1.y);
					prevVal = trace[trace.Count - 1].Item2;
				}
				var newPoint = new Point(prevPoint.x, prevPoint.y);

				double newVal;
				for (int i = 0; i < N; i++)
				{
					if (i == 0)
					{
						newVal = Funct(new Point(newPoint.x + delta, newPoint.y));
						//newPoint.x += delta;
					}
					else
					{
						newVal = Funct(new Point(newPoint.x, newPoint.y + delta));
						//newPoint.y += delta;
					}
					//newVal = Funct(newPoint);
					if (newVal < prevVal)
					{
						if (i == 0)
						{
							newPoint.x += delta;
						}
						else
						{
							newPoint.y += delta;
						}
						pointsForDrawing.Add(newPoint);
						prevVal = newVal;
						continue;
					}
					if (i == 0)
					{
						newVal = Funct(new Point(newPoint.x - delta, newPoint.y));
						//newPoint.x += delta;
					}
					else
					{
						newVal = Funct(new Point(newPoint.x, newPoint.y - delta));
						//newPoint.y += delta;
					}
					//newVal = Funct(newPoint);
					if (newVal < prevVal)
					{
						if (i == 0)
						{
							newPoint.x -= delta;
						}
						else
						{
							newPoint.y -= delta;
						}
						pointsForDrawing.Add(newPoint);
						prevVal = newVal;
						continue;
					}
					//if (i == 0)
					//{
					//	newPoint.x += delta;
					//}
					//else
					//{
					//	newPoint.y += delta;
					//}
				}

				if (prevPoint.ComparePoints(newPoint))
				{
					if (delta <= eps)
					{
						return trace;
					}
					else
					{
						delta /= 2;
						continue;
					}
				}
				else if (prevPoint != newPoint)
				{
					direction = DiffVect(newPoint, prevPoint);
				}

				var singFunc = GetSignleVariableFunc(prevPoint, direction);
				var tupForGoldenRation = SvennMethod.FindUnimodalSegment(0, 0.01, singFunc);
				var funcResult = GoldenRatioMethod2(tupForGoldenRation.Item1, tupForGoldenRation.Item2, eps, singFunc);
				newPoint = SumVect(prevPoint, MulVect(direction, funcResult));
				trace.Add(new Tuple<Point, double>(newPoint, Funct(newPoint)));
				
			}

		}
		private Point DiffVect(Point p1, Point p2)
		{
			return new Point(p1.x - p2.x, p1.y - p2.y);
		}
		private Point SumVect(Point p1, Point p2)
		{
			return new Point(p1.x + p2.x, p1.y + p2.y);
		}
		private Point MulVect(Point p1, double multipler)
		{
			return new Point(p1.x * multipler, p1.y * multipler);
		}
		private Func<double, double> GetSignleVariableFunc(Point prevPoint, Point dir)
		{
			return (x) =>
			{
				Point newPoint = SumVect(prevPoint, MulVect(dir, x));
				return Funct(newPoint);
			};
		}

		private double GoldenRatioMethod2(double a, double b, double eps, Func<double, double> func)
		{
			eps /= 10;
			var t = (Math.Sqrt(5) - 1) / 2;
			var an = a;
			var bn = b;
			var xn = b - t * (b - a);
			var yn = a + b - xn;

			while ((bn - an) > eps)
			{
				if (func(xn) < func(yn))
				{
					bn = yn;
					yn = xn;
					xn = an + bn - yn;
				}
				else
				{
					an = xn;
					xn = yn;
					yn = an + bn - xn;
				}
			}
			return (an + bn) / 2;
		}

		private Tuple<double, double> GoldenRatioMethod(double a, double b, double eps, Func<double, double> func)
		{
			eps /= 10;
			var t = (Math.Sqrt(5) - 1) / 2;
			var d = b - a;
			var dif = t * d;
			var y = a + dif;
			var x = b - dif;
			var updateFx = true;
			var updateFy = true;
			int iters = 0;
			int measurements = 0;
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
