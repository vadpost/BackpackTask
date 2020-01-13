namespace BackpackTask
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.solveButton = new System.Windows.Forms.Button();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowConditionsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice4 = new System.Windows.Forms.TextBox();
            this.txtWeight4 = new System.Windows.Forms.TextBox();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.txtPrice3 = new System.Windows.Forms.TextBox();
            this.txtWeight3 = new System.Windows.Forms.TextBox();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtWeight2 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.AddGoods = new System.Windows.Forms.Button();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.txtWeight1 = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(118, 326);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(173, 38);
            this.solveButton.TabIndex = 0;
            this.solveButton.Text = "Розв\'язати";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(556, 204);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(59, 24);
            this.weightTextBox.TabIndex = 1;
            this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Максимальна вага";
            // 
            // itemsListView
            // 
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.itemsListView.Location = new System.Drawing.Point(12, 12);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(385, 279);
            this.itemsListView.TabIndex = 3;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Назва товару";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Вага товару";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ціна товару";
            this.columnHeader3.Width = 97;
            // 
            // ShowConditionsButton
            // 
            this.ShowConditionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ShowConditionsButton.Location = new System.Drawing.Point(130, 297);
            this.ShowConditionsButton.Name = "ShowConditionsButton";
            this.ShowConditionsButton.Size = new System.Drawing.Size(146, 23);
            this.ShowConditionsButton.TabIndex = 4;
            this.ShowConditionsButton.Text = "Очистити таблицю";
            this.ShowConditionsButton.UseVisualStyleBackColor = true;
            this.ShowConditionsButton.Click += new System.EventHandler(this.ShowConditionsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice4);
            this.groupBox1.Controls.Add(this.txtWeight4);
            this.groupBox1.Controls.Add(this.txtName4);
            this.groupBox1.Controls.Add(this.txtPrice3);
            this.groupBox1.Controls.Add(this.txtWeight3);
            this.groupBox1.Controls.Add(this.txtName3);
            this.groupBox1.Controls.Add(this.txtPrice2);
            this.groupBox1.Controls.Add(this.txtWeight2);
            this.groupBox1.Controls.Add(this.txtName2);
            this.groupBox1.Controls.Add(this.AddGoods);
            this.groupBox1.Controls.Add(this.txtPrice1);
            this.groupBox1.Controls.Add(this.txtWeight1);
            this.groupBox1.Controls.Add(this.txtName1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(414, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати товар";
            // 
            // txtPrice4
            // 
            this.txtPrice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice4.Location = new System.Drawing.Point(272, 96);
            this.txtPrice4.Name = "txtPrice4";
            this.txtPrice4.Size = new System.Drawing.Size(59, 22);
            this.txtPrice4.TabIndex = 15;
            this.txtPrice4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight4
            // 
            this.txtWeight4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWeight4.Location = new System.Drawing.Point(272, 66);
            this.txtWeight4.Name = "txtWeight4";
            this.txtWeight4.Size = new System.Drawing.Size(59, 22);
            this.txtWeight4.TabIndex = 14;
            this.txtWeight4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName4
            // 
            this.txtName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName4.Location = new System.Drawing.Point(272, 36);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(59, 22);
            this.txtName4.TabIndex = 13;
            this.txtName4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice3
            // 
            this.txtPrice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice3.Location = new System.Drawing.Point(207, 96);
            this.txtPrice3.Name = "txtPrice3";
            this.txtPrice3.Size = new System.Drawing.Size(59, 22);
            this.txtPrice3.TabIndex = 12;
            this.txtPrice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight3
            // 
            this.txtWeight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWeight3.Location = new System.Drawing.Point(207, 66);
            this.txtWeight3.Name = "txtWeight3";
            this.txtWeight3.Size = new System.Drawing.Size(59, 22);
            this.txtWeight3.TabIndex = 11;
            this.txtWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName3
            // 
            this.txtName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName3.Location = new System.Drawing.Point(207, 36);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(59, 22);
            this.txtName3.TabIndex = 10;
            this.txtName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice2
            // 
            this.txtPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice2.Location = new System.Drawing.Point(142, 96);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(59, 22);
            this.txtPrice2.TabIndex = 9;
            this.txtPrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight2
            // 
            this.txtWeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWeight2.Location = new System.Drawing.Point(142, 66);
            this.txtWeight2.Name = "txtWeight2";
            this.txtWeight2.Size = new System.Drawing.Size(59, 22);
            this.txtWeight2.TabIndex = 8;
            this.txtWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName2
            // 
            this.txtName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName2.Location = new System.Drawing.Point(142, 36);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(59, 22);
            this.txtName2.TabIndex = 7;
            this.txtName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddGoods
            // 
            this.AddGoods.Location = new System.Drawing.Point(97, 126);
            this.AddGoods.Name = "AddGoods";
            this.AddGoods.Size = new System.Drawing.Size(180, 35);
            this.AddGoods.TabIndex = 6;
            this.AddGoods.Text = "Додати товари";
            this.AddGoods.UseVisualStyleBackColor = true;
            this.AddGoods.Click += new System.EventHandler(this.AddGoods_Click);
            // 
            // txtPrice1
            // 
            this.txtPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice1.Location = new System.Drawing.Point(78, 96);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(58, 22);
            this.txtPrice1.TabIndex = 5;
            this.txtPrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight1
            // 
            this.txtWeight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWeight1.Location = new System.Drawing.Point(78, 66);
            this.txtWeight1.Name = "txtWeight1";
            this.txtWeight1.Size = new System.Drawing.Size(58, 22);
            this.txtWeight1.TabIndex = 4;
            this.txtWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName1
            // 
            this.txtName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName1.Location = new System.Drawing.Point(78, 36);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(58, 22);
            this.txtName1.TabIndex = 3;
            this.txtName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ціна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Вага";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Назва";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ціна:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Вага:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 406);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShowConditionsButton);
            this.Controls.Add(this.itemsListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.solveButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Метод \"Загрузки транспортного засобу\" ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ShowConditionsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddGoods;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtWeight1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice4;
        private System.Windows.Forms.TextBox txtWeight4;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.TextBox txtPrice3;
        private System.Windows.Forms.TextBox txtWeight3;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtWeight2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

