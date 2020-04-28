namespace Swimming
{
    partial class SwimmingPool
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
            this.components = new System.ComponentModel.Container();
            this.Pool = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.SwimTimer = new System.Windows.Forms.Timer(this.components);
            this.FirstTeam = new System.Windows.Forms.Label();
            this.SecondTeam = new System.Windows.Forms.Label();
            this.ThirdTeam = new System.Windows.Forms.Label();
            this.FourthTeam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pool)).BeginInit();
            this.SuspendLayout();
            // 
            // Pool
            // 
            this.Pool.Location = new System.Drawing.Point(92, 12);
            this.Pool.Name = "Pool";
            this.Pool.Size = new System.Drawing.Size(425, 200);
            this.Pool.TabIndex = 0;
            this.Pool.TabStop = false;
            this.Pool.Paint += new System.Windows.Forms.PaintEventHandler(this.Pool_Paint);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(92, 218);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(269, 218);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(442, 218);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // SwimTimer
            // 
            this.SwimTimer.Interval = 60;
            this.SwimTimer.Tick += new System.EventHandler(this.SwimTimer_Tick);
            // 
            // FirstTeam
            // 
            this.FirstTeam.AutoSize = true;
            this.FirstTeam.Location = new System.Drawing.Point(12, 24);
            this.FirstTeam.Name = "FirstTeam";
            this.FirstTeam.Size = new System.Drawing.Size(35, 13);
            this.FirstTeam.TabIndex = 4;
            this.FirstTeam.Text = "label1";
            // 
            // SecondTeam
            // 
            this.SecondTeam.AutoSize = true;
            this.SecondTeam.Location = new System.Drawing.Point(12, 73);
            this.SecondTeam.Name = "SecondTeam";
            this.SecondTeam.Size = new System.Drawing.Size(35, 13);
            this.SecondTeam.TabIndex = 5;
            this.SecondTeam.Text = "label1";
            // 
            // ThirdTeam
            // 
            this.ThirdTeam.AutoSize = true;
            this.ThirdTeam.Location = new System.Drawing.Point(12, 128);
            this.ThirdTeam.Name = "ThirdTeam";
            this.ThirdTeam.Size = new System.Drawing.Size(35, 13);
            this.ThirdTeam.TabIndex = 6;
            this.ThirdTeam.Text = "label1";
            // 
            // FourthTeam
            // 
            this.FourthTeam.AutoSize = true;
            this.FourthTeam.Location = new System.Drawing.Point(12, 180);
            this.FourthTeam.Name = "FourthTeam";
            this.FourthTeam.Size = new System.Drawing.Size(35, 13);
            this.FourthTeam.TabIndex = 7;
            this.FourthTeam.Text = "label1";
            // 
            // SwimmingPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 255);
            this.Controls.Add(this.FourthTeam);
            this.Controls.Add(this.ThirdTeam);
            this.Controls.Add(this.SecondTeam);
            this.Controls.Add(this.FirstTeam);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Pool);
            this.Name = "SwimmingPool";
            this.Text = "SwimmingPool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SwimmingPool_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Pool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pool;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer SwimTimer;
        private System.Windows.Forms.Label FirstTeam;
        private System.Windows.Forms.Label SecondTeam;
        private System.Windows.Forms.Label ThirdTeam;
        private System.Windows.Forms.Label FourthTeam;
    }
}