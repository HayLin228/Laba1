
namespace Laba1
{
	partial class Fletcher
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
			this.pbGr = new System.Windows.Forms.PictureBox();
			this.tbOut = new System.Windows.Forms.TextBox();
			this.tbX = new System.Windows.Forms.TextBox();
			this.tbScale = new System.Windows.Forms.TextBox();
			this.tbY = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbGr)).BeginInit();
			this.SuspendLayout();
			// 
			// pbGr
			// 
			this.pbGr.Location = new System.Drawing.Point(457, 12);
			this.pbGr.Name = "pbGr";
			this.pbGr.Size = new System.Drawing.Size(400, 400);
			this.pbGr.TabIndex = 0;
			this.pbGr.TabStop = false;
			// 
			// tbOut
			// 
			this.tbOut.Location = new System.Drawing.Point(13, 13);
			this.tbOut.Multiline = true;
			this.tbOut.Name = "tbOut";
			this.tbOut.Size = new System.Drawing.Size(253, 399);
			this.tbOut.TabIndex = 1;
			// 
			// tbX
			// 
			this.tbX.Location = new System.Drawing.Point(310, 13);
			this.tbX.Name = "tbX";
			this.tbX.Size = new System.Drawing.Size(69, 20);
			this.tbX.TabIndex = 2;
			// 
			// tbScale
			// 
			this.tbScale.Location = new System.Drawing.Point(310, 65);
			this.tbScale.Name = "tbScale";
			this.tbScale.Size = new System.Drawing.Size(69, 20);
			this.tbScale.TabIndex = 3;
			// 
			// tbY
			// 
			this.tbY.Location = new System.Drawing.Point(310, 39);
			this.tbY.Name = "tbY";
			this.tbY.Size = new System.Drawing.Size(69, 20);
			this.tbY.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(273, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "x";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(273, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "y";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(273, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Scale";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(310, 104);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(69, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Fletcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(869, 427);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbY);
			this.Controls.Add(this.tbScale);
			this.Controls.Add(this.tbX);
			this.Controls.Add(this.tbOut);
			this.Controls.Add(this.pbGr);
			this.Name = "Fletcher";
			this.Text = "Fletcher";
			((System.ComponentModel.ISupportInitialize)(this.pbGr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbGr;
		private System.Windows.Forms.TextBox tbOut;
		private System.Windows.Forms.TextBox tbX;
		private System.Windows.Forms.TextBox tbScale;
		private System.Windows.Forms.TextBox tbY;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}