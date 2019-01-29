namespace Voyage
{
    partial class createNewGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createNewGroup));
            this.saveBtn = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRoutes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragComponent1 = new Voyage.DragComponent();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(827, 645);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 60);
            this.saveBtn.TabIndex = 167;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tbCount
            // 
            this.tbCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCount.Location = new System.Drawing.Point(322, 542);
            this.tbCount.Mask = "00";
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(357, 27);
            this.tbCount.TabIndex = 165;
            this.tbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(409, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 159;
            this.label1.Text = "Новая группа ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 161;
            this.label3.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.Location = new System.Drawing.Point(322, 446);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(357, 27);
            this.tbName.TabIndex = 162;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 160;
            this.label4.Text = "Маршрут";
            // 
            // cbRoutes
            // 
            this.cbRoutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRoutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoutes.FormattingEnabled = true;
            this.cbRoutes.Location = new System.Drawing.Point(322, 636);
            this.cbRoutes.Name = "cbRoutes";
            this.cbRoutes.Size = new System.Drawing.Size(357, 29);
            this.cbRoutes.TabIndex = 164;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(324, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 21);
            this.label5.TabIndex = 163;
            this.label5.Text = "Максимальное количество туристов";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.shutdownBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(926, 76);
            this.topPanel.TabIndex = 168;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(851, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.shutdownBtn.FlatAppearance.BorderSize = 0;
            this.shutdownBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.shutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdownBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shutdownBtn.ForeColor = System.Drawing.Color.White;
            this.shutdownBtn.Image = ((System.Drawing.Image)(resources.GetObject("shutdownBtn.Image")));
            this.shutdownBtn.Location = new System.Drawing.Point(0, 0);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Size = new System.Drawing.Size(122, 76);
            this.shutdownBtn.TabIndex = 12;
            this.shutdownBtn.UseVisualStyleBackColor = true;
            this.shutdownBtn.Click += new System.EventHandler(this.shutdownBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dragComponent1
            // 
            this.dragComponent1.SelectControl = this.topPanel;
            // 
            // createNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 717);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRoutes);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "createNewGroup";
            this.Text = "createNewGroup";
            this.Load += new System.EventHandler(this.createNewGroup_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.MaskedTextBox tbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRoutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button shutdownBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DragComponent dragComponent1;
    }
}