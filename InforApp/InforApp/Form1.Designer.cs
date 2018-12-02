namespace InforApp
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

        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnStudy;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnClose;
        private DragControl _dragControl;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.btnMiniWin = new System.Windows.Forms.Button();
            this.btnMaxiWindow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnStudy = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this._dragControl = new InforApp.DragControl();
            this.pnlTopMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopMenu.BackColor = System.Drawing.Color.Black;
            this.pnlTopMenu.Controls.Add(this.btnMiniWin);
            this.pnlTopMenu.Controls.Add(this.btnMaxiWindow);
            this.pnlTopMenu.Controls.Add(this.btnClose);
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(1080, 25);
            this.pnlTopMenu.TabIndex = 0;
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.Location = new System.Drawing.Point(80, 25);
            this.pnlUserControl.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(1000, 680);
            this.pnlUserControl.TabIndex = 2;
            // 
            // btnMiniWin
            // 
            this.btnMiniWin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniWin.Location = new System.Drawing.Point(990, 0);
            this.btnMiniWin.Name = "btnMiniWin";
            this.btnMiniWin.Size = new System.Drawing.Size(25, 25);
            this.btnMiniWin.TabIndex = 9;
            this.btnMiniWin.UseVisualStyleBackColor = true;
            this.btnMiniWin.Click += new System.EventHandler(this.btnMiniWin_Click);
            // 
            // btnMaxiWindow
            // 
            this.btnMaxiWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxiWindow.Location = new System.Drawing.Point(1020, 0);
            this.btnMaxiWindow.Name = "btnMaxiWindow";
            this.btnMaxiWindow.Size = new System.Drawing.Size(25, 25);
            this.btnMaxiWindow.TabIndex = 8;
            this.btnMaxiWindow.UseVisualStyleBackColor = true;
            this.btnMaxiWindow.Click += new System.EventHandler(this.btnMaxiWindow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1050, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnContact);
            this.panel1.Controls.Add(this.btnStudy);
            this.panel1.Controls.Add(this.btnWork);
            this.panel1.Controls.Add(this.btnNote);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 680);
            this.panel1.TabIndex = 1;
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.Transparent;
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.ForeColor = System.Drawing.Color.Transparent;
            this.btnContact.Image = ((System.Drawing.Image)(resources.GetObject("btnContact.Image")));
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContact.Location = new System.Drawing.Point(0, 308);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(80, 80);
            this.btnContact.TabIndex = 4;
            this.btnContact.Text = "Contact";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnStudy
            // 
            this.btnStudy.BackColor = System.Drawing.Color.Transparent;
            this.btnStudy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudy.FlatAppearance.BorderSize = 0;
            this.btnStudy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudy.ForeColor = System.Drawing.Color.Transparent;
            this.btnStudy.Image = ((System.Drawing.Image)(resources.GetObject("btnStudy.Image")));
            this.btnStudy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStudy.Location = new System.Drawing.Point(0, 231);
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.Size = new System.Drawing.Size(80, 80);
            this.btnStudy.TabIndex = 3;
            this.btnStudy.Text = "Study";
            this.btnStudy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudy.UseVisualStyleBackColor = true;
            this.btnStudy.Click += new System.EventHandler(this.btnStudy_Click);
            // 
            // btnWork
            // 
            this.btnWork.BackColor = System.Drawing.Color.Transparent;
            this.btnWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWork.FlatAppearance.BorderSize = 0;
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.ForeColor = System.Drawing.Color.Transparent;
            this.btnWork.Image = ((System.Drawing.Image)(resources.GetObject("btnWork.Image")));
            this.btnWork.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWork.Location = new System.Drawing.Point(0, 154);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(80, 80);
            this.btnWork.TabIndex = 2;
            this.btnWork.Text = "Work";
            this.btnWork.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.Color.Transparent;
            this.btnNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNote.FlatAppearance.BorderSize = 0;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.ForeColor = System.Drawing.Color.Transparent;
            this.btnNote.Image = ((System.Drawing.Image)(resources.GetObject("btnNote.Image")));
            this.btnNote.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNote.Location = new System.Drawing.Point(0, 77);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(80, 80);
            this.btnNote.TabIndex = 1;
            this.btnNote.Text = "Note";
            this.btnNote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(80, 80);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Home";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // _dragControl
            // 
            this._dragControl.SelectControl = this.pnlTopMenu;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1080, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopMenu);
            this.Controls.Add(this.pnlUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 680);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlTopMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnMaxiWindow;
        private System.Windows.Forms.Button btnMiniWin;
        private System.Windows.Forms.Panel pnlUserControl;
    }
}

