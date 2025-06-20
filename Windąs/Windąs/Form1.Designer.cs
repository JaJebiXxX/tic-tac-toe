namespace Windąs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            zapis_partii = new TextBox();
            menuStrip1 = new MenuStrip();
            resetToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Location = new Point(10, 52);
            b1.Margin = new Padding(4, 4, 4, 4);
            b1.Name = "b1";
            b1.Size = new Size(129, 140);
            b1.TabIndex = 0;
            b1.Tag = "0";
            b1.UseVisualStyleBackColor = true;
            b1.Click += button1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(147, 52);
            b2.Margin = new Padding(4, 4, 4, 4);
            b2.Name = "b2";
            b2.Size = new Size(129, 140);
            b2.TabIndex = 1;
            b2.Tag = "0";
            b2.UseVisualStyleBackColor = true;
            b2.Click += button2_Click;
            // 
            // b3
            // 
            b3.Location = new Point(283, 52);
            b3.Margin = new Padding(4, 4, 4, 4);
            b3.Name = "b3";
            b3.Size = new Size(129, 140);
            b3.TabIndex = 2;
            b3.Tag = "0";
            b3.UseVisualStyleBackColor = true;
            b3.Click += button3_Click;
            // 
            // b4
            // 
            b4.Location = new Point(10, 200);
            b4.Margin = new Padding(4, 4, 4, 4);
            b4.Name = "b4";
            b4.Size = new Size(129, 140);
            b4.TabIndex = 3;
            b4.Tag = "0";
            b4.UseVisualStyleBackColor = true;
            b4.Click += button4_Click;
            // 
            // b5
            // 
            b5.Location = new Point(147, 200);
            b5.Margin = new Padding(4, 4, 4, 4);
            b5.Name = "b5";
            b5.Size = new Size(129, 140);
            b5.TabIndex = 4;
            b5.Tag = "0";
            b5.UseVisualStyleBackColor = true;
            b5.Click += button5_Click;
            // 
            // b6
            // 
            b6.Location = new Point(283, 200);
            b6.Margin = new Padding(4, 4, 4, 4);
            b6.Name = "b6";
            b6.Size = new Size(129, 140);
            b6.TabIndex = 5;
            b6.Tag = "0";
            b6.UseVisualStyleBackColor = true;
            b6.Click += button6_Click;
            // 
            // b7
            // 
            b7.Location = new Point(10, 349);
            b7.Margin = new Padding(4, 4, 4, 4);
            b7.Name = "b7";
            b7.Size = new Size(129, 140);
            b7.TabIndex = 6;
            b7.Tag = "0";
            b7.UseVisualStyleBackColor = true;
            b7.Click += button7_Click;
            // 
            // b8
            // 
            b8.Location = new Point(147, 349);
            b8.Margin = new Padding(4, 4, 4, 4);
            b8.Name = "b8";
            b8.Size = new Size(129, 140);
            b8.TabIndex = 7;
            b8.Tag = "0";
            b8.UseVisualStyleBackColor = true;
            b8.Click += button8_Click;
            // 
            // b9
            // 
            b9.Location = new Point(283, 349);
            b9.Margin = new Padding(4, 4, 4, 4);
            b9.Name = "b9";
            b9.Size = new Size(129, 140);
            b9.TabIndex = 8;
            b9.Tag = "0";
            b9.UseVisualStyleBackColor = true;
            b9.Click += button9_Click;
            // 
            // zapis_partii
            // 
            zapis_partii.Location = new Point(419, 52);
            zapis_partii.Margin = new Padding(4, 4, 4, 4);
            zapis_partii.Multiline = true;
            zapis_partii.Name = "zapis_partii";
            zapis_partii.ReadOnly = true;
            zapis_partii.Size = new Size(401, 435);
            zapis_partii.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { resetToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(837, 31);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(58, 25);
            resetToolStripMenuItem.Text = "reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 11;
            label1.Text = "Zapis partii:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 506);
            Controls.Add(label1);
            Controls.Add(zapis_partii);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "TicTacToe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private TextBox zapis_partii;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem resetToolStripMenuItem;
		private Label label1;
	}
}
