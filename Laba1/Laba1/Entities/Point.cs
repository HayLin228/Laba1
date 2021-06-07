using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Entities
{
	public class Point
	{
		public double xDouble { get; set; }

		public double yDouble { get; set; }


		public Point(double x, double y)
		{
			this.xDouble = x;
			this.yDouble = y;
		}
	}
}
