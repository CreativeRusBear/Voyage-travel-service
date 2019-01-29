namespace Voyage
{
    partial class workWithClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workWithClients));
            this.delPunct = new System.Windows.Forms.Button();
            this.addPunct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lFreePlacesCount = new System.Windows.Forms.Label();
            this.cbClientsInThisGroup = new System.Windows.Forms.ComboBox();
            this.cbAllClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.dragComponent1 = new Voyage.DragComponent();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // delPunct
            // 
            this.delPunct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delPunct.BackColor = System.Drawing.Color.Crimson;
            this.delPunct.FlatAppearance.BorderSize = 0;
            this.delPunct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.delPunct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delPunct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delPunct.ForeColor = System.Drawing.Color.White;
            this.delPunct.Location = new System.Drawing.Point(404, 622);
            this.delPunct.Name = "delPunct";
            this.delPunct.Size = new System.Drawing.Size(50, 42);
            this.delPunct.TabIndex = 212;
            this.delPunct.Text = "-";
            this.delPunct.UseVisualStyleBackColor = false;
            this.delPunct.Click += new System.EventHandler(this.delPunct_Click);
            // 
            // addPunct
            // 
            this.addPunct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPunct.BackColor = System.Drawing.Color.DodgerBlue;
            this.addPunct.FlatAppearance.BorderSize = 0;
            this.addPunct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.addPunct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPunct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPunct.ForeColor = System.Drawing.Color.White;
            this.addPunct.Location = new System.Drawing.Point(348, 622);
            this.addPunct.Name = "addPunct";
            this.addPunct.Size = new System.Drawing.Size(50, 42);
            this.addPunct.TabIndex = 213;
            this.addPunct.Text = "+";
            this.addPunct.UseVisualStyleBackColor = false;
            this.addPunct.Click += new System.EventHandler(this.addPunct_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(198, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 21);
            this.label6.TabIndex = 205;
            this.label6.Text = "Клиенты, которые находятся в списке этой группы";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(308, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 206;
            this.label3.Text = "Список всех клиентов";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(282, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 21);
            this.label5.TabIndex = 207;
            this.label5.Text = "Количество свободных мест:";
            // 
            // lFreePlacesCount
            // 
            this.lFreePlacesCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lFreePlacesCount.AutoSize = true;
            this.lFreePlacesCount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFreePlacesCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lFreePlacesCount.Location = new System.Drawing.Point(383, 731);
            this.lFreePlacesCount.Name = "lFreePlacesCount";
            this.lFreePlacesCount.Size = new System.Drawing.Size(34, 24);
            this.lFreePlacesCount.TabIndex = 208;
            this.lFreePlacesCount.Text = "15";
            // 
            // cbClientsInThisGroup
            // 
            this.cbClientsInThisGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClientsInThisGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientsInThisGroup.FormattingEnabled = true;
            this.cbClientsInThisGroup.Location = new System.Drawing.Point(300, 553);
            this.cbClientsInThisGroup.Name = "cbClientsInThisGroup";
            this.cbClientsInThisGroup.Size = new System.Drawing.Size(201, 29);
            this.cbClientsInThisGroup.TabIndex = 209;
            // 
            // cbAllClients
            // 
            this.cbAllClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAllClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllClients.FormattingEnabled = true;
            this.cbAllClients.Location = new System.Drawing.Point(300, 432);
            this.cbAllClients.Name = "cbAllClients";
            this.cbAllClients.Size = new System.Drawing.Size(201, 29);
            this.cbAllClients.TabIndex = 210;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 28);
            this.label1.TabIndex = 202;
            this.label1.Text = "Работа с клиентами";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 214;
            this.pictureBox1.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.shutdownBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(733, 76);
            this.topPanel.TabIndex = 215;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(658, 12);
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
            // dragComponent1
            // 
            this.dragComponent1.SelectControl = this.topPanel;
            // 
            // workWithClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 807);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.delPunct);
            this.Controls.Add(this.addPunct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lFreePlacesCount);
            this.Controls.Add(this.cbClientsInThisGroup);
            this.Controls.Add(this.cbAllClients);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "workWithClients";
            this.Text = "workWithClients";
            this.Load += new System.EventHandler(this.workWithClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delPunct;
        private System.Windows.Forms.Button addPunct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lFreePlacesCount;
        private System.Windows.Forms.ComboBox cbClientsInThisGroup;
        private System.Windows.Forms.ComboBox cbAllClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button shutdownBtn;
        private DragComponent dragComponent1;
    }
}