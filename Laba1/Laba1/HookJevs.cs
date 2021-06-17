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
            Laba1.Entities.Point startPoint = new Entities.Point(double.Parse(tbX.Text), double.Parse(tbY.Text));
            var result = hj.FindMinimum(startPoint, 1, 0.01);

            foreach (var item in result)
            {
                textBox1.AppendText("x= " + item.Item1.x + " y= " + item.Item1.y + " func result = " + item.Item2+Environment.NewLine);
            }
        }
    }
}
