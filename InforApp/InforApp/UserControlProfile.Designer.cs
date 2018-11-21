using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace InforApp
{
    partial class UserControlProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxProfile = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfile)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(16, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 574);
            this.panel1.TabIndex = 0;
            // 
            // picBoxProfile
            // 
            this.picBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("picBoxProfile.Image")));
            this.picBoxProfile.Location = new System.Drawing.Point(100, 15);
            this.picBoxProfile.Name = "picBoxProfile";
            this.picBoxProfile.Size = new System.Drawing.Size(150, 150);
            this.picBoxProfile.TabIndex = 0;
            this.picBoxProfile.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(14, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 478);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(320, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 401);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Location = new System.Drawing.Point(12, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(606, 112);
            this.panel4.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Location = new System.Drawing.Point(320, 500);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(633, 59);
            this.panel7.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Location = new System.Drawing.Point(12, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(606, 112);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(12, 275);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(606, 112);
            this.panel6.TabIndex = 1;
            // 
            // UserControlProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.picBoxProfile);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlProfile";
            this.Size = new System.Drawing.Size(1000, 680);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfile)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PictureBox picBoxProfile;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
    }
}
