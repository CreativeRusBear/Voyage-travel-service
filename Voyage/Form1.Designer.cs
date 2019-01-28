namespace Voyage
{
    partial class fAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAuthorization));
            this.topPanel = new System.Windows.Forms.Panel();
            this.regBtn = new System.Windows.Forms.Button();
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.lLog = new System.Windows.Forms.Label();
            this.pbSectionLogo = new System.Windows.Forms.PictureBox();
            this.lLogAndPassword = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.seePassword = new System.Windows.Forms.CheckBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.lCopyright = new System.Windows.Forms.Label();
            this.pbGitHub = new System.Windows.Forms.PictureBox();
            this.pbSite = new System.Windows.Forms.PictureBox();
            this.pbDocs = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSectionLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topPanel.Controls.Add(this.regBtn);
            this.topPanel.Controls.Add(this.shutdownBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(926, 76);
            this.topPanel.TabIndex = 0;
            // 
            // regBtn
            // 
            this.regBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regBtn.ForeColor = System.Drawing.Color.White;
            this.regBtn.Image = ((System.Drawing.Image)(resources.GetObject("regBtn.Image")));
            this.regBtn.Location = new System.Drawing.Point(0, 0);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(122, 76);
            this.regBtn.TabIndex = 12;
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.shutdownBtn.FlatAppearance.BorderSize = 0;
            this.shutdownBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.shutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdownBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shutdownBtn.ForeColor = System.Drawing.Color.White;
            this.shutdownBtn.Image = ((System.Drawing.Image)(resources.GetObject("shutdownBtn.Image")));
            this.shutdownBtn.Location = new System.Drawing.Point(804, 0);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Size = new System.Drawing.Size(122, 76);
            this.shutdownBtn.TabIndex = 11;
            this.shutdownBtn.UseVisualStyleBackColor = true;
            this.shutdownBtn.Click += new System.EventHandler(this.shutdownBtn_Click);
            // 
            // lLog
            // 
            this.lLog.AutoSize = true;
            this.lLog.Location = new System.Drawing.Point(239, 382);
            this.lLog.Name = "lLog";
            this.lLog.Size = new System.Drawing.Size(61, 21);
            this.lLog.TabIndex = 1;
            this.lLog.Text = "Логин:";
            // 
            // pbSectionLogo
            // 
            this.pbSectionLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbSectionLogo.Image")));
            this.pbSectionLogo.Location = new System.Drawing.Point(315, 82);
            this.pbSectionLogo.Name = "pbSectionLogo";
            this.pbSectionLogo.Size = new System.Drawing.Size(308, 262);
            this.pbSectionLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSectionLogo.TabIndex = 2;
            this.pbSectionLogo.TabStop = false;
            // 
            // lLogAndPassword
            // 
            this.lLogAndPassword.AutoSize = true;
            this.lLogAndPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLogAndPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lLogAndPassword.Location = new System.Drawing.Point(238, 333);
            this.lLogAndPassword.Name = "lLogAndPassword";
            this.lLogAndPassword.Size = new System.Drawing.Size(457, 25);
            this.lLogAndPassword.TabIndex = 4;
            this.lLogAndPassword.Text = "Пожалуйста, введите ваш логин и пароль";
            // 
            // tbLog
            // 
            this.tbLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLog.Location = new System.Drawing.Point(243, 415);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(452, 31);
            this.tbLog.TabIndex = 5;
            this.tbLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLog_KeyPress);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(243, 501);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(452, 31);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLog_KeyPress);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(239, 468);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(74, 21);
            this.lPassword.TabIndex = 6;
            this.lPassword.Text = "Пароль:";
            // 
            // seePassword
            // 
            this.seePassword.AutoSize = true;
            this.seePassword.Location = new System.Drawing.Point(243, 554);
            this.seePassword.Name = "seePassword";
            this.seePassword.Size = new System.Drawing.Size(164, 25);
            this.seePassword.TabIndex = 8;
            this.seePassword.Text = "Показать пароль";
            this.seePassword.UseVisualStyleBackColor = true;
            this.seePassword.CheckedChanged += new System.EventHandler(this.seePassword_CheckedChanged);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(243, 597);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(452, 45);
            this.signInBtn.TabIndex = 9;
            this.signInBtn.Text = "Войти";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // lCopyright
            // 
            this.lCopyright.AutoSize = true;
            this.lCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCopyright.Location = new System.Drawing.Point(9, 691);
            this.lCopyright.Name = "lCopyright";
            this.lCopyright.Size = new System.Drawing.Size(205, 17);
            this.lCopyright.TabIndex = 10;
            this.lCopyright.Text = "Copyright © Gusev Artem 2019";
            // 
            // pbGitHub
            // 
            this.pbGitHub.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbGitHub.Image = ((System.Drawing.Image)(resources.GetObject("pbGitHub.Image")));
            this.pbGitHub.Location = new System.Drawing.Point(880, 675);
            this.pbGitHub.Name = "pbGitHub";
            this.pbGitHub.Size = new System.Drawing.Size(34, 33);
            this.pbGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGitHub.TabIndex = 2;
            this.pbGitHub.TabStop = false;
            this.pbGitHub.Click += new System.EventHandler(this.pbGitHub_Click);
            // 
            // pbSite
            // 
            this.pbSite.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbSite.Image = ((System.Drawing.Image)(resources.GetObject("pbSite.Image")));
            this.pbSite.Location = new System.Drawing.Point(800, 675);
            this.pbSite.Name = "pbSite";
            this.pbSite.Size = new System.Drawing.Size(34, 33);
            this.pbSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSite.TabIndex = 2;
            this.pbSite.TabStop = false;
            this.pbSite.Click += new System.EventHandler(this.pbSite_Click);
            // 
            // pbDocs
            // 
            this.pbDocs.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbDocs.Image = ((System.Drawing.Image)(resources.GetObject("pbDocs.Image")));
            this.pbDocs.Location = new System.Drawing.Point(840, 675);
            this.pbDocs.Name = "pbDocs";
            this.pbDocs.Size = new System.Drawing.Size(34, 33);
            this.pbDocs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDocs.TabIndex = 2;
            this.pbDocs.TabStop = false;
            this.pbDocs.Click += new System.EventHandler(this.pbDocs_Click);
            // 
            // fAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 717);
            this.Controls.Add(this.lCopyright);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.seePassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.lLogAndPassword);
            this.Controls.Add(this.pbDocs);
            this.Controls.Add(this.pbSite);
            this.Controls.Add(this.pbGitHub);
            this.Controls.Add(this.pbSectionLogo);
            this.Controls.Add(this.lLog);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fAuthorization_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSectionLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lLog;
        private System.Windows.Forms.PictureBox pbSectionLogo;
        private System.Windows.Forms.Label lLogAndPassword;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.CheckBox seePassword;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label lCopyright;
        private System.Windows.Forms.Button shutdownBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.PictureBox pbGitHub;
        private System.Windows.Forms.PictureBox pbSite;
        private System.Windows.Forms.PictureBox pbDocs;
    }
}

