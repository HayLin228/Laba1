
namespace Laba1
{
	partial class GradientMethod
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbOut = new System.Windows.Forms.TextBox();
			this.tbX = new System.Windows.Forms.TextBox();
			this.tbY = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pbGr = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tbScale = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pbGr)).BeginInit();
			this.SuspendLayout();
			// 
			// tbOut
			// 
			this.tbOut.Location = new System.Drawing.Point(13, 13);
			this.tbOut.Multiline = true;
			this.tbOut.Name = "tbOut";
			this.tbOut.Size = new System.Drawing.Size(255, 425);
			this.tbOut.TabIndex = 0;
			// 
			// tbX
			// 
			this.tbX.Location = new System.Drawing.Point(295, 50);
			this.tbX.Name = "tbX";
			this.tbX.Size = new System.Drawing.Size(40, 20);
			this.tbX.TabIndex = 1;
			// 
			// tbY
			// 
			this.tbY.Location = new System.Drawing.Point(295, 76);
			this.tbY.Name = "tbY";
			this.tbY.Size = new System.Drawing.Size(40, 20);
			this.tbY.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(292, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Start point";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(277, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "x";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(277, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(12, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "y";
			// 
			// pbGr
			// 
			this.pbGr.Location = new System.Drawing.Point(370, 19);
			this.pbGr.Name = "pbGr";
			this.pbGr.Size = new System.Drawing.Size(400, 400);
			this.pbGr.TabIndex = 6;
			this.pbGr.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(280, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbScale
			// 
			this.tbScale.Location = new System.Drawing.Point(295, 102);
			this.tbScale.Name = "tbScale";
			this.tbScale.Size = new System.Drawing.Size(40, 20);
			this.tbScale.TabIndex = 8;
			this.tbScale.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// GradientMethod
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tbScale);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pbGr);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbY);
			this.Controls.Add(this.tbX);
			this.Controls.Add(this.tbOut);
			this.Name = "GradientMethod";
			this.Text = "GradientMethod";
			((System.ComponentModel.ISupportInitialize)(this.pbGr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbOut;
		private System.Windows.Forms.TextBox tbX;
		private System.Windows.Forms.TextBox tbY;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pbGr;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbScale;
	}
}