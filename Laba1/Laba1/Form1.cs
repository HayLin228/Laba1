using Laba1.Entities;
using System.Drawing;
using Laba1.OptimizationMethods;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laba1
{
	public partial class Form1 : Form
	{
		private NelderMild n = new NelderMild();
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			var tup = n.FindMinimum(int.Parse(textBox2.Text), double.Parse(textBox2.Text));
			List<Entities.Point> points = tup.Item1;
			foreach (var point in points)
			{
				textBox1.AppendText($"x={point.x},y={point.y}" + Environment.NewLine);
			}
			textBox1.AppendText(tup.Item2 + Environment.NewLine);
			Draw(points, float.Parse(textBox3.Text));
		}
		private void Draw(List<Entities.Point> points, float scale)
		{
			foreach (var item in points)
			{
				item.x = item.x * scale + 150;
				item.y = item.y * scale + 150;
			}
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(Color.White);
			Pen pen = new Pen(Color.Red);

			g.DrawLine(new Pen(Color.Black),0,150,300,150);
			g.DrawLine(new Pen(Color.Black), 150, 0, 150, 300);

			g.DrawLine(pen, (float)points[0].x, (float)points[0].y, (float)points[1].x, (float)points[1].y);
			g.DrawLine(pen, (float)points[1].x, (float)points[1].y, (float)points[2].x, (float)points[2].y);
			g.DrawLine(pen, (float)points[0].x, (float)points[0].y, (float)points[2].x, (float)points[2].y);
		}
	}
}
