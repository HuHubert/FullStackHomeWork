namespace HW_0602
{
    partial class LoanMoney
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMonthPay = new System.Windows.Forms.Button();
            this.btnTotalPay = new System.Windows.Forms.Button();
            this.labLoanMoney = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labInterestRate = new System.Windows.Forms.Label();
            this.labDownPay = new System.Windows.Forms.Label();
            this.textLoanMoney = new System.Windows.Forms.TextBox();
            this.textInterestRate = new System.Windows.Forms.TextBox();
            this.textDownPay = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMonthPay
            // 
            this.btnMonthPay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMonthPay.Location = new System.Drawing.Point(22, 620);
            this.btnMonthPay.Name = "btnMonthPay";
            this.btnMonthPay.Size = new System.Drawing.Size(240, 123);
            this.btnMonthPay.TabIndex = 0;
            this.btnMonthPay.Text = "月繳金額";
            this.btnMonthPay.UseVisualStyleBackColor = true;
            this.btnMonthPay.Click += new System.EventHandler(this.btnMonthPay_Click);
            // 
            // btnTotalPay
            // 
            this.btnTotalPay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotalPay.Location = new System.Drawing.Point(343, 620);
            this.btnTotalPay.Name = "btnTotalPay";
            this.btnTotalPay.Size = new System.Drawing.Size(240, 123);
            this.btnTotalPay.TabIndex = 1;
            this.btnTotalPay.Text = "總金額";
            this.btnTotalPay.UseVisualStyleBackColor = true;
            this.btnTotalPay.Click += new System.EventHandler(this.btnTotalPay_Click);
            // 
            // labLoanMoney
            // 
            this.labLoanMoney.AutoSize = true;
            this.labLoanMoney.BackColor = System.Drawing.Color.OrangeRed;
            this.labLoanMoney.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanMoney.Location = new System.Drawing.Point(23, 106);
            this.labLoanMoney.Name = "labLoanMoney";
            this.labLoanMoney.Size = new System.Drawing.Size(219, 61);
            this.labLoanMoney.TabIndex = 2;
            this.labLoanMoney.Text = "貸款金額";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.BackColor = System.Drawing.Color.OrangeRed;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(23, 235);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(219, 61);
            this.labYear.TabIndex = 3;
            this.labYear.Text = "貸款年限";
            // 
            // labInterestRate
            // 
            this.labInterestRate.AutoSize = true;
            this.labInterestRate.BackColor = System.Drawing.Color.OrangeRed;
            this.labInterestRate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInterestRate.Location = new System.Drawing.Point(23, 364);
            this.labInterestRate.Name = "labInterestRate";
            this.labInterestRate.Size = new System.Drawing.Size(200, 61);
            this.labInterestRate.TabIndex = 4;
            this.labInterestRate.Text = "利率(%)";
            // 
            // labDownPay
            // 
            this.labDownPay.AutoSize = true;
            this.labDownPay.BackColor = System.Drawing.Color.OrangeRed;
            this.labDownPay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPay.Location = new System.Drawing.Point(23, 493);
            this.labDownPay.Name = "labDownPay";
            this.labDownPay.Size = new System.Drawing.Size(171, 61);
            this.labDownPay.TabIndex = 5;
            this.labDownPay.Text = "頭期款";
            // 
            // textLoanMoney
            // 
            this.textLoanMoney.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textLoanMoney.Location = new System.Drawing.Point(273, 99);
            this.textLoanMoney.Name = "textLoanMoney";
            this.textLoanMoney.Size = new System.Drawing.Size(368, 65);
            this.textLoanMoney.TabIndex = 6;
            this.textLoanMoney.TextChanged += new System.EventHandler(this.textLoanMoney_TextChanged);
            // 
            // textInterestRate
            // 
            this.textInterestRate.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textInterestRate.Location = new System.Drawing.Point(273, 359);
            this.textInterestRate.Name = "textInterestRate";
            this.textInterestRate.Size = new System.Drawing.Size(368, 65);
            this.textInterestRate.TabIndex = 7;
            this.textInterestRate.TextChanged += new System.EventHandler(this.textInterestRate_TextChanged);
            // 
            // textDownPay
            // 
            this.textDownPay.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textDownPay.Location = new System.Drawing.Point(273, 489);
            this.textDownPay.Name = "textDownPay";
            this.textDownPay.Size = new System.Drawing.Size(368, 65);
            this.textDownPay.TabIndex = 8;
            this.textDownPay.TextChanged += new System.EventHandler(this.textDownPay_TextChanged);
            // 
            // textYear
            // 
            this.textYear.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textYear.Location = new System.Drawing.Point(273, 229);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(368, 65);
            this.textYear.TabIndex = 9;
            this.textYear.TextChanged += new System.EventHandler(this.textYear_TextChanged);
            // 
            // LoanMoney
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::HW_0602.Properties.Resources.memeCat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1386, 863);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textDownPay);
            this.Controls.Add(this.textInterestRate);
            this.Controls.Add(this.textLoanMoney);
            this.Controls.Add(this.labDownPay);
            this.Controls.Add(this.labInterestRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labLoanMoney);
            this.Controls.Add(this.btnTotalPay);
            this.Controls.Add(this.btnMonthPay);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoanMoney";
            this.Text = "欠錢要還呀!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMonthPay;
        private System.Windows.Forms.Button btnTotalPay;
        private System.Windows.Forms.Label labLoanMoney;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labInterestRate;
        private System.Windows.Forms.Label labDownPay;
        private System.Windows.Forms.TextBox textLoanMoney;
        private System.Windows.Forms.TextBox textInterestRate;
        private System.Windows.Forms.TextBox textDownPay;
        private System.Windows.Forms.TextBox textYear;
    }
}

