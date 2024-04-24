namespace Capstone_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pitcher = new ComboBox();
            batter = new ComboBox();
            play = new Button();
            Third = new PictureBox();
            First = new PictureBox();
            Second = new PictureBox();
            Result = new Label();
            next = new Button();
            CloserBatter = new PictureBox();
            LeftyBatter = new PictureBox();
            WinLose = new Label();
            Stats = new Button();
            StatsHere = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Third).BeginInit();
            ((System.ComponentModel.ISupportInitialize)First).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Second).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloserBatter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftyBatter).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.s_l1600;
            pictureBox1.Location = new Point(414, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._71Pse7sN8iL__AC_UF894_1000_QL80_DpWeblab_;
            pictureBox2.Location = new Point(-6, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(260, 246);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(485, 28);
            label1.Name = "label1";
            label1.Size = new Size(276, 38);
            label1.TabIndex = 2;
            label1.Text = "Braves Manager";
            // 
            // pitcher
            // 
            pitcher.FormattingEnabled = true;
            pitcher.Items.AddRange(new object[] { "RP, Aaron Bummer LHP", "RP, Jesse Chavez RHP", "SP, Max Fried LHP", "CP, Raisel Iglesias RHP", "RP, Joe Jimmenez RHP", "RP, Pierce Johnson RHP", "RP, Dylan Lee LHP", "SP, Reynaldo Lopez RHP", "RP, Tyler Matzek LHP", "RP, A.J. Minter LHP", "SP, Charlie Morton RHP", "SP, Chris Sale LHP", "SP, Spencer Strider RHP" });
            pitcher.Location = new Point(581, 341);
            pitcher.Name = "pitcher";
            pitcher.Size = new Size(151, 28);
            pitcher.TabIndex = 3;
            pitcher.Text = "Pitchers";
            pitcher.Visible = false;
            // 
            // batter
            // 
            batter.FormattingEnabled = true;
            batter.Items.AddRange(new object[] { "C, Travis d'Arnaud", "INF, Luis Guillorme", "OF, Adam Duvall", "OF, Forrest Wall" });
            batter.Location = new Point(581, 506);
            batter.Name = "batter";
            batter.Size = new Size(151, 28);
            batter.TabIndex = 4;
            batter.Text = "Hitters";
            batter.Visible = false;
            // 
            // play
            // 
            play.BackColor = Color.Blue;
            play.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            play.ForeColor = Color.Red;
            play.Location = new Point(972, 141);
            play.Name = "play";
            play.Size = new Size(229, 61);
            play.TabIndex = 5;
            play.Text = "Play Ball!";
            play.UseVisualStyleBackColor = false;
            play.Click += play_Click;
            // 
            // Third
            // 
            Third.Image = Properties.Resources.current;
            Third.Location = new Point(434, 283);
            Third.Name = "Third";
            Third.Size = new Size(69, 94);
            Third.SizeMode = PictureBoxSizeMode.StretchImage;
            Third.TabIndex = 6;
            Third.TabStop = false;
            Third.Visible = false;
            // 
            // First
            // 
            First.Image = Properties.Resources.current__4_;
            First.Location = new Point(801, 283);
            First.Name = "First";
            First.Size = new Size(71, 94);
            First.SizeMode = PictureBoxSizeMode.StretchImage;
            First.TabIndex = 7;
            First.TabStop = false;
            First.Visible = false;
            // 
            // Second
            // 
            Second.Image = Properties.Resources.current__1_;
            Second.Location = new Point(618, 141);
            Second.Name = "Second";
            Second.Size = new Size(80, 108);
            Second.SizeMode = PictureBoxSizeMode.StretchImage;
            Second.TabIndex = 8;
            Second.TabStop = false;
            Second.Visible = false;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Result.Location = new Point(618, 585);
            Result.Name = "Result";
            Result.Size = new Size(0, 30);
            Result.TabIndex = 9;
            Result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // next
            // 
            next.BackColor = Color.Blue;
            next.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            next.ForeColor = Color.Red;
            next.Location = new Point(988, 454);
            next.Name = "next";
            next.Size = new Size(170, 55);
            next.TabIndex = 10;
            next.Text = "Next";
            next.UseVisualStyleBackColor = false;
            next.Click += next_Click;
            // 
            // CloserBatter
            // 
            CloserBatter.Image = Properties.Resources.current1;
            CloserBatter.Location = new Point(614, 402);
            CloserBatter.Name = "CloserBatter";
            CloserBatter.Size = new Size(84, 107);
            CloserBatter.SizeMode = PictureBoxSizeMode.StretchImage;
            CloserBatter.TabIndex = 11;
            CloserBatter.TabStop = false;
            CloserBatter.Visible = false;
            // 
            // LeftyBatter
            // 
            LeftyBatter.Image = (Image)resources.GetObject("LeftyBatter.Image");
            LeftyBatter.Location = new Point(614, 402);
            LeftyBatter.Name = "LeftyBatter";
            LeftyBatter.Size = new Size(84, 107);
            LeftyBatter.SizeMode = PictureBoxSizeMode.StretchImage;
            LeftyBatter.TabIndex = 12;
            LeftyBatter.TabStop = false;
            LeftyBatter.Visible = false;
            // 
            // WinLose
            // 
            WinLose.AutoSize = true;
            WinLose.Font = new Font("Modern No. 20", 18.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WinLose.Location = new Point(614, 308);
            WinLose.Name = "WinLose";
            WinLose.Size = new Size(0, 32);
            WinLose.TabIndex = 13;
            // 
            // Stats
            // 
            Stats.BackColor = Color.Blue;
            Stats.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stats.ForeColor = Color.Red;
            Stats.Location = new Point(972, 294);
            Stats.Name = "Stats";
            Stats.Size = new Size(229, 61);
            Stats.TabIndex = 14;
            Stats.Text = "Show Stats";
            Stats.UseVisualStyleBackColor = false;
            Stats.Click += Stats_Click;
            // 
            // StatsHere
            // 
            StatsHere.AutoSize = true;
            StatsHere.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatsHere.Location = new Point(618, 708);
            StatsHere.Name = "StatsHere";
            StatsHere.Size = new Size(0, 30);
            StatsHere.TabIndex = 15;
            StatsHere.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1237, 913);
            Controls.Add(StatsHere);
            Controls.Add(Stats);
            Controls.Add(WinLose);
            Controls.Add(LeftyBatter);
            Controls.Add(CloserBatter);
            Controls.Add(next);
            Controls.Add(Result);
            Controls.Add(Second);
            Controls.Add(First);
            Controls.Add(Third);
            Controls.Add(play);
            Controls.Add(batter);
            Controls.Add(pitcher);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Third).EndInit();
            ((System.ComponentModel.ISupportInitialize)First).EndInit();
            ((System.ComponentModel.ISupportInitialize)Second).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloserBatter).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftyBatter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private ComboBox pitcher;
        private ComboBox batter;
        private Button play;
        private PictureBox Third;
        private PictureBox First;
        private PictureBox Second;
        private Label Result;
        private Button next;
        private PictureBox CloserBatter;
        private PictureBox LeftyBatter;
        private Label WinLose;
        private Button Stats;
        private Label StatsHere;
    }
}
