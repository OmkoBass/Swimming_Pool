namespace Swimming
{
    partial class Form1
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
            this.TeamName = new System.Windows.Forms.Label();
            this.TeamSpeed = new System.Windows.Forms.Label();
            this.TeamNameInput = new System.Windows.Forms.TextBox();
            this.TeamSpeedInput = new System.Windows.Forms.TextBox();
            this.AssignTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(12, 12);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(71, 16);
            this.TeamName.TabIndex = 0;
            this.TeamName.Text = "Ime Ekipe:";
            // 
            // TeamSpeed
            // 
            this.TeamSpeed.AutoSize = true;
            this.TeamSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamSpeed.Location = new System.Drawing.Point(66, 51);
            this.TeamSpeed.Name = "TeamSpeed";
            this.TeamSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TeamSpeed.Size = new System.Drawing.Size(48, 16);
            this.TeamSpeed.TabIndex = 1;
            this.TeamSpeed.Text = "Brzina:";
            // 
            // TeamNameInput
            // 
            this.TeamNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameInput.Location = new System.Drawing.Point(120, 9);
            this.TeamNameInput.Name = "TeamNameInput";
            this.TeamNameInput.Size = new System.Drawing.Size(117, 22);
            this.TeamNameInput.TabIndex = 2;
            // 
            // TeamSpeedInput
            // 
            this.TeamSpeedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamSpeedInput.Location = new System.Drawing.Point(120, 51);
            this.TeamSpeedInput.Name = "TeamSpeedInput";
            this.TeamSpeedInput.Size = new System.Drawing.Size(117, 22);
            this.TeamSpeedInput.TabIndex = 3;
            // 
            // AssignTeam
            // 
            this.AssignTeam.Location = new System.Drawing.Point(131, 96);
            this.AssignTeam.Name = "AssignTeam";
            this.AssignTeam.Size = new System.Drawing.Size(75, 23);
            this.AssignTeam.TabIndex = 4;
            this.AssignTeam.Text = "button1";
            this.AssignTeam.UseVisualStyleBackColor = true;
            this.AssignTeam.Click += new System.EventHandler(this.AssignTeam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 134);
            this.Controls.Add(this.AssignTeam);
            this.Controls.Add(this.TeamSpeedInput);
            this.Controls.Add(this.TeamNameInput);
            this.Controls.Add(this.TeamSpeed);
            this.Controls.Add(this.TeamName);
            this.Name = "Form1";
            this.Text = "Swimming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label TeamSpeed;
        private System.Windows.Forms.TextBox TeamNameInput;
        private System.Windows.Forms.TextBox TeamSpeedInput;
        private System.Windows.Forms.Button AssignTeam;
    }
}

