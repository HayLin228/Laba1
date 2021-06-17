namespace Laba1
{
    partial class HookJevs
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tbX = new System.Windows.Forms.TextBox();
			this.tbY = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbEps = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pbGr = new System.Windows.Forms.PictureBox();
			this.tbScale = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pbGr)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 13);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(335, 350);
			this.textBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(354, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ne Najimat";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbX
			// 
			this.tbX.Location = new System.Drawing.Point(372, 79);
			this.tbX.Name = "tbX";
			this.tbX.Size = new System.Drawing.Size(48, 20);
			this.tbX.TabIndex = 2;
			// 
			// tbY
			// 
			this.tbY.Location = new System.Drawing.Point(449, 79);
			this.tbY.Name = "tbY";
			this.tbY.Size = new System.Drawing.Size(48, 20);
			this.tbY.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(354, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "x";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(431, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "y";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(351, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "start point";
			// 
			// tbEps
			// 
			this.tbEps.Location = new System.Drawing.Point(384, 120);
			this.tbEps.Name = "tbEps";
			this.tbEps.Size = new System.Drawing.Size(48, 20);
			this.tbEps.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(354, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "eps";
			// 
			// pbGr
			// 
			this.pbGr.Location = new System.Drawing.Point(503, 13);
			this.pbGr.Name = "pbGr";
			this.pbGr.Size = new System.Drawing.Size(350, 350);
			this.pbGr.TabIndex = 9;
			this.pbGr.TabStop = false;
			// 
			// tbScale
			// 
			this.tbScale.Location = new System.Drawing.Point(384, 146);
			this.tbScale.Name = "tbScale";
			this.tbScale.Size = new System.Drawing.Size(48, 20);
			this.tbScale.TabIndex = 10;
			// 
			// HookJevs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 372);
			this.Controls.Add(this.tbScale);
			this.Controls.Add(this.pbGr);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbEps);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbY);
			this.Controls.Add(this.tbX);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "HookJevs";
			this.Text = "HookJevs";
			((System.ComponentModel.ISupportInitialize)(this.pbGr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbEps;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pbGr;
		private System.Windows.Forms.TextBox tbScale;
	}
}