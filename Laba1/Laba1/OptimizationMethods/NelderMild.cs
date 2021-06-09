using Laba1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Laba1.OptimizationMethods
{
	public class NelderMild
	{
		private const int N = 2;
		private const int Alpha = 2;
		private const double Beta = 0.5;
		private const double Gamma = 0.5;
		private double Funct(Point p)
		{
			return -Math.Pow(p.x - 1.1, 2) / 2 - Math.Pow(p.y - 2, 2) / 6;
		}

		private Tuple<bool, double> IsItEnd(List<Point> points, double eps)
		{
			double Fsum = 0;
			foreach (var item in points)
			{
				Fsum += Funct(item);
			}
			var F = Fsum / (N + 1);

			double sigma = 0;
			foreach (var item in points)
			{
				sigma += Math.Pow(Funct(item) - F, 2) - (N + 1);
			}
			return new Tuple<bool, double>(sigma < eps, sigma);
		}

		public Tuple<List<Point>, double> FindMinimum(int iter, double eps)
		{
			var simplex = FindFirstSimplex(new Point(0, 0), N);
			int iterations = 0;
			double sigma;
			while (IsItEnd(simplex, eps).Item1 && iterations < iter)
			{
				simplex = ListSort(simplex);
				var mid = FindMid(simplex);//center tyajesti
				Point xe;
				Point xs;
				var xr = Reflection(simplex, mid, 1);//reflected
				var fr = Funct(xr);//reflected in func
				var fl = Funct(simplex[0]);
				var fg = Funct(simplex[1]);
				var fh = Funct(simplex[2]);
				double fs;
				double fe;
				if (fr < fl)
				{
					xe = Expansion(Alpha, simplex, mid);
					fe = Funct(xe);
					if (fe < fr)
					{
						simplex[2] = xe;
						continue;
					}
					else if (fr < fe)
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
				}
				else if (fh < fr)
				{
					//do nothing and go sjatie
				}
				xs = Contraction(Beta, simplex, mid);
				fs = Funct(xs);
				if (fs < fh)
				{
					simplex[2] = xs;
				}
				else if (fh < fs)
				{
					for (int i = 1; i <= 2; i++)
					{
						//reduction
						var newX = simplex[0].x + Gamma * (simplex[i].x - simplex[0].x) / 2;
						var newY = simplex[0].y + Gamma * (simplex[i].y - simplex[0].y) / 2;
						simplex[i] = new Point(newX, newY);
					}
				}
				iterations++;
			}
			return new Tuple<List<Point>, double>(simplex,IsItEnd(simplex,eps).Item2);
		}
		private Point Reflection(List<Point> points, Point mid, int alpha)
		{
			Point xr = new Point((1 + alpha) * mid.x - points[2].x, (1 + alpha) * mid.y - points[2].y);
			return xr;
		}

		private Point Expansion(int alpha, List<Point> points, Point mid)
		{
			var x = mid.x + alpha * (points[2].x - mid.x);
			var y = mid.y + alpha * (points[2].y - mid.y);
			return new Point(x, y);
		}

		private Point Contraction(double beta, List<Point> points, Point mid)
		{
			var x = mid.x + beta * (points[2].x - mid.x);
			var y = mid.y + beta * (points[2].y - mid.y);
			return new Point(x, y);
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
			var x = (points[0].x + points[1].x) / 2;
			var y = (points[0].y + points[1].y) / 2;
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

	}
}
