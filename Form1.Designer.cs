namespace ChangeFileChineseNameToPiXin
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPathName = new System.Windows.Forms.Button();
            this.txtPathName = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.listSoureName = new System.Windows.Forms.ListBox();
            this.listNewName = new System.Windows.Forms.ListBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPathName
            // 
            this.btnPathName.Location = new System.Drawing.Point(477, 378);
            this.btnPathName.Name = "btnPathName";
            this.btnPathName.Size = new System.Drawing.Size(75, 23);
            this.btnPathName.TabIndex = 2;
            this.btnPathName.Text = "选择...";
            this.btnPathName.UseVisualStyleBackColor = true;
            this.btnPathName.Click += new System.EventHandler(this.BtnPathName_Click);
            // 
            // txtPathName
            // 
            this.txtPathName.Location = new System.Drawing.Point(29, 378);
            this.txtPathName.Name = "txtPathName";
            this.txtPathName.ReadOnly = true;
            this.txtPathName.Size = new System.Drawing.Size(442, 21);
            this.txtPathName.TabIndex = 3;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(477, 422);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 4;
            this.btnExec.Text = "执行";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.BtnExec_Click);
            // 
            // listSoureName
            // 
            this.listSoureName.FormattingEnabled = true;
            this.listSoureName.ItemHeight = 12;
            this.listSoureName.Location = new System.Drawing.Point(29, 26);
            this.listSoureName.Name = "listSoureName";
            this.listSoureName.Size = new System.Drawing.Size(233, 340);
            this.listSoureName.TabIndex = 5;
            // 
            // listNewName
            // 
            this.listNewName.FormattingEnabled = true;
            this.listNewName.ItemHeight = 12;
            this.listNewName.Location = new System.Drawing.Point(354, 26);
            this.listNewName.Name = "listNewName";
            this.listNewName.Size = new System.Drawing.Size(198, 340);
            this.listNewName.TabIndex = 6;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(386, 422);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 457);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.listNewName);
            this.Controls.Add(this.listSoureName);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.txtPathName);
            this.Controls.Add(this.btnPathName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(598, 496);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(598, 496);
            this.Name = "Form1";
            this.Text = "文件名批量改中文";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPathName;
        private System.Windows.Forms.TextBox txtPathName;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.ListBox listSoureName;
        private System.Windows.Forms.ListBox listNewName;
        private System.Windows.Forms.Button btnPreview;
    }
}

