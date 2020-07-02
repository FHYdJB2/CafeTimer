namespace CafeTimer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inTimePicker = new System.Windows.Forms.DateTimePicker();
            this.outTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DisplayMoneyBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stayTime = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.chargeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.taxText = new System.Windows.Forms.TextBox();
            this.firstDrink = new System.Windows.Forms.Label();
            this.firstDrinkComboBox = new System.Windows.Forms.ComboBox();
            this.firstDrinkText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drinkTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.drink200ComboBox = new System.Windows.Forms.ComboBox();
            this.drink300ComboBox = new System.Windows.Forms.ComboBox();
            this.drink400ComboBox = new System.Windows.Forms.ComboBox();
            this.drink600ComboBox = new System.Windows.Forms.ComboBox();
            this.totalText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.othersTextBox = new System.Windows.Forms.TextBox();
            this.TimeCalcBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dropComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IN時間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "OUT時間";
            // 
            // inTimePicker
            // 
            this.inTimePicker.CustomFormat = "HH:mm";
            this.inTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inTimePicker.Location = new System.Drawing.Point(112, 48);
            this.inTimePicker.Name = "inTimePicker";
            this.inTimePicker.ShowUpDown = true;
            this.inTimePicker.Size = new System.Drawing.Size(72, 22);
            this.inTimePicker.TabIndex = 2;
            this.inTimePicker.Value = new System.DateTime(2020, 6, 29, 0, 0, 0, 0);
            // 
            // outTimePicker
            // 
            this.outTimePicker.CustomFormat = "HH:mm";
            this.outTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.outTimePicker.Location = new System.Drawing.Point(112, 80);
            this.outTimePicker.Name = "outTimePicker";
            this.outTimePicker.ShowUpDown = true;
            this.outTimePicker.Size = new System.Drawing.Size(72, 22);
            this.outTimePicker.TabIndex = 3;
            this.outTimePicker.Value = new System.DateTime(2020, 6, 29, 0, 0, 0, 0);
            // 
            // DisplayMoneyBtn
            // 
            this.DisplayMoneyBtn.Location = new System.Drawing.Point(592, 368);
            this.DisplayMoneyBtn.Name = "DisplayMoneyBtn";
            this.DisplayMoneyBtn.Size = new System.Drawing.Size(100, 35);
            this.DisplayMoneyBtn.TabIndex = 4;
            this.DisplayMoneyBtn.Text = "お会計";
            this.DisplayMoneyBtn.UseVisualStyleBackColor = true;
            this.DisplayMoneyBtn.Click += new System.EventHandler(this.DisplayMoneyClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "滞在時間";
            // 
            // stayTime
            // 
            this.stayTime.Location = new System.Drawing.Point(104, 216);
            this.stayTime.Name = "stayTime";
            this.stayTime.Size = new System.Drawing.Size(104, 22);
            this.stayTime.TabIndex = 6;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(512, 336);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(67, 15);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "合計金額";
            // 
            // chargeText
            // 
            this.chargeText.Location = new System.Drawing.Point(104, 248);
            this.chargeText.Name = "chargeText";
            this.chargeText.Size = new System.Drawing.Size(104, 22);
            this.chargeText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "charge";
            // 
            // taxText
            // 
            this.taxText.Location = new System.Drawing.Point(584, 336);
            this.taxText.Name = "taxText";
            this.taxText.Size = new System.Drawing.Size(104, 22);
            this.taxText.TabIndex = 10;
            // 
            // firstDrink
            // 
            this.firstDrink.AutoSize = true;
            this.firstDrink.Location = new System.Drawing.Point(240, 48);
            this.firstDrink.Name = "firstDrink";
            this.firstDrink.Size = new System.Drawing.Size(52, 15);
            this.firstDrink.TabIndex = 11;
            this.firstDrink.Text = "一杯目";
            // 
            // firstDrinkComboBox
            // 
            this.firstDrinkComboBox.FormattingEnabled = true;
            this.firstDrinkComboBox.Location = new System.Drawing.Point(296, 48);
            this.firstDrinkComboBox.Name = "firstDrinkComboBox";
            this.firstDrinkComboBox.Size = new System.Drawing.Size(121, 23);
            this.firstDrinkComboBox.TabIndex = 12;
            this.firstDrinkComboBox.TextChanged += new System.EventHandler(this.FirstDrinkChanged);
            // 
            // firstDrinkText
            // 
            this.firstDrinkText.Location = new System.Drawing.Point(432, 48);
            this.firstDrinkText.Name = "firstDrinkText";
            this.firstDrinkText.Size = new System.Drawing.Size(100, 22);
            this.firstDrinkText.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "drink";
            // 
            // drinkTextBox
            // 
            this.drinkTextBox.Location = new System.Drawing.Point(320, 248);
            this.drinkTextBox.Name = "drinkTextBox";
            this.drinkTextBox.Size = new System.Drawing.Size(100, 22);
            this.drinkTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "税抜金額";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "二杯目以降";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "200";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "300";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "400";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "600";
            // 
            // drink200ComboBox
            // 
            this.drink200ComboBox.FormattingEnabled = true;
            this.drink200ComboBox.Location = new System.Drawing.Point(360, 88);
            this.drink200ComboBox.Name = "drink200ComboBox";
            this.drink200ComboBox.Size = new System.Drawing.Size(56, 23);
            this.drink200ComboBox.TabIndex = 23;
            this.drink200ComboBox.TextChanged += new System.EventHandler(this.SecondDrinkChanged);
            // 
            // drink300ComboBox
            // 
            this.drink300ComboBox.FormattingEnabled = true;
            this.drink300ComboBox.Location = new System.Drawing.Point(360, 120);
            this.drink300ComboBox.Name = "drink300ComboBox";
            this.drink300ComboBox.Size = new System.Drawing.Size(56, 23);
            this.drink300ComboBox.TabIndex = 24;
            this.drink300ComboBox.TextChanged += new System.EventHandler(this.SecondDrinkChanged);
            // 
            // drink400ComboBox
            // 
            this.drink400ComboBox.FormattingEnabled = true;
            this.drink400ComboBox.Location = new System.Drawing.Point(360, 152);
            this.drink400ComboBox.Name = "drink400ComboBox";
            this.drink400ComboBox.Size = new System.Drawing.Size(56, 23);
            this.drink400ComboBox.TabIndex = 25;
            // 
            // drink600ComboBox
            // 
            this.drink600ComboBox.FormattingEnabled = true;
            this.drink600ComboBox.Location = new System.Drawing.Point(360, 184);
            this.drink600ComboBox.Name = "drink600ComboBox";
            this.drink600ComboBox.Size = new System.Drawing.Size(56, 23);
            this.drink600ComboBox.TabIndex = 26;
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(584, 304);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(104, 22);
            this.totalText.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(544, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "しずく";
            // 
            // othersTextBox
            // 
            this.othersTextBox.Location = new System.Drawing.Point(584, 248);
            this.othersTextBox.Name = "othersTextBox";
            this.othersTextBox.Size = new System.Drawing.Size(104, 22);
            this.othersTextBox.TabIndex = 29;
            // 
            // TimeCalcBtn
            // 
            this.TimeCalcBtn.Location = new System.Drawing.Point(112, 280);
            this.TimeCalcBtn.Name = "TimeCalcBtn";
            this.TimeCalcBtn.Size = new System.Drawing.Size(100, 35);
            this.TimeCalcBtn.TabIndex = 30;
            this.TimeCalcBtn.Text = "時間計算";
            this.TimeCalcBtn.UseVisualStyleBackColor = true;
            this.TimeCalcBtn.Click += new System.EventHandler(this.TimeCalcClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(520, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "others";
            // 
            // dropComboBox
            // 
            this.dropComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.dropComboBox.FormattingEnabled = true;
            this.dropComboBox.Location = new System.Drawing.Point(592, 48);
            this.dropComboBox.Name = "dropComboBox";
            this.dropComboBox.Size = new System.Drawing.Size(56, 23);
            this.dropComboBox.TabIndex = 32;
            this.dropComboBox.TextChanged += new System.EventHandler(this.OthersChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 429);
            this.Controls.Add(this.dropComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TimeCalcBtn);
            this.Controls.Add(this.othersTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.drink600ComboBox);
            this.Controls.Add(this.drink400ComboBox);
            this.Controls.Add(this.drink300ComboBox);
            this.Controls.Add(this.drink200ComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.drinkTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstDrinkText);
            this.Controls.Add(this.firstDrinkComboBox);
            this.Controls.Add(this.firstDrink);
            this.Controls.Add(this.taxText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chargeText);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.stayTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DisplayMoneyBtn);
            this.Controls.Add(this.outTimePicker);
            this.Controls.Add(this.inTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inTimePicker;
        private System.Windows.Forms.DateTimePicker outTimePicker;
        private System.Windows.Forms.Button DisplayMoneyBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stayTime;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox chargeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox taxText;
        private System.Windows.Forms.Label firstDrink;
        private System.Windows.Forms.ComboBox firstDrinkComboBox;
        private System.Windows.Forms.TextBox firstDrinkText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox drinkTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox drink200ComboBox;
        private System.Windows.Forms.ComboBox drink300ComboBox;
        private System.Windows.Forms.ComboBox drink400ComboBox;
        private System.Windows.Forms.ComboBox drink600ComboBox;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox othersTextBox;
        private System.Windows.Forms.Button TimeCalcBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox dropComboBox;
    }
}

