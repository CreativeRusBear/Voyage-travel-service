namespace Voyage
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.backBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lCopyright = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.seePassword = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.lLogAndPassword = new System.Windows.Forms.Label();
            this.pbSectionLogo = new System.Windows.Forms.PictureBox();
            this.lLog = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSectionLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(122, 76);
            this.backBtn.TabIndex = 12;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topPanel.Controls.Add(this.backBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(926, 76);
            this.topPanel.TabIndex = 11;
            // 
            // lCopyright
            // 
            this.lCopyright.AutoSize = true;
            this.lCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCopyright.Location = new System.Drawing.Point(9, 695);
            this.lCopyright.Name = "lCopyright";
            this.lCopyright.Size = new System.Drawing.Size(205, 17);
            this.lCopyright.TabIndex = 20;
            this.lCopyright.Text = "Copyright © Gusev Artem 2019";
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(243, 601);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(452, 45);
            this.signInBtn.TabIndex = 19;
            this.signInBtn.Text = "Войти";
            this.signInBtn.UseVisualStyleBackColor = false;
            // 
            // seePassword
            // 
            this.seePassword.AutoSize = true;
            this.seePassword.Location = new System.Drawing.Point(243, 558);
            this.seePassword.Name = "seePassword";
            this.seePassword.Size = new System.Drawing.Size(164, 25);
            this.seePassword.TabIndex = 18;
            this.seePassword.Text = "Показать пароль";
            this.seePassword.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(243, 505);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(452, 31);
            this.tbPassword.TabIndex = 17;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(239, 472);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(74, 21);
            this.lPassword.TabIndex = 16;
            this.lPassword.Text = "Пароль:";
            // 
            // tbLog
            // 
            this.tbLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLog.Location = new System.Drawing.Point(243, 419);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(452, 31);
            this.tbLog.TabIndex = 15;
            // 
            // lLogAndPassword
            // 
            this.lLogAndPassword.AutoSize = true;
            this.lLogAndPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLogAndPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lLogAndPassword.Location = new System.Drawing.Point(238, 337);
            this.lLogAndPassword.Name = "lLogAndPassword";
            this.lLogAndPassword.Size = new System.Drawing.Size(457, 25);
            this.lLogAndPassword.TabIndex = 14;
            this.lLogAndPassword.Text = "Пожалуйста, введите ваш логин и пароль";
            // 
            // pbSectionLogo
            // 
            this.pbSectionLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbSectionLogo.Image")));
            this.pbSectionLogo.Location = new System.Drawing.Point(315, 86);
            this.pbSectionLogo.Name = "pbSectionLogo";
            this.pbSectionLogo.Size = new System.Drawing.Size(308, 262);
            this.pbSectionLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSectionLogo.TabIndex = 13;
            this.pbSectionLogo.TabStop = false;
            // 
            // lLog
            // 
            this.lLog.AutoSize = true;
            this.lLog.Location = new System.Drawing.Point(239, 386);
            this.lLog.Name = "lLog";
            this.lLog.Size = new System.Drawing.Size(61, 21);
            this.lLog.TabIndex = 12;
            this.lLog.Text = "Логин:";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 717);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.lCopyright);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.seePassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.lLogAndPassword);
            this.Controls.Add(this.pbSectionLogo);
            this.Controls.Add(this.lLog);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSectionLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lCopyright;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.CheckBox seePassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label lLogAndPassword;
        private System.Windows.Forms.PictureBox pbSectionLogo;
        private System.Windows.Forms.Label lLog;
    }
}