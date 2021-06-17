using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba1.OptimizationMethods;
using Laba1.Entities;

namespace Laba1
{
	public partial class HookJevs : Form
	{
		HookJeevs hj = new HookJeevs();
		public HookJevs()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			Laba1.Entities.Point startPoint = new Entities.Point(double.Parse(tbX.Text), double.Parse(tbY.Text));
			var result = hj.FindMinimum(startPoint, 0.5, double.Parse(tbEps.Text));

			foreach (var item in result)
			{
				textBox1.AppendText("x= " + item.Item1.x + " y= " + item.Item1.y + " func result = " + item.Item2 + Environment.NewLine);
			}
			Draw(result, float.Parse(tbScale.Text));
		}

		private void Draw(List<Tuple<Entities.Point, double>> list, float scale)
		{
			Graphics g = pbGr.CreateGraphics();
			g.Clear(Color.White);
			Pen pen = new Pen(Color.Red);
			g.DrawLine(new Pen(Color.Black), 0, 175, 350, 175);
			g.DrawLine(new Pen(Color.Black), 175, 0, 175, 350);
			g.FillRectangle(new SolidBrush(Color.Blue), new RectangleF((float)0 * scale + 175, (float)1 * -1 * scale + 175, (float)0.1 * scale, (float)0.1 * scale));
			g.FillRectangle(new SolidBrush(Color.Blue), new RectangleF((float)1 * scale + 175, (float)0 * scale + 175, (float)0.1 * scale, (float)0.1 * scale));
			Tuple<Entities.Point, double> prevItem = list[0];

			foreach (var item in list)
			{
				g.DrawLine(pen, (float)prevItem.Item1.x * scale + 175, (float)prevItem.Item1.y * -1 * scale + 175, (float)item.Item1.x * scale + 175, (float)prevItem.Item1.y * -1 * scale + 175);
				g.DrawLine(pen, (float)item.Item1.x * scale + 175, (float)prevItem.Item1.y * -1 * scale + 175, (float)item.Item1.x * scale + 175, (float)item.Item1.y * -1 * scale + 175);
				prevItem = item;
			}
		}
	}
}
