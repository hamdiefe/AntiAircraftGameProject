
namespace AntiAircraftGameProject.Desktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.informationPnl = new System.Windows.Forms.Panel();
            this.antiAircraftPnl = new System.Windows.Forms.Panel();
            this.warAreaPnl = new System.Windows.Forms.Panel();
            this.informationLbl = new System.Windows.Forms.Label();
            this.timerLbl = new System.Windows.Forms.Label();
            this.informationPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationPnl
            // 
            this.informationPnl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.informationPnl.Controls.Add(this.timerLbl);
            this.informationPnl.Controls.Add(this.informationLbl);
            this.informationPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.informationPnl.Location = new System.Drawing.Point(0, 0);
            this.informationPnl.Name = "informationPnl";
            this.informationPnl.Size = new System.Drawing.Size(785, 74);
            this.informationPnl.TabIndex = 0;
            // 
            // antiAircraftPnl
            // 
            this.antiAircraftPnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.antiAircraftPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.antiAircraftPnl.Location = new System.Drawing.Point(0, 400);
            this.antiAircraftPnl.Name = "antiAircraftPnl";
            this.antiAircraftPnl.Size = new System.Drawing.Size(785, 50);
            this.antiAircraftPnl.TabIndex = 1;
            // 
            // warAreaPnl
            // 
            this.warAreaPnl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.warAreaPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warAreaPnl.Location = new System.Drawing.Point(0, 74);
            this.warAreaPnl.Name = "warAreaPnl";
            this.warAreaPnl.Size = new System.Drawing.Size(785, 326);
            this.warAreaPnl.TabIndex = 2;
            // 
            // informationLbl
            // 
            this.informationLbl.AutoSize = true;
            this.informationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.informationLbl.Location = new System.Drawing.Point(36, 9);
            this.informationLbl.Name = "informationLbl";
            this.informationLbl.Size = new System.Drawing.Size(459, 54);
            this.informationLbl.TabIndex = 0;
            this.informationLbl.Text = "Oyunu başlatmak için ENTER tuşuna basın.\r\nUçaksavarı hareket ettirmek için SAĞ/SO" +
    "L YÖN TUŞLARINI kullanın.\r\nAteş etmek için boşluk tuşuna basın.";
            // 
            // timerLbl
            // 
            this.timerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timerLbl.Location = new System.Drawing.Point(647, 9);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(100, 50);
            this.timerLbl.TabIndex = 1;
            this.timerLbl.Text = "0:00";
            this.timerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.warAreaPnl);
            this.Controls.Add(this.antiAircraftPnl);
            this.Controls.Add(this.informationPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Uçak Savar Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.informationPnl.ResumeLayout(false);
            this.informationPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel informationPnl;
        private System.Windows.Forms.Label informationLbl;
        private System.Windows.Forms.Panel antiAircraftPnl;
        private System.Windows.Forms.Panel warAreaPnl;
        private System.Windows.Forms.Label timerLbl;
    }
}

