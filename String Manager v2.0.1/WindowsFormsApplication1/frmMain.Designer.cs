namespace StringManager
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.btnRevertText = new System.Windows.Forms.Button();
            this.btnCpyClipboard = new System.Windows.Forms.Button();
            this.btnClearText = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tabFunc = new System.Windows.Forms.TabControl();
            this.tabReplace = new System.Windows.Forms.TabPage();
            this.chkRegexp = new System.Windows.Forms.CheckBox();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtReplaceB = new System.Windows.Forms.TextBox();
            this.txtReplaceA = new System.Windows.Forms.TextBox();
            this.tabTransform = new System.Windows.Forms.TabPage();
            this.btnHash = new System.Windows.Forms.Button();
            this.cmbHashType = new System.Windows.Forms.ComboBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.cmbEncodeType = new System.Windows.Forms.ComboBox();
            this.tabETC = new System.Windows.Forms.TabPage();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnCapitalize = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnLowerCase = new System.Windows.Forms.Button();
            this.btnUpperCase = new System.Windows.Forms.Button();
            this.grpResult.SuspendLayout();
            this.tabFunc.SuspendLayout();
            this.tabReplace.SuspendLayout();
            this.tabTransform.SuspendLayout();
            this.tabETC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.btnRevertText);
            this.grpResult.Controls.Add(this.btnCpyClipboard);
            this.grpResult.Controls.Add(this.btnClearText);
            this.grpResult.Controls.Add(this.lblSize);
            this.grpResult.Controls.Add(this.lblLength);
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Location = new System.Drawing.Point(12, 12);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(780, 290);
            this.grpResult.TabIndex = 0;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Input / Output";
            // 
            // btnRevertText
            // 
            this.btnRevertText.Enabled = false;
            this.btnRevertText.Location = new System.Drawing.Point(632, 254);
            this.btnRevertText.Name = "btnRevertText";
            this.btnRevertText.Size = new System.Drawing.Size(133, 27);
            this.btnRevertText.TabIndex = 12;
            this.btnRevertText.Text = "Revert text";
            this.btnRevertText.UseVisualStyleBackColor = true;
            this.btnRevertText.Click += new System.EventHandler(this.btnRevertText_Click);
            // 
            // btnCpyClipboard
            // 
            this.btnCpyClipboard.Location = new System.Drawing.Point(354, 254);
            this.btnCpyClipboard.Name = "btnCpyClipboard";
            this.btnCpyClipboard.Size = new System.Drawing.Size(133, 27);
            this.btnCpyClipboard.TabIndex = 11;
            this.btnCpyClipboard.Text = "Copy to clipboard";
            this.btnCpyClipboard.UseVisualStyleBackColor = true;
            this.btnCpyClipboard.Click += new System.EventHandler(this.btnCpyClipboard_Click);
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(493, 254);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(133, 27);
            this.btnClearText.TabIndex = 10;
            this.btnClearText.Text = "Clear text";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(147, 260);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(79, 15);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Size : 0 bytes";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 260);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(98, 15);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "Length : 0 letters";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 25);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(750, 215);
            this.txtResult.TabIndex = 7;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // tabFunc
            // 
            this.tabFunc.Controls.Add(this.tabReplace);
            this.tabFunc.Controls.Add(this.tabTransform);
            this.tabFunc.Controls.Add(this.tabETC);
            this.tabFunc.Location = new System.Drawing.Point(12, 312);
            this.tabFunc.Name = "tabFunc";
            this.tabFunc.SelectedIndex = 0;
            this.tabFunc.Size = new System.Drawing.Size(783, 225);
            this.tabFunc.TabIndex = 1;
            // 
            // tabReplace
            // 
            this.tabReplace.Controls.Add(this.chkRegexp);
            this.tabReplace.Controls.Add(this.chkIgnoreCase);
            this.tabReplace.Controls.Add(this.btnReplace);
            this.tabReplace.Controls.Add(this.txtReplaceB);
            this.tabReplace.Controls.Add(this.txtReplaceA);
            this.tabReplace.Location = new System.Drawing.Point(4, 24);
            this.tabReplace.Name = "tabReplace";
            this.tabReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabReplace.Size = new System.Drawing.Size(775, 197);
            this.tabReplace.TabIndex = 0;
            this.tabReplace.Text = "Replace";
            this.tabReplace.UseVisualStyleBackColor = true;
            // 
            // chkRegexp
            // 
            this.chkRegexp.AutoSize = true;
            this.chkRegexp.Location = new System.Drawing.Point(15, 165);
            this.chkRegexp.Name = "chkRegexp";
            this.chkRegexp.Size = new System.Drawing.Size(126, 19);
            this.chkRegexp.TabIndex = 14;
            this.chkRegexp.Text = "Regular Expression";
            this.chkRegexp.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.AutoSize = true;
            this.chkIgnoreCase.Location = new System.Drawing.Point(147, 165);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(87, 19);
            this.chkIgnoreCase.TabIndex = 13;
            this.chkIgnoreCase.Text = "Ignore case";
            this.chkIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(628, 160);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(133, 27);
            this.btnReplace.TabIndex = 12;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtReplaceB
            // 
            this.txtReplaceB.Location = new System.Drawing.Point(393, 15);
            this.txtReplaceB.Multiline = true;
            this.txtReplaceB.Name = "txtReplaceB";
            this.txtReplaceB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplaceB.Size = new System.Drawing.Size(368, 130);
            this.txtReplaceB.TabIndex = 1;
            // 
            // txtReplaceA
            // 
            this.txtReplaceA.AcceptsReturn = true;
            this.txtReplaceA.Location = new System.Drawing.Point(15, 15);
            this.txtReplaceA.Multiline = true;
            this.txtReplaceA.Name = "txtReplaceA";
            this.txtReplaceA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplaceA.Size = new System.Drawing.Size(368, 130);
            this.txtReplaceA.TabIndex = 0;
            // 
            // tabTransform
            // 
            this.tabTransform.Controls.Add(this.btnHash);
            this.tabTransform.Controls.Add(this.cmbHashType);
            this.tabTransform.Controls.Add(this.btnDecode);
            this.tabTransform.Controls.Add(this.btnEncode);
            this.tabTransform.Controls.Add(this.cmbEncodeType);
            this.tabTransform.Location = new System.Drawing.Point(4, 24);
            this.tabTransform.Name = "tabTransform";
            this.tabTransform.Size = new System.Drawing.Size(775, 197);
            this.tabTransform.TabIndex = 2;
            this.tabTransform.Text = "Transform";
            this.tabTransform.UseVisualStyleBackColor = true;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(248, 48);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(133, 27);
            this.btnHash.TabIndex = 15;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // cmbHashType
            // 
            this.cmbHashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHashType.FormattingEnabled = true;
            this.cmbHashType.Location = new System.Drawing.Point(11, 51);
            this.cmbHashType.Name = "cmbHashType";
            this.cmbHashType.Size = new System.Drawing.Size(221, 23);
            this.cmbHashType.TabIndex = 14;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(387, 10);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(133, 27);
            this.btnDecode.TabIndex = 13;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(248, 10);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(133, 27);
            this.btnEncode.TabIndex = 12;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // cmbEncodeType
            // 
            this.cmbEncodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncodeType.FormattingEnabled = true;
            this.cmbEncodeType.Location = new System.Drawing.Point(11, 13);
            this.cmbEncodeType.Name = "cmbEncodeType";
            this.cmbEncodeType.Size = new System.Drawing.Size(221, 23);
            this.cmbEncodeType.TabIndex = 0;
            // 
            // tabETC
            // 
            this.tabETC.Controls.Add(this.btnShuffle);
            this.tabETC.Controls.Add(this.btnTitle);
            this.tabETC.Controls.Add(this.btnCapitalize);
            this.tabETC.Controls.Add(this.btnTrim);
            this.tabETC.Controls.Add(this.btnReverse);
            this.tabETC.Controls.Add(this.btnLowerCase);
            this.tabETC.Controls.Add(this.btnUpperCase);
            this.tabETC.Location = new System.Drawing.Point(4, 24);
            this.tabETC.Name = "tabETC";
            this.tabETC.Padding = new System.Windows.Forms.Padding(3);
            this.tabETC.Size = new System.Drawing.Size(775, 197);
            this.tabETC.TabIndex = 1;
            this.tabETC.Text = "ETC";
            this.tabETC.UseVisualStyleBackColor = true;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(293, 48);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(133, 27);
            this.btnShuffle.TabIndex = 22;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(432, 15);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(133, 27);
            this.btnTitle.TabIndex = 21;
            this.btnTitle.Text = "Title";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnCapitalize
            // 
            this.btnCapitalize.Location = new System.Drawing.Point(293, 15);
            this.btnCapitalize.Name = "btnCapitalize";
            this.btnCapitalize.Size = new System.Drawing.Size(133, 27);
            this.btnCapitalize.TabIndex = 20;
            this.btnCapitalize.Text = "Capitalize";
            this.btnCapitalize.UseVisualStyleBackColor = true;
            this.btnCapitalize.Click += new System.EventHandler(this.btnCapitalize_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(154, 48);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(133, 27);
            this.btnTrim.TabIndex = 17;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(15, 48);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(133, 27);
            this.btnReverse.TabIndex = 16;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnLowerCase
            // 
            this.btnLowerCase.Location = new System.Drawing.Point(154, 15);
            this.btnLowerCase.Name = "btnLowerCase";
            this.btnLowerCase.Size = new System.Drawing.Size(133, 27);
            this.btnLowerCase.TabIndex = 14;
            this.btnLowerCase.Text = "Lower case";
            this.btnLowerCase.UseVisualStyleBackColor = true;
            this.btnLowerCase.Click += new System.EventHandler(this.btnLowerCase_Click);
            // 
            // btnUpperCase
            // 
            this.btnUpperCase.Location = new System.Drawing.Point(15, 15);
            this.btnUpperCase.Name = "btnUpperCase";
            this.btnUpperCase.Size = new System.Drawing.Size(133, 27);
            this.btnUpperCase.TabIndex = 13;
            this.btnUpperCase.Text = "Upper case";
            this.btnUpperCase.UseVisualStyleBackColor = true;
            this.btnUpperCase.Click += new System.EventHandler(this.btnUpperCase_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 551);
            this.Controls.Add(this.tabFunc);
            this.Controls.Add(this.grpResult);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 590);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Manager v2.0.1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.tabFunc.ResumeLayout(false);
            this.tabReplace.ResumeLayout(false);
            this.tabReplace.PerformLayout();
            this.tabTransform.ResumeLayout(false);
            this.tabETC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Button btnRevertText;
        private System.Windows.Forms.Button btnCpyClipboard;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TabControl tabFunc;
        private System.Windows.Forms.TabPage tabReplace;
        private System.Windows.Forms.TabPage tabETC;
        private System.Windows.Forms.TextBox txtReplaceB;
        private System.Windows.Forms.TextBox txtReplaceA;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TabPage tabTransform;
        private System.Windows.Forms.CheckBox chkRegexp;
        private System.Windows.Forms.ComboBox cmbEncodeType;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.ComboBox cmbHashType;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnLowerCase;
        private System.Windows.Forms.Button btnUpperCase;
        private System.Windows.Forms.Button btnCapitalize;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnShuffle;
    }
}

