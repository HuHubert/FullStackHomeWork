namespace HW_method
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnOddEven = new System.Windows.Forms.Button();
            this.btnLongLong = new System.Windows.Forms.Button();
            this.btnCc = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.labelShowResult = new System.Windows.Forms.Label();
            this.btnO1i0 = new System.Windows.Forms.Button();
            this.btnO0i1 = new System.Windows.Forms.Button();
            this.btn1010 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnArraySum = new System.Windows.Forms.Button();
            this.btnArrayMax = new System.Windows.Forms.Button();
            this.btnArrayMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number :";
            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNumberInput.Location = new System.Drawing.Point(158, 40);
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.Size = new System.Drawing.Size(171, 50);
            this.txtNumberInput.TabIndex = 1;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(32, 128);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(372, 122);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "判斷輸入是奇數或偶數?";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Location = new System.Drawing.Point(32, 278);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(372, 57);
            this.btnMaxMin.TabIndex = 3;
            this.btnMaxMin.Text = "Array最大最小值";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnOddEven
            // 
            this.btnOddEven.Location = new System.Drawing.Point(32, 365);
            this.btnOddEven.Name = "btnOddEven";
            this.btnOddEven.Size = new System.Drawing.Size(372, 57);
            this.btnOddEven.TabIndex = 4;
            this.btnOddEven.Text = "Array奇數與偶數";
            this.btnOddEven.UseVisualStyleBackColor = true;
            this.btnOddEven.Click += new System.EventHandler(this.btnOddEven_Click);
            // 
            // btnLongLong
            // 
            this.btnLongLong.Location = new System.Drawing.Point(32, 452);
            this.btnLongLong.Name = "btnLongLong";
            this.btnLongLong.Size = new System.Drawing.Size(372, 57);
            this.btnLongLong.TabIndex = 5;
            this.btnLongLong.Text = "最長的名子";
            this.btnLongLong.UseVisualStyleBackColor = true;
            this.btnLongLong.Click += new System.EventHandler(this.btnLongLong_Click);
            // 
            // btnCc
            // 
            this.btnCc.Location = new System.Drawing.Point(32, 539);
            this.btnCc.Name = "btnCc";
            this.btnCc.Size = new System.Drawing.Size(372, 57);
            this.btnCc.TabIndex = 6;
            this.btnCc.Text = "幾個C 幾個c";
            this.btnCc.UseVisualStyleBackColor = true;
            this.btnCc.Click += new System.EventHandler(this.btnCc_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelResult.Location = new System.Drawing.Point(285, 657);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(128, 40);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Result :";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(32, 668);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 91);
            this.button6.TabIndex = 8;
            this.button6.Text = "Clear Rresult";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // labelShowResult
            // 
            this.labelShowResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShowResult.BackColor = System.Drawing.Color.Goldenrod;
            this.labelShowResult.Location = new System.Drawing.Point(420, 599);
            this.labelShowResult.Name = "labelShowResult";
            this.labelShowResult.Size = new System.Drawing.Size(881, 160);
            this.labelShowResult.TabIndex = 9;
            this.labelShowResult.Text = "ShowResult";
            this.labelShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnO1i0
            // 
            this.btnO1i0.Location = new System.Drawing.Point(554, 34);
            this.btnO1i0.Name = "btnO1i0";
            this.btnO1i0.Size = new System.Drawing.Size(333, 149);
            this.btnO1i0.TabIndex = 10;
            this.btnO1i0.Text = "[10,10]的邊1內0";
            this.btnO1i0.UseVisualStyleBackColor = true;
            this.btnO1i0.Click += new System.EventHandler(this.btnO1i0_Click);
            // 
            // btnO0i1
            // 
            this.btnO0i1.Location = new System.Drawing.Point(554, 232);
            this.btnO0i1.Name = "btnO0i1";
            this.btnO0i1.Size = new System.Drawing.Size(333, 149);
            this.btnO0i1.TabIndex = 11;
            this.btnO0i1.Text = "[10,10]的邊0內1";
            this.btnO0i1.UseVisualStyleBackColor = true;
            this.btnO0i1.Click += new System.EventHandler(this.btnO0i1_Click);
            // 
            // btn1010
            // 
            this.btn1010.Location = new System.Drawing.Point(554, 430);
            this.btn1010.Name = "btn1010";
            this.btn1010.Size = new System.Drawing.Size(333, 149);
            this.btn1010.TabIndex = 12;
            this.btn1010.Text = "[10,10]的1010/0101";
            this.btn1010.UseVisualStyleBackColor = true;
            this.btn1010.Click += new System.EventHandler(this.btn1010_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(932, 35);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(372, 122);
            this.btnSwap.TabIndex = 13;
            this.btnSwap.Text = "SWAP";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnArraySum
            // 
            this.btnArraySum.Location = new System.Drawing.Point(932, 176);
            this.btnArraySum.Name = "btnArraySum";
            this.btnArraySum.Size = new System.Drawing.Size(372, 122);
            this.btnArraySum.TabIndex = 14;
            this.btnArraySum.Text = "Array-Sum";
            this.btnArraySum.UseVisualStyleBackColor = true;
            this.btnArraySum.Click += new System.EventHandler(this.btnArraySum_Click);
            // 
            // btnArrayMax
            // 
            this.btnArrayMax.Location = new System.Drawing.Point(932, 317);
            this.btnArrayMax.Name = "btnArrayMax";
            this.btnArrayMax.Size = new System.Drawing.Size(372, 122);
            this.btnArrayMax.TabIndex = 15;
            this.btnArrayMax.Text = "Array-Max";
            this.btnArrayMax.UseVisualStyleBackColor = true;
            this.btnArrayMax.Click += new System.EventHandler(this.btnArrayMax_Click);
            // 
            // btnArrayMin
            // 
            this.btnArrayMin.Location = new System.Drawing.Point(932, 458);
            this.btnArrayMin.Name = "btnArrayMin";
            this.btnArrayMin.Size = new System.Drawing.Size(372, 122);
            this.btnArrayMin.TabIndex = 16;
            this.btnArrayMin.Text = "Array-Min";
            this.btnArrayMin.UseVisualStyleBackColor = true;
            this.btnArrayMin.Click += new System.EventHandler(this.btnArrayMin_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button6;
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1431, 1123);
            this.Controls.Add(this.btnArrayMin);
            this.Controls.Add(this.btnArrayMax);
            this.Controls.Add(this.btnArraySum);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btn1010);
            this.Controls.Add(this.btnO0i1);
            this.Controls.Add(this.btnO1i0);
            this.Controls.Add(this.labelShowResult);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnCc);
            this.Controls.Add(this.btnLongLong);
            this.Controls.Add(this.btnOddEven);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtNumberInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnOddEven;
        private System.Windows.Forms.Button btnLongLong;
        private System.Windows.Forms.Button btnCc;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelShowResult;
        private System.Windows.Forms.Button btnO1i0;
        private System.Windows.Forms.Button btnO0i1;
        private System.Windows.Forms.Button btn1010;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnArraySum;
        private System.Windows.Forms.Button btnArrayMax;
        private System.Windows.Forms.Button btnArrayMin;
    }
}

