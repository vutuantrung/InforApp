namespace InforApp
{
    partial class UserControlWork
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCaf = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAmeli = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBank = new System.Windows.Forms.Button();
            this.userControlWorkCaf1 = new InforApp.UserControlWorkContainer.UserControlWorkCaf();
            this.userControlWorkAmeli1 = new InforApp.UserControlWorkContainer.UserControlWorkAmeli();
            this.userControlWorkBank1 = new InforApp.UserControlWorkContainer.UserControlWorkBank();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 50);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCaf);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnAmeli);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnBank);
            this.panel2.Location = new System.Drawing.Point(10, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 600);
            this.panel2.TabIndex = 2;
            // 
            // btnCaf
            // 
            this.btnCaf.Location = new System.Drawing.Point(367, 10);
            this.btnCaf.Name = "btnCaf";
            this.btnCaf.Size = new System.Drawing.Size(235, 115);
            this.btnCaf.TabIndex = 4;
            this.btnCaf.Text = "Caf";
            this.btnCaf.UseVisualStyleBackColor = true;
            this.btnCaf.Click += new System.EventHandler(this.btnCaf_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(487, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 115);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAmeli
            // 
            this.btnAmeli.Location = new System.Drawing.Point(246, 131);
            this.btnAmeli.Name = "btnAmeli";
            this.btnAmeli.Size = new System.Drawing.Size(235, 115);
            this.btnAmeli.TabIndex = 2;
            this.btnAmeli.Text = "Ameli";
            this.btnAmeli.UseVisualStyleBackColor = true;
            this.btnAmeli.Click += new System.EventHandler(this.btnAmeli_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 115);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnBank
            // 
            this.btnBank.Location = new System.Drawing.Point(10, 10);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(230, 235);
            this.btnBank.TabIndex = 0;
            this.btnBank.Text = "Bank";
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // userControlWorkCaf1
            // 
            this.userControlWorkCaf1.BackColor = System.Drawing.Color.GreenYellow;
            this.userControlWorkCaf1.Location = new System.Drawing.Point(635, 70);
            this.userControlWorkCaf1.Name = "userControlWorkCaf1";
            this.userControlWorkCaf1.Size = new System.Drawing.Size(355, 600);
            this.userControlWorkCaf1.TabIndex = 5;
            // 
            // userControlWorkAmeli1
            // 
            this.userControlWorkAmeli1.BackColor = System.Drawing.Color.Aqua;
            this.userControlWorkAmeli1.Location = new System.Drawing.Point(635, 70);
            this.userControlWorkAmeli1.Name = "userControlWorkAmeli1";
            this.userControlWorkAmeli1.Size = new System.Drawing.Size(355, 600);
            this.userControlWorkAmeli1.TabIndex = 4;
            // 
            // userControlWorkBank1
            // 
            this.userControlWorkBank1.BackColor = System.Drawing.Color.Sienna;
            this.userControlWorkBank1.Location = new System.Drawing.Point(635, 70);
            this.userControlWorkBank1.Name = "userControlWorkBank1";
            this.userControlWorkBank1.Size = new System.Drawing.Size(355, 600);
            this.userControlWorkBank1.TabIndex = 3;
            // 
            // UserControlWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.userControlWorkCaf1);
            this.Controls.Add(this.userControlWorkAmeli1);
            this.Controls.Add(this.userControlWorkBank1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlWork";
            this.Size = new System.Drawing.Size(1000, 680);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAmeli;
        private System.Windows.Forms.Button btnCaf;
        private UserControlWorkContainer.UserControlWorkBank userControlWorkBank1;
        private UserControlWorkContainer.UserControlWorkAmeli userControlWorkAmeli1;
        private UserControlWorkContainer.UserControlWorkCaf userControlWorkCaf1;
    }
}
