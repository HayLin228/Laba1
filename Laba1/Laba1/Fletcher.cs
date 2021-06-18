using Laba1.OptimizationMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
	public partial class Fletcher : Form
	{
		private FletcherMethod fm;
		public Fletcher()
		{
			fm = new FletcherMethod();
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			tbOut.Clear();
			Entities.Point startPoint = new Entities.Point(double.Parse(tbX.Text), double.Parse(tbY.Text));
			var result = fm.FindMinimum2(startPoint);
			foreach (var item in result)
			{
				tbOut.AppendText("x = " + item.Item1.x + " y = " + item.Item1.y + Environment.NewLine + "Func value = " + item.Item2 + Environment.NewLine + Environment.NewLine);
			}
			Draw(result, float.Parse(tbScale.Text));
		}

		private void Draw(List<Tuple<Entities.Point, double>> list, float scale)
		{
			Graphics g = pbGr.CreateGraphics();
			g.Clear(Color.White);
			Pen pen = new Pen(Color.Red);
			Pen pen2 = new Pen(Color.Green);
			g.DrawLine(new Pen(Color.Black), 0, 200, 400, 200);
			g.DrawLine(new Pen(Color.Black), 200, 0, 200, 400);
			g.FillRectangle(new SolidBrush(Color.Blue), new RectangleF((float)0 * scale + 200, (float)1 * -1 * scale + 200, (float)0.1 * scale, (float)0.1 * scale));
			g.FillRectangle(new SolidBrush(Color.Blue), new RectangleF((float)1 * scale + 200, (float)0 * scale + 200, (float)0.1 * scale, (float)0.1 * scale));

			Tuple<Entities.Point, double> prevItem = list[0];
			foreach (var item in list)
			{
				g.DrawLine(pen, (float)prevItem.Item1.x * scale + 200, (float)prevItem.Item1.y * -1 * scale + 200, (float)item.Item1.x * scale + 200, (float)prevItem.Item1.y * -1 * scale + 200);
				g.DrawLine(pen, (float)item.Item1.x * scale + 200, (float)prevItem.Item1.y * -1 * scale + 200, (float)item.Item1.x * scale + 200, (float)item.Item1.y * -1 * scale + 200);
				g.DrawLine(pen2, (float)prevItem.Item1.x * scale + 200, (float)prevItem.Item1.y * -1 * scale + 200, (float)item.Item1.x * scale + 200, (float)item.Item1.y * -1 * scale + 200);
				prevItem = item;
			}

		}
	}
}
