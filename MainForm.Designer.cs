
namespace MCFunction_Compressor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelURI = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "インパルス",
            "リピート"});
            this.comboBox.Location = new System.Drawing.Point(12, 189);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(280, 28);
            this.comboBox.TabIndex = 0;
            this.comboBox.Text = "インパルス";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox.Location = new System.Drawing.Point(349, 196);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(74, 19);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "自動実行";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // labelExit
            // 
            this.labelExit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelExit.Location = new System.Drawing.Point(400, 0);
            this.labelExit.Margin = new System.Windows.Forms.Padding(0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(50, 30);
            this.labelExit.TabIndex = 2;
            this.labelExit.Text = "";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelExit_MouseDown);
            this.labelExit.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // labelMinimize
            // 
            this.labelMinimize.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinimize.Location = new System.Drawing.Point(350, 0);
            this.labelMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(50, 30);
            this.labelMinimize.TabIndex = 3;
            this.labelMinimize.Text = "";
            this.labelMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMinimize_MouseDown);
            this.labelMinimize.MouseEnter += new System.EventHandler(this.labelMinimize_MouseEnter);
            this.labelMinimize.MouseLeave += new System.EventHandler(this.labelMinimize_MouseLeave);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(348, 30);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "MCFUNCTION Compressor";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            // 
            // buttonSelect
            // 
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.ForeColor = System.Drawing.Color.White;
            this.buttonSelect.Location = new System.Drawing.Point(349, 106);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 28);
            this.buttonSelect.TabIndex = 5;
            this.buttonSelect.Text = "選択";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelURI
            // 
            this.labelURI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelURI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelURI.ForeColor = System.Drawing.Color.White;
            this.labelURI.Location = new System.Drawing.Point(12, 106);
            this.labelURI.Name = "labelURI";
            this.labelURI.Size = new System.Drawing.Size(300, 28);
            this.labelURI.TabIndex = 6;
            this.labelURI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFile.Location = new System.Drawing.Point(12, 80);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(127, 15);
            this.labelFile.TabIndex = 7;
            this.labelFile.Text = "MCFUNCTION ファイル";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSettings.Location = new System.Drawing.Point(12, 161);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(55, 15);
            this.labelSettings.TabIndex = 8;
            this.labelSettings.Text = "詳細設定";
            this.labelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExport
            // 
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.ForeColor = System.Drawing.Color.White;
            this.buttonExport.Location = new System.Drawing.Point(274, 252);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(150, 28);
            this.buttonExport.TabIndex = 9;
            this.buttonExport.Text = "出力";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxResult.Location = new System.Drawing.Point(12, 312);
            this.textBoxResult.MaxLength = 2147483647;
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(426, 226);
            this.textBoxResult.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(450, 550);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelURI);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelMinimize);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.comboBox);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MCFunction Compressor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelURI;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

