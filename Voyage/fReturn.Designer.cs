namespace Voyage
{
    partial class fReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReturn));
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.dragComponent1 = new Voyage.DragComponent();
            this.cbCauses = new System.Windows.Forms.ComboBox();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewClientsWithSales = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.topPanel.TabIndex = 233;
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
            // cbCauses
            // 
            this.cbCauses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCauses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCauses.FormattingEnabled = true;
            this.cbCauses.Items.AddRange(new object[] {
            "Отмена или задержка рейса",
            "Отказ в выдаче шенгенской визы",
            "Задолжность",
            "Изменения перевозчиком маршрута перевозки",
            "Задержка пассажира в аэропорту из-за продолжительности проведения досмотра",
            "Внезапная болезнь пассажира",
            "Добровольный отказ",
            "Другое"});
            this.cbCauses.Location = new System.Drawing.Point(137, 585);
            this.cbCauses.Name = "cbCauses";
            this.cbCauses.Size = new System.Drawing.Size(464, 29);
            this.cbCauses.TabIndex = 248;
            // 
            // cbClients
            // 
            this.cbClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(137, 462);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(464, 29);
            this.cbClients.TabIndex = 249;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 246;
            this.label4.Text = "Причина возврата";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 21);
            this.label1.TabIndex = 247;
            this.label1.Text = "Выберите клиента, которому необходимо вернуть деньги";
            // 
            // addNewClientsWithSales
            // 
            this.addNewClientsWithSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewClientsWithSales.Enabled = false;
            this.addNewClientsWithSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewClientsWithSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewClientsWithSales.Image = ((System.Drawing.Image)(resources.GetObject("addNewClientsWithSales.Image")));
            this.addNewClientsWithSales.Location = new System.Drawing.Point(270, 674);
            this.addNewClientsWithSales.Name = "addNewClientsWithSales";
            this.addNewClientsWithSales.Size = new System.Drawing.Size(201, 74);
            this.addNewClientsWithSales.TabIndex = 243;
            this.addNewClientsWithSales.Text = "     Вернуть";
            this.addNewClientsWithSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewClientsWithSales.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 245;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(236, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 28);
            this.label2.TabIndex = 244;
            this.label2.Text = "Работа с клиентами";
            // 
            // fReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 772);
            this.Controls.Add(this.cbCauses);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewClientsWithSales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "fReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fReturn";
            this.Load += new System.EventHandler(this.fReturn_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button shutdownBtn;
        private DragComponent dragComponent1;
        private System.Windows.Forms.ComboBox cbCauses;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewClientsWithSales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}