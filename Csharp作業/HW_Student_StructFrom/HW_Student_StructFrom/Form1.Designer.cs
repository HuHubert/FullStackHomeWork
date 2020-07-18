namespace HW_Student_StructFrom
{
    partial class StuStrFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuStrFrom));
            this.labnName = new System.Windows.Forms.Label();
            this.labCh = new System.Windows.Forms.Label();
            this.labEn = new System.Windows.Forms.Label();
            this.labMa = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCh = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labEst = new System.Windows.Forms.Label();
            this.labelist = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnEst = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labnName
            // 
            resources.ApplyResources(this.labnName, "labnName");
            this.labnName.Name = "labnName";
            // 
            // labCh
            // 
            resources.ApplyResources(this.labCh, "labCh");
            this.labCh.Name = "labCh";
            // 
            // labEn
            // 
            resources.ApplyResources(this.labEn, "labEn");
            this.labEn.Name = "labEn";
            // 
            // labMa
            // 
            resources.ApplyResources(this.labMa, "labMa");
            this.labMa.Name = "labMa";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtCh
            // 
            resources.ApplyResources(this.txtCh, "txtCh");
            this.txtCh.Name = "txtCh";
            // 
            // txtEn
            // 
            resources.ApplyResources(this.txtEn, "txtEn");
            this.txtEn.Name = "txtEn";
            // 
            // txtMa
            // 
            resources.ApplyResources(this.txtMa, "txtMa");
            this.txtMa.Name = "txtMa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labEst);
            this.groupBox1.Controls.Add(this.labelist);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // labEst
            // 
            this.labEst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.labEst, "labEst");
            this.labEst.Name = "labEst";
            this.labEst.Click += new System.EventHandler(this.labEst_Click);
            // 
            // labelist
            // 
            this.labelist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.labelist, "labelist");
            this.labelist.Name = "labelist";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            resources.ApplyResources(this.btnShow, "btnShow");
            this.btnShow.Name = "btnShow";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnEst
            // 
            resources.ApplyResources(this.btnEst, "btnEst");
            this.btnEst.Name = "btnEst";
            this.btnEst.UseVisualStyleBackColor = true;
            this.btnEst.Click += new System.EventHandler(this.btnEst_Click);
            // 
            // StuStrFrom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEst);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCh);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMa);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCh);
            this.Controls.Add(this.labnName);
            this.Name = "StuStrFrom";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labnName;
        private System.Windows.Forms.Label labCh;
        private System.Windows.Forms.Label labEn;
        private System.Windows.Forms.Label labMa;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCh;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelist;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnEst;
        private System.Windows.Forms.Label labEst;
    }
}

