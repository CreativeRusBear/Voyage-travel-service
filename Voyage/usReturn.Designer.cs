namespace Voyage
{
    partial class usReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usReturn));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addNewClientsWithSales = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_Group = new System.Windows.Forms.Label();
            this.mainElements = new System.Windows.Forms.Panel();
            this.textAboutSale = new System.Windows.Forms.Label();
            this.cbRoutes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(369, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Возвраты";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(532, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // addNewClientsWithSales
            // 
            this.addNewClientsWithSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewClientsWithSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewClientsWithSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewClientsWithSales.Image = ((System.Drawing.Image)(resources.GetObject("addNewClientsWithSales.Image")));
            this.addNewClientsWithSales.Location = new System.Drawing.Point(341, 752);
            this.addNewClientsWithSales.Name = "addNewClientsWithSales";
            this.addNewClientsWithSales.Size = new System.Drawing.Size(275, 77);
            this.addNewClientsWithSales.TabIndex = 6;
            this.addNewClientsWithSales.Text = "     Вернуть деньги";
            this.addNewClientsWithSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewClientsWithSales.UseVisualStyleBackColor = true;
            this.addNewClientsWithSales.Click += new System.EventHandler(this.addNewClientsWithSales_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 57);
            this.label3.TabIndex = 8;
            this.label3.Text = "Рассмотрение возврата осуществляется в течении 7 рабочих дней";
            // 
            // ID_Group
            // 
            this.ID_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID_Group.AutoSize = true;
            this.ID_Group.Location = new System.Drawing.Point(546, 197);
            this.ID_Group.Name = "ID_Group";
            this.ID_Group.Size = new System.Drawing.Size(57, 21);
            this.ID_Group.TabIndex = 9;
            this.ID_Group.Text = "label4";
            // 
            // mainElements
            // 
            this.mainElements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainElements.Controls.Add(this.textAboutSale);
            this.mainElements.Controls.Add(this.cbRoutes);
            this.mainElements.Controls.Add(this.label2);
            this.mainElements.Location = new System.Drawing.Point(51, 246);
            this.mainElements.Name = "mainElements";
            this.mainElements.Size = new System.Drawing.Size(449, 319);
            this.mainElements.TabIndex = 10;
            // 
            // textAboutSale
            // 
            this.textAboutSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAboutSale.BackColor = System.Drawing.Color.Transparent;
            this.textAboutSale.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAboutSale.Location = new System.Drawing.Point(22, 202);
            this.textAboutSale.Name = "textAboutSale";
            this.textAboutSale.Size = new System.Drawing.Size(405, 88);
            this.textAboutSale.TabIndex = 10;
            this.textAboutSale.Text = "Возврат денежных средств из общей суммы составляет ...%";
            // 
            // cbRoutes
            // 
            this.cbRoutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRoutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoutes.FormattingEnabled = true;
            this.cbRoutes.Location = new System.Drawing.Point(26, 81);
            this.cbRoutes.Name = "cbRoutes";
            this.cbRoutes.Size = new System.Drawing.Size(255, 29);
            this.cbRoutes.TabIndex = 9;
            this.cbRoutes.DropDownClosed += new System.EventHandler(this.cbRoutes_DropDownClosed);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите название маршрута";
            // 
            // usReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainElements);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addNewClientsWithSales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_Group);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "usReturn";
            this.Size = new System.Drawing.Size(997, 886);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainElements.ResumeLayout(false);
            this.mainElements.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addNewClientsWithSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ID_Group;
        private System.Windows.Forms.Panel mainElements;
        private System.Windows.Forms.Label textAboutSale;
        private System.Windows.Forms.ComboBox cbRoutes;
        private System.Windows.Forms.Label label2;
    }
}
