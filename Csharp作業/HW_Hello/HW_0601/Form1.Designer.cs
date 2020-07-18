namespace HW_0601
{
    partial class HiCsharp
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
            this.labName = new System.Windows.Forms.Label();
            this.EngName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Constellation = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.GenderTxt = new System.Windows.Forms.TextBox();
            this.EngNameTxt = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.ConstellationTxt = new System.Windows.Forms.TextBox();
            this.btnSayHey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.DarkOrange;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(657, 308);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(135, 67);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名";
            this.labName.UseMnemonic = false;
            this.labName.UseWaitCursor = true;
            this.labName.Click += new System.EventHandler(this.Name_Click);
            // 
            // EngName
            // 
            this.EngName.AutoSize = true;
            this.EngName.BackColor = System.Drawing.Color.DarkOrange;
            this.EngName.Font = new System.Drawing.Font("微軟正黑體", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EngName.Location = new System.Drawing.Point(411, 420);
            this.EngName.Name = "EngName";
            this.EngName.Size = new System.Drawing.Size(381, 67);
            this.EngName.TabIndex = 1;
            this.EngName.Text = "English Name";
            this.EngName.UseMnemonic = false;
            this.EngName.UseWaitCursor = true;
            this.EngName.Click += new System.EventHandler(this.EngName_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.DarkOrange;
            this.Gender.Font = new System.Drawing.Font("微軟正黑體", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gender.Location = new System.Drawing.Point(575, 520);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(217, 67);
            this.Gender.TabIndex = 2;
            this.Gender.Text = "Gender";
            this.Gender.UseMnemonic = false;
            this.Gender.UseWaitCursor = true;
            // 
            // Constellation
            // 
            this.Constellation.AutoSize = true;
            this.Constellation.BackColor = System.Drawing.Color.DarkOrange;
            this.Constellation.Font = new System.Drawing.Font("微軟正黑體", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Constellation.Location = new System.Drawing.Point(657, 635);
            this.Constellation.Name = "Constellation";
            this.Constellation.Size = new System.Drawing.Size(135, 67);
            this.Constellation.TabIndex = 3;
            this.Constellation.Text = "星座";
            this.Constellation.UseMnemonic = false;
            this.Constellation.UseWaitCursor = true;
            this.Constellation.Click += new System.EventHandler(this.Constellation_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameTxt.Location = new System.Drawing.Point(821, 310);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(190, 71);
            this.NameTxt.TabIndex = 4;
            this.NameTxt.UseWaitCursor = true;
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // GenderTxt
            // 
            this.GenderTxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GenderTxt.Location = new System.Drawing.Point(821, 524);
            this.GenderTxt.Name = "GenderTxt";
            this.GenderTxt.Size = new System.Drawing.Size(190, 71);
            this.GenderTxt.TabIndex = 6;
            this.GenderTxt.UseWaitCursor = true;
            // 
            // EngNameTxt
            // 
            this.EngNameTxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EngNameTxt.Location = new System.Drawing.Point(821, 424);
            this.EngNameTxt.Name = "EngNameTxt";
            this.EngNameTxt.Size = new System.Drawing.Size(190, 71);
            this.EngNameTxt.TabIndex = 7;
            this.EngNameTxt.UseWaitCursor = true;
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.Color.Orange;
            this.btnSayHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Location = new System.Drawing.Point(28, 607);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(247, 115);
            this.btnSayHello.TabIndex = 8;
            this.btnSayHello.Text = "是在Hello?";
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.UseWaitCursor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // ConstellationTxt
            // 
            this.ConstellationTxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConstellationTxt.Location = new System.Drawing.Point(821, 637);
            this.ConstellationTxt.Name = "ConstellationTxt";
            this.ConstellationTxt.Size = new System.Drawing.Size(190, 71);
            this.ConstellationTxt.TabIndex = 9;
            this.ConstellationTxt.UseWaitCursor = true;
            // 
            // btnSayHey
            // 
            this.btnSayHey.BackColor = System.Drawing.Color.Orange;
            this.btnSayHey.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHey.Location = new System.Drawing.Point(323, 607);
            this.btnSayHey.Name = "btnSayHey";
            this.btnSayHey.Size = new System.Drawing.Size(247, 115);
            this.btnSayHey.TabIndex = 10;
            this.btnSayHey.Text = "是在Hey?";
            this.btnSayHey.UseVisualStyleBackColor = false;
            this.btnSayHey.UseWaitCursor = true;
            this.btnSayHey.Click += new System.EventHandler(this.btnSayHey_Click_1);
            // 
            // HiCsharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::HW_0601.Properties.Resources.memeDog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1037, 773);
            this.Controls.Add(this.btnSayHey);
            this.Controls.Add(this.ConstellationTxt);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.EngNameTxt);
            this.Controls.Add(this.GenderTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.Constellation);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.EngName);
            this.Controls.Add(this.labName);
            this.Font = new System.Drawing.Font("新細明體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HiCsharp";
            this.Text = "HeyCsharp";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.HiCsharp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label EngName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Constellation;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox GenderTxt;
        private System.Windows.Forms.TextBox EngNameTxt;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.TextBox ConstellationTxt;
        private System.Windows.Forms.Button btnSayHey;
    }
}

