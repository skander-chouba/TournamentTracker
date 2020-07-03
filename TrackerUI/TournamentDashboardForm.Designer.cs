namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.CreatePrizeLabel = new System.Windows.Forms.Label();
            this.LoadExistingTournamentsDropDown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentsLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            this.CreatePrizeLabel.AutoSize = true;
            this.CreatePrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreatePrizeLabel.Location = new System.Drawing.Point(113, 33);
            this.CreatePrizeLabel.Name = "CreatePrizeLabel";
            this.CreatePrizeLabel.Size = new System.Drawing.Size(488, 62);
            this.CreatePrizeLabel.TabIndex = 13;
            this.CreatePrizeLabel.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentsDropDown
            // 
            this.LoadExistingTournamentsDropDown.FormattingEnabled = true;
            this.LoadExistingTournamentsDropDown.Location = new System.Drawing.Point(102, 201);
            this.LoadExistingTournamentsDropDown.Name = "LoadExistingTournamentsDropDown";
            this.LoadExistingTournamentsDropDown.Size = new System.Drawing.Size(511, 45);
            this.LoadExistingTournamentsDropDown.TabIndex = 20;
            // 
            // LoadExistingTournamentsLabel
            // 
            this.LoadExistingTournamentsLabel.AutoSize = true;
            this.LoadExistingTournamentsLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingTournamentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoadExistingTournamentsLabel.Location = new System.Drawing.Point(148, 152);
            this.LoadExistingTournamentsLabel.Name = "LoadExistingTournamentsLabel";
            this.LoadExistingTournamentsLabel.Size = new System.Drawing.Size(419, 46);
            this.LoadExistingTournamentsLabel.TabIndex = 19;
            this.LoadExistingTournamentsLabel.Text = "Load Existing Tournaments";
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoadTournamentButton.Location = new System.Drawing.Point(229, 306);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(256, 50);
            this.LoadTournamentButton.TabIndex = 21;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButtom
            // 
            this.CreateTournamentButtom.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButtom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButtom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.CreateTournamentButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButtom.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButtom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButtom.Location = new System.Drawing.Point(201, 407);
            this.CreateTournamentButtom.Name = "CreateTournamentButtom";
            this.CreateTournamentButtom.Size = new System.Drawing.Size(312, 115);
            this.CreateTournamentButtom.TabIndex = 25;
            this.CreateTournamentButtom.Text = "Create Tournament";
            this.CreateTournamentButtom.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 561);
            this.Controls.Add(this.CreateTournamentButtom);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExistingTournamentsDropDown);
            this.Controls.Add(this.LoadExistingTournamentsLabel);
            this.Controls.Add(this.CreatePrizeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreatePrizeLabel;
        private System.Windows.Forms.ComboBox LoadExistingTournamentsDropDown;
        private System.Windows.Forms.Label LoadExistingTournamentsLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButtom;
    }
}