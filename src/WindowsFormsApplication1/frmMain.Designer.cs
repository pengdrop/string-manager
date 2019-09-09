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
            this.btnCpyClipboard = new System.Windows.Forms.Button();
            this.btnClearText = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tabFunc = new System.Windows.Forms.TabControl();
            this.tabEncodement = new System.Windows.Forms.TabPage();
            this.btnROT13Encode = new System.Windows.Forms.Button();
            this.btnBase64Decode = new System.Windows.Forms.Button();
            this.btnBase64Encode = new System.Windows.Forms.Button();
            this.btnHTMLDecode = new System.Windows.Forms.Button();
            this.btnHTMLEncode = new System.Windows.Forms.Button();
            this.btnHexDecode = new System.Windows.Forms.Button();
            this.btnHexEncode = new System.Windows.Forms.Button();
            this.btnURLDecode = new System.Windows.Forms.Button();
            this.btnURLEncode = new System.Windows.Forms.Button();
            this.tabHashment = new System.Windows.Forms.TabPage();
            this.btnCRC16Hash = new System.Windows.Forms.Button();
            this.btnWhirlpoolHash = new System.Windows.Forms.Button();
            this.radUseLowerCase = new System.Windows.Forms.RadioButton();
            this.radUseUpperCase = new System.Windows.Forms.RadioButton();
            this.btnSHA512Hash = new System.Windows.Forms.Button();
            this.btnSHA384Hash = new System.Windows.Forms.Button();
            this.btnCRC32Hash = new System.Windows.Forms.Button();
            this.btnSHA256Hash = new System.Windows.Forms.Button();
            this.btnSHA1Hash = new System.Windows.Forms.Button();
            this.btnMD5Hash = new System.Windows.Forms.Button();
            this.tabReplacement = new System.Windows.Forms.TabPage();
            this.chkRegexp = new System.Windows.Forms.CheckBox();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtReplaceB = new System.Windows.Forms.TextBox();
            this.txtReplaceA = new System.Windows.Forms.TextBox();
            this.tabTransforment = new System.Windows.Forms.TabPage();
            this.btnAscArr = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnCapitalize = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnLowerCase = new System.Windows.Forms.Button();
            this.btnUpperCase = new System.Windows.Forms.Button();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpResult.SuspendLayout();
            this.tabFunc.SuspendLayout();
            this.tabEncodement.SuspendLayout();
            this.tabHashment.SuspendLayout();
            this.tabReplacement.SuspendLayout();
            this.tabTransforment.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.btnCpyClipboard);
            this.grpResult.Controls.Add(this.btnClearText);
            this.grpResult.Controls.Add(this.lblSize);
            this.grpResult.Controls.Add(this.lblLength);
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Location = new System.Drawing.Point(12, 12);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(725, 336);
            this.grpResult.TabIndex = 0;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Input / Output";
            // 
            // btnCpyClipboard
            // 
            this.btnCpyClipboard.Location = new System.Drawing.Point(441, 300);
            this.btnCpyClipboard.Name = "btnCpyClipboard";
            this.btnCpyClipboard.Size = new System.Drawing.Size(133, 27);
            this.btnCpyClipboard.TabIndex = 11;
            this.btnCpyClipboard.Text = "Copy to Clipboard";
            this.btnCpyClipboard.UseVisualStyleBackColor = true;
            this.btnCpyClipboard.Click += new System.EventHandler(this.btnCpyClipboard_Click);
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(580, 300);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(133, 27);
            this.btnClearText.TabIndex = 10;
            this.btnClearText.Text = "Clear";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(147, 306);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(79, 15);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Size : 0 bytes";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 306);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(98, 15);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "Length : 0 letters";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 25);
            this.txtResult.MaxLength = 2147483647;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(698, 269);
            this.txtResult.TabIndex = 7;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // tabFunc
            // 
            this.tabFunc.Controls.Add(this.tabEncodement);
            this.tabFunc.Controls.Add(this.tabHashment);
            this.tabFunc.Controls.Add(this.tabReplacement);
            this.tabFunc.Controls.Add(this.tabTransforment);
            this.tabFunc.Controls.Add(this.tabAbout);
            this.tabFunc.Location = new System.Drawing.Point(12, 354);
            this.tabFunc.Name = "tabFunc";
            this.tabFunc.SelectedIndex = 0;
            this.tabFunc.Size = new System.Drawing.Size(725, 209);
            this.tabFunc.TabIndex = 1;
            // 
            // tabEncodement
            // 
            this.tabEncodement.Controls.Add(this.btnROT13Encode);
            this.tabEncodement.Controls.Add(this.btnBase64Decode);
            this.tabEncodement.Controls.Add(this.btnBase64Encode);
            this.tabEncodement.Controls.Add(this.btnHTMLDecode);
            this.tabEncodement.Controls.Add(this.btnHTMLEncode);
            this.tabEncodement.Controls.Add(this.btnHexDecode);
            this.tabEncodement.Controls.Add(this.btnHexEncode);
            this.tabEncodement.Controls.Add(this.btnURLDecode);
            this.tabEncodement.Controls.Add(this.btnURLEncode);
            this.tabEncodement.Location = new System.Drawing.Point(4, 24);
            this.tabEncodement.Name = "tabEncodement";
            this.tabEncodement.Size = new System.Drawing.Size(717, 181);
            this.tabEncodement.TabIndex = 2;
            this.tabEncodement.Text = "Encodement";
            this.tabEncodement.UseVisualStyleBackColor = true;
            // 
            // btnROT13Encode
            // 
            this.btnROT13Encode.Location = new System.Drawing.Point(11, 146);
            this.btnROT13Encode.Name = "btnROT13Encode";
            this.btnROT13Encode.Size = new System.Drawing.Size(133, 27);
            this.btnROT13Encode.TabIndex = 24;
            this.btnROT13Encode.Text = "ROT13 Encode";
            this.btnROT13Encode.UseVisualStyleBackColor = true;
            this.btnROT13Encode.Click += new System.EventHandler(this.BtnROT13Encode_Click);
            // 
            // btnBase64Decode
            // 
            this.btnBase64Decode.Location = new System.Drawing.Point(150, 113);
            this.btnBase64Decode.Name = "btnBase64Decode";
            this.btnBase64Decode.Size = new System.Drawing.Size(133, 27);
            this.btnBase64Decode.TabIndex = 23;
            this.btnBase64Decode.Text = "Base64 Decode";
            this.btnBase64Decode.UseVisualStyleBackColor = true;
            this.btnBase64Decode.Click += new System.EventHandler(this.BtnBase64Decode_Click);
            // 
            // btnBase64Encode
            // 
            this.btnBase64Encode.Location = new System.Drawing.Point(11, 113);
            this.btnBase64Encode.Name = "btnBase64Encode";
            this.btnBase64Encode.Size = new System.Drawing.Size(133, 27);
            this.btnBase64Encode.TabIndex = 22;
            this.btnBase64Encode.Text = "Base64 Encode";
            this.btnBase64Encode.UseVisualStyleBackColor = true;
            this.btnBase64Encode.Click += new System.EventHandler(this.BtnBase64Encode_Click);
            // 
            // btnHTMLDecode
            // 
            this.btnHTMLDecode.Location = new System.Drawing.Point(150, 80);
            this.btnHTMLDecode.Name = "btnHTMLDecode";
            this.btnHTMLDecode.Size = new System.Drawing.Size(133, 27);
            this.btnHTMLDecode.TabIndex = 21;
            this.btnHTMLDecode.Text = "HTML Decode";
            this.btnHTMLDecode.UseVisualStyleBackColor = true;
            this.btnHTMLDecode.Click += new System.EventHandler(this.BtnHTMLDecode_Click);
            // 
            // btnHTMLEncode
            // 
            this.btnHTMLEncode.Location = new System.Drawing.Point(11, 80);
            this.btnHTMLEncode.Name = "btnHTMLEncode";
            this.btnHTMLEncode.Size = new System.Drawing.Size(133, 27);
            this.btnHTMLEncode.TabIndex = 20;
            this.btnHTMLEncode.Text = "HTML Encode";
            this.btnHTMLEncode.UseVisualStyleBackColor = true;
            this.btnHTMLEncode.Click += new System.EventHandler(this.BtnHTMLEncode_Click);
            // 
            // btnHexDecode
            // 
            this.btnHexDecode.Location = new System.Drawing.Point(150, 47);
            this.btnHexDecode.Name = "btnHexDecode";
            this.btnHexDecode.Size = new System.Drawing.Size(133, 27);
            this.btnHexDecode.TabIndex = 19;
            this.btnHexDecode.Text = "Hex Decode";
            this.btnHexDecode.UseVisualStyleBackColor = true;
            this.btnHexDecode.Click += new System.EventHandler(this.BtnHexDecode_Click);
            // 
            // btnHexEncode
            // 
            this.btnHexEncode.Location = new System.Drawing.Point(11, 47);
            this.btnHexEncode.Name = "btnHexEncode";
            this.btnHexEncode.Size = new System.Drawing.Size(133, 27);
            this.btnHexEncode.TabIndex = 18;
            this.btnHexEncode.Text = "Hex Encode";
            this.btnHexEncode.UseVisualStyleBackColor = true;
            this.btnHexEncode.Click += new System.EventHandler(this.BtnHexEncode_Click);
            // 
            // btnURLDecode
            // 
            this.btnURLDecode.Location = new System.Drawing.Point(150, 14);
            this.btnURLDecode.Name = "btnURLDecode";
            this.btnURLDecode.Size = new System.Drawing.Size(133, 27);
            this.btnURLDecode.TabIndex = 17;
            this.btnURLDecode.Text = "URL Decode";
            this.btnURLDecode.UseVisualStyleBackColor = true;
            this.btnURLDecode.Click += new System.EventHandler(this.BtnURLDecode_Click);
            // 
            // btnURLEncode
            // 
            this.btnURLEncode.Location = new System.Drawing.Point(11, 14);
            this.btnURLEncode.Name = "btnURLEncode";
            this.btnURLEncode.Size = new System.Drawing.Size(133, 27);
            this.btnURLEncode.TabIndex = 16;
            this.btnURLEncode.Text = "URL Encode";
            this.btnURLEncode.UseVisualStyleBackColor = true;
            this.btnURLEncode.Click += new System.EventHandler(this.BtnURLEncode_Click);
            // 
            // tabHashment
            // 
            this.tabHashment.Controls.Add(this.btnCRC16Hash);
            this.tabHashment.Controls.Add(this.btnWhirlpoolHash);
            this.tabHashment.Controls.Add(this.radUseLowerCase);
            this.tabHashment.Controls.Add(this.radUseUpperCase);
            this.tabHashment.Controls.Add(this.btnSHA512Hash);
            this.tabHashment.Controls.Add(this.btnSHA384Hash);
            this.tabHashment.Controls.Add(this.btnCRC32Hash);
            this.tabHashment.Controls.Add(this.btnSHA256Hash);
            this.tabHashment.Controls.Add(this.btnSHA1Hash);
            this.tabHashment.Controls.Add(this.btnMD5Hash);
            this.tabHashment.Location = new System.Drawing.Point(4, 24);
            this.tabHashment.Name = "tabHashment";
            this.tabHashment.Size = new System.Drawing.Size(717, 181);
            this.tabHashment.TabIndex = 3;
            this.tabHashment.Text = "Hashment";
            this.tabHashment.UseVisualStyleBackColor = true;
            // 
            // btnCRC16Hash
            // 
            this.btnCRC16Hash.Location = new System.Drawing.Point(11, 13);
            this.btnCRC16Hash.Name = "btnCRC16Hash";
            this.btnCRC16Hash.Size = new System.Drawing.Size(133, 27);
            this.btnCRC16Hash.TabIndex = 38;
            this.btnCRC16Hash.Text = "CRC16/MODBUS";
            this.btnCRC16Hash.UseVisualStyleBackColor = true;
            this.btnCRC16Hash.Click += new System.EventHandler(this.BtnCRC16Hash_Click);
            // 
            // btnWhirlpoolHash
            // 
            this.btnWhirlpoolHash.Location = new System.Drawing.Point(11, 112);
            this.btnWhirlpoolHash.Name = "btnWhirlpoolHash";
            this.btnWhirlpoolHash.Size = new System.Drawing.Size(133, 27);
            this.btnWhirlpoolHash.TabIndex = 37;
            this.btnWhirlpoolHash.Text = "Whirlpool";
            this.btnWhirlpoolHash.UseVisualStyleBackColor = true;
            this.btnWhirlpoolHash.Click += new System.EventHandler(this.BtnWhirlpoolHash_Click);
            // 
            // radUseLowerCase
            // 
            this.radUseLowerCase.AutoSize = true;
            this.radUseLowerCase.Checked = true;
            this.radUseLowerCase.Location = new System.Drawing.Point(11, 157);
            this.radUseLowerCase.Name = "radUseLowerCase";
            this.radUseLowerCase.Size = new System.Drawing.Size(151, 19);
            this.radUseLowerCase.TabIndex = 36;
            this.radUseLowerCase.TabStop = true;
            this.radUseLowerCase.Text = "Use Lower Case (%02x)";
            this.radUseLowerCase.UseVisualStyleBackColor = true;
            // 
            // radUseUpperCase
            // 
            this.radUseUpperCase.AutoSize = true;
            this.radUseUpperCase.Location = new System.Drawing.Point(168, 157);
            this.radUseUpperCase.Name = "radUseUpperCase";
            this.radUseUpperCase.Size = new System.Drawing.Size(152, 19);
            this.radUseUpperCase.TabIndex = 35;
            this.radUseUpperCase.Text = "Use Upper Case (%02X)";
            this.radUseUpperCase.UseVisualStyleBackColor = true;
            // 
            // btnSHA512Hash
            // 
            this.btnSHA512Hash.Location = new System.Drawing.Point(428, 79);
            this.btnSHA512Hash.Name = "btnSHA512Hash";
            this.btnSHA512Hash.Size = new System.Drawing.Size(133, 27);
            this.btnSHA512Hash.TabIndex = 33;
            this.btnSHA512Hash.Text = "SHA512";
            this.btnSHA512Hash.UseVisualStyleBackColor = true;
            this.btnSHA512Hash.Click += new System.EventHandler(this.BtnSHA512Hash_Click);
            // 
            // btnSHA384Hash
            // 
            this.btnSHA384Hash.Location = new System.Drawing.Point(289, 79);
            this.btnSHA384Hash.Name = "btnSHA384Hash";
            this.btnSHA384Hash.Size = new System.Drawing.Size(133, 27);
            this.btnSHA384Hash.TabIndex = 32;
            this.btnSHA384Hash.Text = "SHA384";
            this.btnSHA384Hash.UseVisualStyleBackColor = true;
            this.btnSHA384Hash.Click += new System.EventHandler(this.BtnSHA384Hash_Click);
            // 
            // btnCRC32Hash
            // 
            this.btnCRC32Hash.Location = new System.Drawing.Point(150, 13);
            this.btnCRC32Hash.Name = "btnCRC32Hash";
            this.btnCRC32Hash.Size = new System.Drawing.Size(133, 27);
            this.btnCRC32Hash.TabIndex = 31;
            this.btnCRC32Hash.Text = "CRC32";
            this.btnCRC32Hash.UseVisualStyleBackColor = true;
            this.btnCRC32Hash.Click += new System.EventHandler(this.BtnCRC32Hash_Click);
            // 
            // btnSHA256Hash
            // 
            this.btnSHA256Hash.Location = new System.Drawing.Point(150, 79);
            this.btnSHA256Hash.Name = "btnSHA256Hash";
            this.btnSHA256Hash.Size = new System.Drawing.Size(133, 27);
            this.btnSHA256Hash.TabIndex = 30;
            this.btnSHA256Hash.Text = "SHA256";
            this.btnSHA256Hash.UseVisualStyleBackColor = true;
            this.btnSHA256Hash.Click += new System.EventHandler(this.BtnSHA256Hash_Click);
            // 
            // btnSHA1Hash
            // 
            this.btnSHA1Hash.Location = new System.Drawing.Point(11, 79);
            this.btnSHA1Hash.Name = "btnSHA1Hash";
            this.btnSHA1Hash.Size = new System.Drawing.Size(133, 27);
            this.btnSHA1Hash.TabIndex = 29;
            this.btnSHA1Hash.Text = "SHA1";
            this.btnSHA1Hash.UseVisualStyleBackColor = true;
            this.btnSHA1Hash.Click += new System.EventHandler(this.BtnSHA1Hash_Click);
            // 
            // btnMD5Hash
            // 
            this.btnMD5Hash.Location = new System.Drawing.Point(11, 46);
            this.btnMD5Hash.Name = "btnMD5Hash";
            this.btnMD5Hash.Size = new System.Drawing.Size(133, 27);
            this.btnMD5Hash.TabIndex = 27;
            this.btnMD5Hash.Text = "MD5";
            this.btnMD5Hash.UseVisualStyleBackColor = true;
            this.btnMD5Hash.Click += new System.EventHandler(this.BtnMD5Hash_Click);
            // 
            // tabReplacement
            // 
            this.tabReplacement.Controls.Add(this.chkRegexp);
            this.tabReplacement.Controls.Add(this.chkIgnoreCase);
            this.tabReplacement.Controls.Add(this.btnReplace);
            this.tabReplacement.Controls.Add(this.txtReplaceB);
            this.tabReplacement.Controls.Add(this.txtReplaceA);
            this.tabReplacement.Location = new System.Drawing.Point(4, 24);
            this.tabReplacement.Name = "tabReplacement";
            this.tabReplacement.Padding = new System.Windows.Forms.Padding(3);
            this.tabReplacement.Size = new System.Drawing.Size(717, 181);
            this.tabReplacement.TabIndex = 0;
            this.tabReplacement.Text = "Replacement";
            this.tabReplacement.UseVisualStyleBackColor = true;
            // 
            // chkRegexp
            // 
            this.chkRegexp.AutoSize = true;
            this.chkRegexp.Location = new System.Drawing.Point(11, 157);
            this.chkRegexp.Name = "chkRegexp";
            this.chkRegexp.Size = new System.Drawing.Size(149, 19);
            this.chkRegexp.TabIndex = 14;
            this.chkRegexp.Text = "Use Regular Expression";
            this.chkRegexp.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.AutoSize = true;
            this.chkIgnoreCase.Location = new System.Drawing.Point(166, 157);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(89, 19);
            this.chkIgnoreCase.TabIndex = 13;
            this.chkIgnoreCase.Text = "Ignore Case";
            this.chkIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(572, 149);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(133, 27);
            this.btnReplace.TabIndex = 12;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtReplaceB
            // 
            this.txtReplaceB.Location = new System.Drawing.Point(361, 15);
            this.txtReplaceB.Multiline = true;
            this.txtReplaceB.Name = "txtReplaceB";
            this.txtReplaceB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplaceB.Size = new System.Drawing.Size(344, 128);
            this.txtReplaceB.TabIndex = 1;
            // 
            // txtReplaceA
            // 
            this.txtReplaceA.AcceptsReturn = true;
            this.txtReplaceA.Location = new System.Drawing.Point(11, 15);
            this.txtReplaceA.Multiline = true;
            this.txtReplaceA.Name = "txtReplaceA";
            this.txtReplaceA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplaceA.Size = new System.Drawing.Size(344, 128);
            this.txtReplaceA.TabIndex = 0;
            // 
            // tabTransforment
            // 
            this.tabTransforment.Controls.Add(this.btnAscArr);
            this.tabTransforment.Controls.Add(this.btnShuffle);
            this.tabTransforment.Controls.Add(this.btnTitle);
            this.tabTransforment.Controls.Add(this.btnCapitalize);
            this.tabTransforment.Controls.Add(this.btnTrim);
            this.tabTransforment.Controls.Add(this.btnReverse);
            this.tabTransforment.Controls.Add(this.btnLowerCase);
            this.tabTransforment.Controls.Add(this.btnUpperCase);
            this.tabTransforment.Location = new System.Drawing.Point(4, 24);
            this.tabTransforment.Name = "tabTransforment";
            this.tabTransforment.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransforment.Size = new System.Drawing.Size(717, 181);
            this.tabTransforment.TabIndex = 1;
            this.tabTransforment.Text = "Transforment";
            this.tabTransforment.UseVisualStyleBackColor = true;
            // 
            // btnAscArr
            // 
            this.btnAscArr.Location = new System.Drawing.Point(15, 81);
            this.btnAscArr.Name = "btnAscArr";
            this.btnAscArr.Size = new System.Drawing.Size(133, 27);
            this.btnAscArr.TabIndex = 23;
            this.btnAscArr.Text = "ASCII Array";
            this.btnAscArr.UseVisualStyleBackColor = true;
            this.btnAscArr.Click += new System.EventHandler(this.BtnAscArr_Click);
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
            this.btnTitle.Text = "Title Case";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnCapitalize
            // 
            this.btnCapitalize.Location = new System.Drawing.Point(293, 15);
            this.btnCapitalize.Name = "btnCapitalize";
            this.btnCapitalize.Size = new System.Drawing.Size(133, 27);
            this.btnCapitalize.TabIndex = 20;
            this.btnCapitalize.Text = "Capitalized Case";
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
            this.btnLowerCase.Text = "Lower Case";
            this.btnLowerCase.UseVisualStyleBackColor = true;
            this.btnLowerCase.Click += new System.EventHandler(this.btnLowerCase_Click);
            // 
            // btnUpperCase
            // 
            this.btnUpperCase.Location = new System.Drawing.Point(15, 15);
            this.btnUpperCase.Name = "btnUpperCase";
            this.btnUpperCase.Size = new System.Drawing.Size(133, 27);
            this.btnUpperCase.TabIndex = 13;
            this.btnUpperCase.Text = "Upper Case";
            this.btnUpperCase.UseVisualStyleBackColor = true;
            this.btnUpperCase.Click += new System.EventHandler(this.btnUpperCase_Click);
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lnkGithub);
            this.tabAbout.Controls.Add(this.label1);
            this.tabAbout.Location = new System.Drawing.Point(4, 24);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(717, 181);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lnkGithub
            // 
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.LinkColor = System.Drawing.Color.Blue;
            this.lnkGithub.Location = new System.Drawing.Point(17, 44);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(249, 15);
            this.lnkGithub.TabIndex = 1;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "https://github.com/safflower/string-manager";
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkGithub_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Made by Safflower";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 575);
            this.Controls.Add(this.tabFunc);
            this.Controls.Add(this.grpResult);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Manager v2.0.2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.tabFunc.ResumeLayout(false);
            this.tabEncodement.ResumeLayout(false);
            this.tabHashment.ResumeLayout(false);
            this.tabHashment.PerformLayout();
            this.tabReplacement.ResumeLayout(false);
            this.tabReplacement.PerformLayout();
            this.tabTransforment.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Button btnCpyClipboard;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TabControl tabFunc;
        private System.Windows.Forms.TabPage tabReplacement;
        private System.Windows.Forms.TabPage tabTransforment;
        private System.Windows.Forms.TextBox txtReplaceB;
        private System.Windows.Forms.TextBox txtReplaceA;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TabPage tabEncodement;
        private System.Windows.Forms.CheckBox chkRegexp;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnLowerCase;
        private System.Windows.Forms.Button btnUpperCase;
        private System.Windows.Forms.Button btnCapitalize;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnAscArr;
        private System.Windows.Forms.Button btnURLDecode;
        private System.Windows.Forms.Button btnURLEncode;
        private System.Windows.Forms.Button btnHexDecode;
        private System.Windows.Forms.Button btnHexEncode;
        private System.Windows.Forms.Button btnBase64Decode;
        private System.Windows.Forms.Button btnBase64Encode;
        private System.Windows.Forms.Button btnHTMLDecode;
        private System.Windows.Forms.Button btnHTMLEncode;
        private System.Windows.Forms.TabPage tabHashment;
        private System.Windows.Forms.Button btnMD5Hash;
        private System.Windows.Forms.Button btnSHA1Hash;
        private System.Windows.Forms.Button btnSHA256Hash;
        private System.Windows.Forms.Button btnCRC32Hash;
        private System.Windows.Forms.Button btnSHA384Hash;
        private System.Windows.Forms.Button btnSHA512Hash;
        private System.Windows.Forms.RadioButton radUseLowerCase;
        private System.Windows.Forms.RadioButton radUseUpperCase;
        private System.Windows.Forms.Button btnROT13Encode;
        private System.Windows.Forms.Button btnWhirlpoolHash;
        private System.Windows.Forms.Button btnCRC16Hash;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.Label label1;
    }
}

