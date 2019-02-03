namespace Voyage
{
    partial class DataRouteGroupForSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataRouteGroupForSale));
            this.dragComponent1 = new Voyage.DragComponent();
            this.backBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.furtherBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dragComponent1
            // 
            this.dragComponent1.SelectControl = this.topPanel;
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
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.backBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(589, 76);
            this.topPanel.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(511, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // cbGroup
            // 
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Items.AddRange(new object[] {
            "Руководитель",
            "Администратор",
            "Менеджер по работе с клиентами",
            "Менеджер по индивидуальным турам",
            "Менеджер по работе с корпоративными клиентами",
            "Менеджер по бронированию и продажи билетов",
            "Эвент-менеджер",
            "Специалист по паспортно-визовым вопросам и страхованию",
            "Бухгалтер ",
            "Кассир",
            "Турагент"});
            this.cbGroup.Location = new System.Drawing.Point(122, 238);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(342, 29);
            this.cbGroup.TabIndex = 33;
            // 
            // furtherBtn
            // 
            this.furtherBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.furtherBtn.FlatAppearance.BorderSize = 0;
            this.furtherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.furtherBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.furtherBtn.ForeColor = System.Drawing.Color.White;
            this.furtherBtn.Location = new System.Drawing.Point(122, 315);
            this.furtherBtn.Name = "furtherBtn";
            this.furtherBtn.Size = new System.Drawing.Size(342, 45);
            this.furtherBtn.TabIndex = 30;
            this.furtherBtn.Text = "Далее";
            this.furtherBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 42);
            this.label2.TabIndex = 34;
            this.label2.Text = "Продолжим?\r\nВыберите необходимую группу из списка";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataRouteGroupForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.furtherBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "DataRouteGroupForSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DataRouteGroupForSale";
            this.Load += new System.EventHandler(this.DataRouteGroupForSale_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DragComponent dragComponent1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Button furtherBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}