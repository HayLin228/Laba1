using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba1.Entities;

namespace Laba1.OptimizationMethods
{
	public class FletcherMethod
	{

		private List<List<double>> H = new List<List<double>>() { new List<double>() { 1, 0 }, new List<double>() { 0, 0.333333333 } };
		private double Funct(Point p)
		{
			return -1 * (-Math.Pow(p.x - 1.1, 2) / 2 - Math.Pow(p.y - 2, 2) / 6);
		}

		private Point Grad(Point p)
		{
			return new Point(p.x - 1.1, (p.y / 3) - (2 / 3));
		}

		public List<Tuple<Point, double>> FindMinimum2(Point startPoint, double eps = 0.01)
		{
			List<Tuple<Point, double>> result = new List<Tuple<Point, double>>();
			var xk = startPoint;
			var fk = Funct(xk);

			result.Add(new Tuple<Point, double>(new Point(xk.x, xk.y), fk));
			Point gradF = Grad(xk);
			var d = GetMultiply(gradF, -1);
			Point xkNew;
			double beta;

			while (Math.Abs(gradF.x) > eps && Math.Abs(gradF.y) > eps)
			{
				var l1 = GetMultiplyVect(d, gradF);
				var l2 = GetMultiplyVect(GetMatrixMultiply(H, d), gradF);
				var lambda = l1 / l2;
				xkNew = new Point(xk.x - gradF.x * lambda, xk.y - gradF.y * lambda);
				result.Add(new Tuple<Point, double>(new Point(xkNew.x, xkNew.y), Funct(xkNew)));
				beta = GetMultiplyVect(Grad(xkNew), Grad(xkNew)) / GetMultiplyVect(Grad(xk), Grad(xk));
				xk = xkNew;
				gradF = Grad(xk);
				d = GetSum(GetMultiply(gradF, -1), GetMultiply(d, beta));

			}
			return result;
		}

		private double GetMultiplyVect(Point p1, Point p2)
		{
			return (p1.x * p2.x + p1.y * p2.y);
		}

		private Point GetMultiply(Point p1, double multipler)
		{
			return new Point(p1.x * multipler, p1.y * multipler);
		}


		private Point GetMatrixMultiply(List<List<double>> matrix, Point vect)
		{
			return new Point(
				vect.x * matrix[0][0] + vect.y * matrix[1][0],
				vect.x * matrix[0][1] + vect.y * matrix[1][1]);
		}
		private Point GetSum(Point p1, Point p2)
		{
			return new Point(p1.x + p2.x, p1.y + p2.y);
		}
	}
}
