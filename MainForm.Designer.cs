namespace AutoSaveImageSerial
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
            this.SaveDirText = new System.Windows.Forms.TextBox();
            this.SaveDirButton = new System.Windows.Forms.Button();
            this.SaveTitleText = new System.Windows.Forms.TextBox();
            this.SaveTitleDescription = new System.Windows.Forms.Label();
            this.SelectSiteDropDown = new System.Windows.Forms.ComboBox();
            this.SaveNumberText = new System.Windows.Forms.TextBox();
            this.SaveNumberDescription = new System.Windows.Forms.Label();
            this.ResetSaveNum = new System.Windows.Forms.Button();
            this.SaveImageText = new System.Windows.Forms.TextBox();
            this.LogResetButton = new System.Windows.Forms.Button();
            this.ModeSelectComboBox = new System.Windows.Forms.ComboBox();
            this.ModeSelectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveDirText
            // 
            this.SaveDirText.Location = new System.Drawing.Point(13, 13);
            this.SaveDirText.Name = "SaveDirText";
            this.SaveDirText.Size = new System.Drawing.Size(586, 19);
            this.SaveDirText.TabIndex = 0;
            this.SaveDirText.TextChanged += new System.EventHandler(this.SaveDirText_TextChanged);
            // 
            // SaveDirButton
            // 
            this.SaveDirButton.Location = new System.Drawing.Point(605, 12);
            this.SaveDirButton.Name = "SaveDirButton";
            this.SaveDirButton.Size = new System.Drawing.Size(87, 20);
            this.SaveDirButton.TabIndex = 1;
            this.SaveDirButton.Text = "保存先フォルダ";
            this.SaveDirButton.UseVisualStyleBackColor = true;
            this.SaveDirButton.Click += new System.EventHandler(this.SaveDirButton_Click);
            // 
            // SaveTitleText
            // 
            this.SaveTitleText.Location = new System.Drawing.Point(13, 38);
            this.SaveTitleText.Name = "SaveTitleText";
            this.SaveTitleText.Size = new System.Drawing.Size(175, 19);
            this.SaveTitleText.TabIndex = 2;
            this.SaveTitleText.TextChanged += new System.EventHandler(this.SaveTitleText_TextChanged);
            // 
            // SaveTitleDescription
            // 
            this.SaveTitleDescription.AutoSize = true;
            this.SaveTitleDescription.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveTitleDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveTitleDescription.Location = new System.Drawing.Point(194, 41);
            this.SaveTitleDescription.Name = "SaveTitleDescription";
            this.SaveTitleDescription.Size = new System.Drawing.Size(64, 12);
            this.SaveTitleDescription.TabIndex = 3;
            this.SaveTitleDescription.Text = "保存タイトル";
            // 
            // SelectSiteDropDown
            // 
            this.SelectSiteDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectSiteDropDown.FormattingEnabled = true;
            this.SelectSiteDropDown.Items.AddRange(new object[] {
            "Pixiv",
            "Fantia",
            "その他"});
            this.SelectSiteDropDown.Location = new System.Drawing.Point(605, 37);
            this.SelectSiteDropDown.Name = "SelectSiteDropDown";
            this.SelectSiteDropDown.Size = new System.Drawing.Size(87, 20);
            this.SelectSiteDropDown.TabIndex = 6;
            this.SelectSiteDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectSiteDropDown_SelectedIndexChanged);
            // 
            // SaveNumberText
            // 
            this.SaveNumberText.Location = new System.Drawing.Point(286, 38);
            this.SaveNumberText.Name = "SaveNumberText";
            this.SaveNumberText.Size = new System.Drawing.Size(18, 19);
            this.SaveNumberText.TabIndex = 7;
            this.SaveNumberText.Text = "00";
            this.SaveNumberText.TextChanged += new System.EventHandler(this.SaveNumberText_TextChanged);
            // 
            // SaveNumberDescription
            // 
            this.SaveNumberDescription.AutoSize = true;
            this.SaveNumberDescription.Location = new System.Drawing.Point(310, 41);
            this.SaveNumberDescription.Name = "SaveNumberDescription";
            this.SaveNumberDescription.Size = new System.Drawing.Size(53, 12);
            this.SaveNumberDescription.TabIndex = 8;
            this.SaveNumberDescription.Text = "保存番号";
            // 
            // ResetSaveNum
            // 
            this.ResetSaveNum.Location = new System.Drawing.Point(369, 38);
            this.ResetSaveNum.Name = "ResetSaveNum";
            this.ResetSaveNum.Size = new System.Drawing.Size(75, 19);
            this.ResetSaveNum.TabIndex = 9;
            this.ResetSaveNum.Text = "番号リセット";
            this.ResetSaveNum.UseVisualStyleBackColor = true;
            this.ResetSaveNum.Click += new System.EventHandler(this.ResetSaveNum_Click);
            // 
            // SaveImageText
            // 
            this.SaveImageText.AllowDrop = true;
            this.SaveImageText.Location = new System.Drawing.Point(13, 89);
            this.SaveImageText.Multiline = true;
            this.SaveImageText.Name = "SaveImageText";
            this.SaveImageText.ReadOnly = true;
            this.SaveImageText.Size = new System.Drawing.Size(679, 340);
            this.SaveImageText.TabIndex = 10;
            this.SaveImageText.TextChanged += new System.EventHandler(this.SaveImageText_TextChanged);
            this.SaveImageText.DragDrop += new System.Windows.Forms.DragEventHandler(this.SaveImageText_DragDrop);
            this.SaveImageText.DragEnter += new System.Windows.Forms.DragEventHandler(this.SaveImageText_DragEnter);
            // 
            // LogResetButton
            // 
            this.LogResetButton.Location = new System.Drawing.Point(450, 38);
            this.LogResetButton.Name = "LogResetButton";
            this.LogResetButton.Size = new System.Drawing.Size(75, 19);
            this.LogResetButton.TabIndex = 11;
            this.LogResetButton.Text = "ログリセット";
            this.LogResetButton.UseVisualStyleBackColor = true;
            this.LogResetButton.Click += new System.EventHandler(this.LogResetButton_Click);
            // 
            // ModeSelectComboBox
            // 
            this.ModeSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelectComboBox.FormattingEnabled = true;
            this.ModeSelectComboBox.Items.AddRange(new object[] {
            "ダウンロード",
            "キャプチャ"});
            this.ModeSelectComboBox.Location = new System.Drawing.Point(13, 63);
            this.ModeSelectComboBox.Name = "ModeSelectComboBox";
            this.ModeSelectComboBox.Size = new System.Drawing.Size(87, 20);
            this.ModeSelectComboBox.TabIndex = 12;
            this.ModeSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeSelectComboBox_SelectedIndexChanged);
            // 
            // ModeSelectLabel
            // 
            this.ModeSelectLabel.AutoSize = true;
            this.ModeSelectLabel.Location = new System.Drawing.Point(106, 66);
            this.ModeSelectLabel.Name = "ModeSelectLabel";
            this.ModeSelectLabel.Size = new System.Drawing.Size(57, 12);
            this.ModeSelectLabel.TabIndex = 13;
            this.ModeSelectLabel.Text = "モード選択";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.ModeSelectLabel);
            this.Controls.Add(this.ModeSelectComboBox);
            this.Controls.Add(this.LogResetButton);
            this.Controls.Add(this.SaveImageText);
            this.Controls.Add(this.ResetSaveNum);
            this.Controls.Add(this.SaveNumberDescription);
            this.Controls.Add(this.SaveNumberText);
            this.Controls.Add(this.SelectSiteDropDown);
            this.Controls.Add(this.SaveTitleDescription);
            this.Controls.Add(this.SaveTitleText);
            this.Controls.Add(this.SaveDirButton);
            this.Controls.Add(this.SaveDirText);
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "MainForm";
            this.Text = "画像連番保存ツール";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SaveDirText;
        private System.Windows.Forms.Button SaveDirButton;
        private System.Windows.Forms.TextBox SaveTitleText;
        private System.Windows.Forms.Label SaveTitleDescription;
        private System.Windows.Forms.ComboBox SelectSiteDropDown;
        private System.Windows.Forms.TextBox SaveNumberText;
        private System.Windows.Forms.Label SaveNumberDescription;
        private System.Windows.Forms.Button ResetSaveNum;
        private System.Windows.Forms.TextBox SaveImageText;
        private System.Windows.Forms.Button LogResetButton;
        private System.Windows.Forms.ComboBox ModeSelectComboBox;
        private System.Windows.Forms.Label ModeSelectLabel;
    }
}

