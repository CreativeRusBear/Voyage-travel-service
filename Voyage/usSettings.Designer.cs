namespace Voyage
{
    partial class usSettings
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbChangePassword = new System.Windows.Forms.CheckBox();
            this.panelForChange = new System.Windows.Forms.Panel();
            this.changeBtn = new System.Windows.Forms.Button();
            this.seePassword = new System.Windows.Forms.CheckBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lNewPassword = new System.Windows.Forms.Label();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.lOldPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelForChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(265, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки вашего профиля";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbChangePassword
            // 
            this.cbChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbChangePassword.AutoSize = true;
            this.cbChangePassword.Location = new System.Drawing.Point(393, 417);
            this.cbChangePassword.Name = "cbChangePassword";
            this.cbChangePassword.Size = new System.Drawing.Size(296, 25);
            this.cbChangePassword.TabIndex = 16;
            this.cbChangePassword.Text = "Хотите сменить текущий пароль?";
            this.cbChangePassword.UseVisualStyleBackColor = true;
            this.cbChangePassword.CheckedChanged += new System.EventHandler(this.cbChangePassword_CheckedChanged);
            // 
            // panelForChange
            // 
            this.panelForChange.Controls.Add(this.changeBtn);
            this.panelForChange.Controls.Add(this.seePassword);
            this.panelForChange.Controls.Add(this.tbNewPassword);
            this.panelForChange.Controls.Add(this.lNewPassword);
            this.panelForChange.Controls.Add(this.tbOldPassword);
            this.panelForChange.Controls.Add(this.lOldPassword);
            this.panelForChange.Location = new System.Drawing.Point(273, 512);
            this.panelForChange.Name = "panelForChange";
            this.panelForChange.Size = new System.Drawing.Size(531, 343);
            this.panelForChange.TabIndex = 17;
            this.panelForChange.Visible = false;
            // 
            // changeBtn
            // 
            this.changeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.changeBtn.FlatAppearance.BorderSize = 0;
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBtn.ForeColor = System.Drawing.Color.White;
            this.changeBtn.Location = new System.Drawing.Point(41, 274);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(452, 45);
            this.changeBtn.TabIndex = 21;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = false;
            // 
            // seePassword
            // 
            this.seePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seePassword.AutoSize = true;
            this.seePassword.Location = new System.Drawing.Point(41, 208);
            this.seePassword.Name = "seePassword";
            this.seePassword.Size = new System.Drawing.Size(164, 25);
            this.seePassword.TabIndex = 20;
            this.seePassword.Text = "Показать пароль";
            this.seePassword.UseVisualStyleBackColor = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewPassword.Location = new System.Drawing.Point(41, 148);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(452, 31);
            this.tbNewPassword.TabIndex = 19;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // lNewPassword
            // 
            this.lNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNewPassword.AutoSize = true;
            this.lNewPassword.Location = new System.Drawing.Point(37, 113);
            this.lNewPassword.Name = "lNewPassword";
            this.lNewPassword.Size = new System.Drawing.Size(126, 21);
            this.lNewPassword.TabIndex = 18;
            this.lNewPassword.Text = "Новый пароль:";
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOldPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOldPassword.Location = new System.Drawing.Point(41, 62);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(452, 31);
            this.tbOldPassword.TabIndex = 17;
            // 
            // lOldPassword
            // 
            this.lOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lOldPassword.AutoSize = true;
            this.lOldPassword.Location = new System.Drawing.Point(37, 23);
            this.lOldPassword.Name = "lOldPassword";
            this.lOldPassword.Size = new System.Drawing.Size(139, 21);
            this.lOldPassword.TabIndex = 16;
            this.lOldPassword.Text = "Старый пароль:";
            // 
            // usSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelForChange);
            this.Controls.Add(this.cbChangePassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "usSettings";
            this.Size = new System.Drawing.Size(997, 886);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelForChange.ResumeLayout(false);
            this.panelForChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbChangePassword;
        private System.Windows.Forms.Panel panelForChange;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.CheckBox seePassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lNewPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label lOldPassword;
    }
}
