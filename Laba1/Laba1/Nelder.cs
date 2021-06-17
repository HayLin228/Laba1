using Laba1.Entities;
using System.Drawing;
using Laba1.OptimizationMethods;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laba1
{
	public partial class Nelder : Form
	{
		private NelderMild n = new NelderMild();
		public Nelder()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			var tup = n.FindMinimum(int.Parse(textBox2.Text), double.Parse(textBox4.Text));
			var triangles = tup.Item1;
			foreach (var triangle in triangles)
			{
				foreach (var point in triangle)
				{
					textBox1.AppendText("x=" + point.x + ",y=" + point.y + Environment.NewLine);
				}
				textBox1.AppendText(Environment.NewLine);
			}
			textBox1.AppendText("func result = " + tup.Item2 + Environment.NewLine);
			Draw(triangles, float.Parse(textBox3.Text));

		}
		private void Draw(List<List<Entities.Point>> triangles, float scale)
		{
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(Color.White);
			Pen pen = new Pen(Color.Red);
			g.DrawLine(new Pen(Color.Black), 0, 150, 300, 150);
			g.DrawLine(new Pen(Color.Black), 150, 0, 150, 300);
			g.FillRectangle(new SolidBrush(Color.Blue), new RectangleF((float)0 * scale + 150, (float)1 * -1 * scale + 150, (float)0.1 * scale, (float)0.1 * scale));
			g.FillRectangle(new SolidBrush(Color.Blue), new RectangleF((float)1 * scale + 150, (float)0 * scale + 150, (float)0.1 * scale, (float)0.1 * scale));
			foreach (var points in triangles)
			{
				foreach (var item in points)
				{
					item.x = item.x * scale + 150;
					item.y = item.y * scale * (-1) + 150;
				}
				g.DrawLine(pen, (float)points[0].x, (float)points[0].y, (float)points[1].x, (float)points[1].y);
				g.DrawLine(pen, (float)points[1].x, (float)points[1].y, (float)points[2].x, (float)points[2].y);
				g.DrawLine(pen, (float)points[0].x, (float)points[0].y, (float)points[2].x, (float)points[2].y);

			}

		}
	}
}
