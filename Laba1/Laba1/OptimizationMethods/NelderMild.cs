using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba1.Entities;


namespace Laba1.OptimizationMethods
{
	public class NelderMild
	{
		private const int N = 2;
		private const int Alpha = 1;

		private double Funct(Point p)
		{
			return -Math.Pow(p.xDouble - 1.1, 2) / 2 - Math.Pow(p.yDouble - 2, 2) / 6;
		}
		public void FindMinimum()
		{
			var simplex = FindFirstSimplex(new Point(0, 0), N);
			while (true)
			{
				var xr = Reflection(simplex, Alpha);
				simplex = ListSort(simplex);
				var fr = Funct(xr);
				var fl = Funct(simplex[0]);
				var fg = Funct(simplex[1]);
				var fh = Funct(simplex[2]);
				if (fr < fl)
				{
					//rastyajenie
					if (true)
					{
						continue;
					}
					else if (true)
					{
						simplex[2] = xr;
						continue;
					}
				}
				else if (fl < fr && fr < fg)
				{
					simplex[2] = xr;
				}
				else if (fg < fr && fr < fh)
				{
					Point temp = xr;
					xr = simplex[2];
					simplex[2] = temp;
					//sjatie
				}
				else if (fh < fr)
				{
					continue;
				}
			}

		}
		private List<Point> FindFirstSimplex(Point p1, int n)
		{
			int L = 1;
			List<Point> simplex = new List<Point>();

			var r1 = FindR1(L, n);
			var r2 = FindR2(L, n);

			simplex.Add(p1);
			simplex.Add(new Point(r1, r2));
			simplex.Add(new Point(r2, r1));

			return simplex;
		}

		private double FindR1(int L, int n)
		{
			return L * ((Math.Sqrt(n + 1) + n - 1) / (n * Math.Sqrt(2)));
		}
		private double FindR2(int L, int n)
		{
			return L * ((Math.Sqrt(n + 1) - 1) / (n * Math.Sqrt(2)));
		}

		private Point FindMid(List<Point> points)
		{
			var x = (points[0].xDouble + points[1].xDouble) / 2;
			var y = (points[0].yDouble + points[1].yDouble) / 2;
			return new Point(x, y);
		}

		private List<Point> ListSort(List<Point> points)
		{
			List<Tuple<Point, double>> pointFunc = new List<Tuple<Point, double>>();
			foreach (var point in points)
			{
				pointFunc.Add(new Tuple<Point, double>(point, Funct(point)));
			}
			pointFunc.OrderBy(x => x.Item2);
			return pointFunc.Select(x => x.Item1).ToList();
		}
		private Point Reflection(List<Point> points, int alpha)
		{
			points = ListSort(points);
			var mid = FindMid(points);
			Point xr = new Point((1 + alpha) * mid.xDouble - alpha * points[2].xDouble, (1 + alpha) * mid.yDouble - alpha * points[2].yDouble);
			return xr;
		}
	}
}
