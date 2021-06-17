using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.OptimizationMethods
{
	public static class SvennMethod
	{

		public static Tuple<double, double> FindUnimodalSegment(double x0, double t, Func<double, double> func)
		{
			var fx0 = func(x0);
			var fxMinus = func(x0 - t);
			var fxPlus = func(x0 + t);
			double delta = 0;
			if (fxMinus >= fx0 && fx0 <= fxPlus)
			{
				return new Tuple<double, double>(x0 - t, x0 + t);
			}
			if (fxMinus <= fx0 && fx0 >= fxPlus)
			{
				return null;
			}
			if (fxMinus >= fx0 && fx0 >= fxPlus)
			{
				delta = t;
			}
			else if (fxMinus <= fx0 && fx0 <= fxPlus)
			{
				delta = -1 * t;
			}

			var xk = x0;
			var fxk = fx0;
			var xkMinus = x0 - t;
			double xkPlus;
			double fxkPlus;
			while (true)
			{
				xkPlus = xk + delta;
				fxkPlus = func(xkPlus);

				if (fxkPlus > fxk)
				{
					if (delta > 0)
					{
						return new Tuple<double, double>(xkMinus, xkPlus);
					}
					else
					{
						return new Tuple<double, double>(xkPlus, xkMinus);
					}
				}
				xkMinus = xk;
				xk = xkPlus;
				fxk = fxkPlus;
				delta *= 2;
			}

		}

	}
}
