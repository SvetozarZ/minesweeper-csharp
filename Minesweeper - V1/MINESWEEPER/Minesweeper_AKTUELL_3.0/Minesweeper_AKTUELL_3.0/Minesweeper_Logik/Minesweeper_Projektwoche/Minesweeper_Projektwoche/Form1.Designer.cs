// Form1.Designer.cs
namespace Minesweeper_Projektwoche
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PanelPlayfield;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.PanelPlayfield = new System.Windows.Forms.Panel();
            this.PanelScoreTop = new System.Windows.Forms.Panel();
            this.LblGeschlossenFelder1 = new System.Windows.Forms.Label();
            this.LblGeschlosseneFelder = new System.Windows.Forms.Label();
            this.LblOffeneFelder1 = new System.Windows.Forms.Label();
            this.LblShowScore = new System.Windows.Forms.Label();
            this.LblOffeneFelder = new System.Windows.Forms.Label();
            this.LblLEBEN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHARD = new System.Windows.Forms.Button();
            this.BtnMEDIUM = new System.Windows.Forms.Button();
            this.BtnEASY = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTimerShow = new System.Windows.Forms.Label();
            this.LblAnzahlBombenSHOW = new System.Windows.Forms.Label();
            this.LblTimer = new System.Windows.Forms.Label();
            this.LblAnzahlBomben = new System.Windows.Forms.Label();
            this.PanelScoreTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Neues Spiel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // PanelPlayfield
            // 
            this.PanelPlayfield.Location = new System.Drawing.Point(12, 168);
            this.PanelPlayfield.Name = "PanelPlayfield";
            this.PanelPlayfield.Size = new System.Drawing.Size(434, 442);
            this.PanelPlayfield.TabIndex = 1;
            // 
            // PanelScoreTop
            // 
            this.PanelScoreTop.Controls.Add(this.LblGeschlossenFelder1);
            this.PanelScoreTop.Controls.Add(this.LblGeschlosseneFelder);
            this.PanelScoreTop.Controls.Add(this.LblOffeneFelder1);
            this.PanelScoreTop.Controls.Add(this.LblShowScore);
            this.PanelScoreTop.Controls.Add(this.LblOffeneFelder);
            this.PanelScoreTop.Controls.Add(this.LblLEBEN);
            this.PanelScoreTop.Location = new System.Drawing.Point(12, 616);
            this.PanelScoreTop.Name = "PanelScoreTop";
            this.PanelScoreTop.Size = new System.Drawing.Size(434, 73);
            this.PanelScoreTop.TabIndex = 2;
            // 
            // LblGeschlossenFelder1
            // 
            this.LblGeschlossenFelder1.BackColor = System.Drawing.Color.Black;
            this.LblGeschlossenFelder1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblGeschlossenFelder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGeschlossenFelder1.ForeColor = System.Drawing.Color.Yellow;
            this.LblGeschlossenFelder1.Location = new System.Drawing.Point(326, 13);
            this.LblGeschlossenFelder1.Name = "LblGeschlossenFelder1";
            this.LblGeschlossenFelder1.Size = new System.Drawing.Size(60, 40);
            this.LblGeschlossenFelder1.TabIndex = 6;
            this.LblGeschlossenFelder1.Text = "0";
            this.LblGeschlossenFelder1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGeschlosseneFelder
            // 
            this.LblGeschlosseneFelder.AutoSize = true;
            this.LblGeschlosseneFelder.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGeschlosseneFelder.ForeColor = System.Drawing.Color.DarkRed;
            this.LblGeschlosseneFelder.Location = new System.Drawing.Point(271, 11);
            this.LblGeschlosseneFelder.Name = "LblGeschlosseneFelder";
            this.LblGeschlosseneFelder.Size = new System.Drawing.Size(49, 41);
            this.LblGeschlosseneFelder.TabIndex = 5;
            this.LblGeschlosseneFelder.Text = "🔒";
            // 
            // LblOffeneFelder1
            // 
            this.LblOffeneFelder1.BackColor = System.Drawing.Color.Black;
            this.LblOffeneFelder1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOffeneFelder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOffeneFelder1.ForeColor = System.Drawing.Color.Yellow;
            this.LblOffeneFelder1.Location = new System.Drawing.Point(204, 11);
            this.LblOffeneFelder1.Name = "LblOffeneFelder1";
            this.LblOffeneFelder1.Size = new System.Drawing.Size(60, 40);
            this.LblOffeneFelder1.TabIndex = 4;
            this.LblOffeneFelder1.Text = "0";
            this.LblOffeneFelder1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblShowScore
            // 
            this.LblShowScore.BackColor = System.Drawing.Color.Black;
            this.LblShowScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowScore.ForeColor = System.Drawing.Color.Yellow;
            this.LblShowScore.Location = new System.Drawing.Point(69, 12);
            this.LblShowScore.Name = "LblShowScore";
            this.LblShowScore.Size = new System.Drawing.Size(60, 40);
            this.LblShowScore.TabIndex = 2;
            this.LblShowScore.Text = "0";
            this.LblShowScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblOffeneFelder
            // 
            this.LblOffeneFelder.AutoSize = true;
            this.LblOffeneFelder.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOffeneFelder.ForeColor = System.Drawing.Color.LimeGreen;
            this.LblOffeneFelder.Location = new System.Drawing.Point(149, 13);
            this.LblOffeneFelder.Name = "LblOffeneFelder";
            this.LblOffeneFelder.Size = new System.Drawing.Size(49, 41);
            this.LblOffeneFelder.TabIndex = 1;
            this.LblOffeneFelder.Text = "🔓";
            this.LblOffeneFelder.Click += new System.EventHandler(this.LblTOP_Click);
            // 
            // LblLEBEN
            // 
            this.LblLEBEN.AutoSize = true;
            this.LblLEBEN.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLEBEN.ForeColor = System.Drawing.Color.Red;
            this.LblLEBEN.Location = new System.Drawing.Point(15, 12);
            this.LblLEBEN.Name = "LblLEBEN";
            this.LblLEBEN.Size = new System.Drawing.Size(48, 41);
            this.LblLEBEN.TabIndex = 0;
            this.LblLEBEN.Text = "❤️";
            this.LblLEBEN.Click += new System.EventHandler(this.SCORE_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnHARD);
            this.panel1.Controls.Add(this.BtnMEDIUM);
            this.panel1.Controls.Add(this.BtnEASY);
            this.panel1.Location = new System.Drawing.Point(12, 711);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 73);
            this.panel1.TabIndex = 4;
            // 
            // BtnHARD
            // 
            this.BtnHARD.BackColor = System.Drawing.Color.Red;
            this.BtnHARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHARD.ForeColor = System.Drawing.Color.Black;
            this.BtnHARD.Location = new System.Drawing.Point(305, 14);
            this.BtnHARD.Name = "BtnHARD";
            this.BtnHARD.Size = new System.Drawing.Size(104, 45);
            this.BtnHARD.TabIndex = 2;
            this.BtnHARD.Text = "HARD";
            this.BtnHARD.UseVisualStyleBackColor = false;
            this.BtnHARD.Click += new System.EventHandler(this.BtnHARD_Click);
            // 
            // BtnMEDIUM
            // 
            this.BtnMEDIUM.BackColor = System.Drawing.Color.Orange;
            this.BtnMEDIUM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMEDIUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMEDIUM.ForeColor = System.Drawing.Color.Black;
            this.BtnMEDIUM.Location = new System.Drawing.Point(160, 14);
            this.BtnMEDIUM.Name = "BtnMEDIUM";
            this.BtnMEDIUM.Size = new System.Drawing.Size(104, 45);
            this.BtnMEDIUM.TabIndex = 1;
            this.BtnMEDIUM.Text = "MEDIUM";
            this.BtnMEDIUM.UseVisualStyleBackColor = false;
            this.BtnMEDIUM.Click += new System.EventHandler(this.BtnMEDIUM_Click);
            // 
            // BtnEASY
            // 
            this.BtnEASY.BackColor = System.Drawing.Color.Lime;
            this.BtnEASY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEASY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEASY.ForeColor = System.Drawing.Color.Black;
            this.BtnEASY.Location = new System.Drawing.Point(16, 13);
            this.BtnEASY.Name = "BtnEASY";
            this.BtnEASY.Size = new System.Drawing.Size(104, 45);
            this.BtnEASY.TabIndex = 0;
            this.BtnEASY.Text = "EASY";
            this.BtnEASY.UseVisualStyleBackColor = false;
            this.BtnEASY.Click += new System.EventHandler(this.BtnEASY_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblTimerShow);
            this.panel2.Controls.Add(this.LblAnzahlBombenSHOW);
            this.panel2.Controls.Add(this.LblTimer);
            this.panel2.Controls.Add(this.LblAnzahlBomben);
            this.panel2.Location = new System.Drawing.Point(12, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 73);
            this.panel2.TabIndex = 5;
            // 
            // LblTimerShow
            // 
            this.LblTimerShow.AutoSize = true;
            this.LblTimerShow.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimerShow.Location = new System.Drawing.Point(301, 14);
            this.LblTimerShow.Name = "LblTimerShow";
            this.LblTimerShow.Size = new System.Drawing.Size(42, 38);
            this.LblTimerShow.TabIndex = 6;
            this.LblTimerShow.Text = "⏱️";
            this.LblTimerShow.Click += new System.EventHandler(this.LblTimerShow_Click);
            // 
            // LblAnzahlBombenSHOW
            // 
            this.LblAnzahlBombenSHOW.AutoSize = true;
            this.LblAnzahlBombenSHOW.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnzahlBombenSHOW.Location = new System.Drawing.Point(9, 14);
            this.LblAnzahlBombenSHOW.Name = "LblAnzahlBombenSHOW";
            this.LblAnzahlBombenSHOW.Size = new System.Drawing.Size(45, 38);
            this.LblAnzahlBombenSHOW.TabIndex = 5;
            this.LblAnzahlBombenSHOW.Text = "💣";
            // 
            // LblTimer
            // 
            this.LblTimer.BackColor = System.Drawing.Color.Black;
            this.LblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimer.ForeColor = System.Drawing.Color.Red;
            this.LblTimer.Location = new System.Drawing.Point(349, 12);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(60, 40);
            this.LblTimer.TabIndex = 4;
            this.LblTimer.Text = "0";
            this.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAnzahlBomben
            // 
            this.LblAnzahlBomben.BackColor = System.Drawing.Color.Black;
            this.LblAnzahlBomben.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAnzahlBomben.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnzahlBomben.ForeColor = System.Drawing.Color.Red;
            this.LblAnzahlBomben.Location = new System.Drawing.Point(60, 12);
            this.LblAnzahlBomben.Name = "LblAnzahlBomben";
            this.LblAnzahlBomben.Size = new System.Drawing.Size(60, 40);
            this.LblAnzahlBomben.TabIndex = 2;
            this.LblAnzahlBomben.Text = "0";
            this.LblAnzahlBomben.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAnzahlBomben.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(458, 796);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelScoreTop);
            this.Controls.Add(this.PanelPlayfield);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelScoreTop.ResumeLayout(false);
            this.PanelScoreTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel PanelScoreTop;
        private System.Windows.Forms.Label LblLEBEN;
        private System.Windows.Forms.Label LblOffeneFelder;
        private System.Windows.Forms.Label LblShowScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnHARD;
        private System.Windows.Forms.Button BtnMEDIUM;
        private System.Windows.Forms.Button BtnEASY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblAnzahlBomben;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Label LblOffeneFelder1;
        private System.Windows.Forms.Label LblGeschlossenFelder1;
        private System.Windows.Forms.Label LblGeschlosseneFelder;
        private System.Windows.Forms.Label LblAnzahlBombenSHOW;
        private System.Windows.Forms.Label LblTimerShow;
    }
}
