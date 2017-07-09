using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringManager
{
    public partial class frmMain : Form
    {
        string sBackup;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbEncodeType.Items.Add("URL Encode / Decode");
            cmbEncodeType.Items.Add("Hex Encode / Decode");
            cmbEncodeType.Items.Add("HTML Encode / Decode");
            cmbEncodeType.Items.Add("Base64 Encode / Decode");
            cmbEncodeType.Items.Add("Rot13 Encode / Decode");
            cmbEncodeType.Text = "URL Encode / Decode";

            cmbHashType.Items.Add("MD5 Hash");
            cmbHashType.Items.Add("CRC32 Hash");
            cmbHashType.Items.Add("SHA1 Hash");
            cmbHashType.Items.Add("SHA256 Hash");
            cmbHashType.Items.Add("SHA384 Hash");
            cmbHashType.Items.Add("SHA512 Hash");
            cmbHashType.Text = "MD5 Hash"; 
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            lblLength.Text = "Length : " + txtResult.Text.Length.ToString() + " letters";
            lblSize.Text = "Size : " + Encoding.Default.GetBytes(txtResult.Text).Length.ToString() + " bytes";
        }

        private void btnCpyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtResult.Text);
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            sBackup = txtResult.Text;
            btnRevertText.Enabled = true;

            if (chkRegexp.Checked)
            {
                txtResult.Text = Regex.Replace(txtResult.Text, txtReplaceA.Text, txtReplaceB.Text, chkIgnoreCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None);
            }
            else
            {
                txtResult.Text = Regex.Replace(txtResult.Text, System.Text.RegularExpressions.Regex.Escape(txtReplaceA.Text), txtReplaceB.Text, chkIgnoreCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None);
            }

        }

        private void btnRevertText_Click(object sender, EventArgs e)
        {
            string sRes = txtResult.Text;

            txtResult.Text = sBackup;
            btnRevertText.Enabled = true;

            sBackup = sRes;
        }
      

        private void btnEncode_Click(object sender, EventArgs e)
        {
            sBackup = txtResult.Text;
            btnRevertText.Enabled = true;
       
            switch (cmbEncodeType.SelectedItem.ToString())
            {
                case "URL Encode / Decode":
                    txtResult.Text = Url.Encode(txtResult.Text);
                    break;
                    
                case "Hex Encode / Decode":
                    txtResult.Text = Hex.Encode(txtResult.Text);
                    break;

                case "HTML Encode / Decode":
                    txtResult.Text = Html.Encode(txtResult.Text);
                    break;

                case "Base64 Encode / Decode":
                    txtResult.Text = Base64.Encode(txtResult.Text);
                    break;

                case "Rot13 Encode / Decode":
                    txtResult.Text = Rot13.Encode(txtResult.Text);
                    break;
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            sBackup = txtResult.Text;
            btnRevertText.Enabled = true;

            switch (cmbEncodeType.SelectedItem.ToString())
            {
                case "URL Encode / Decode":
                    txtResult.Text = Url.Decode(txtResult.Text);
                    break;
                    
                case "Hex Encode / Decode":
                    txtResult.Text = Hex.Decode(txtResult.Text);
                    break;

                case "HTML Encode / Decode":
                    txtResult.Text = Html.Decode(txtResult.Text);
                    break;

                case "Base64 Encode / Decode":
                    txtResult.Text = Base64.Decode(txtResult.Text);
                    break;

                case "Rot13 Encode / Decode":
                    txtResult.Text = Rot13.Decode(txtResult.Text);
                    break;
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            sBackup = txtResult.Text;
            btnRevertText.Enabled = true;
            
            switch (cmbHashType.SelectedItem.ToString())
            {
                case "MD5 Hash":
                    txtResult.Text = MD5.Hash(txtResult.Text);
                    break;

                case "CRC32 Hash":
                    txtResult.Text = CRC32.Hash(txtResult.Text);
                    break;

                case "SHA1 Hash":
                    txtResult.Text = SHA1.Hash(txtResult.Text);
                    break;

                case "SHA256 Hash":
                    txtResult.Text = SHA256.Hash(txtResult.Text);
                    break;

                case "SHA384 Hash":
                    txtResult.Text = SHA384.Hash(txtResult.Text);
                    break;

                case "SHA512 Hash":
                    txtResult.Text = SHA512.Hash(txtResult.Text);
                    break;
            }
        }

        private void btnUpperCase_Click(object sender, EventArgs e)
        {
            sBackup = txtResult.Text;
            btnRevertText.Enabled = true;

            txtResult.Text = txtResult.Text.ToUpper();
        }

        private void btnLowerCase_Click(object sender, EventArgs e)
        {
            sBackup = txtResult.Text;
            btnRevertText.Enabled = true;

            txtResult.Text = txtResult.Text.ToLower();
        }

        private void btnCapitalize_Click(object sender, EventArgs e)
        {
            sBackup = txtResult.Text;
            btnRevertText.Enabled = true;

            bool isClear = true;
            char[] array = txtResult.Text.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int ascii = (int)array[i];
                if (ascii == '\n')
                {
                    isClear = true;
                }
                else if (isClear)
                {
                    if (ascii >= 'a' && ascii <= 'z')
                    {
                        ascii -= 32;
                    }
                    isClear = false;
                }
                else if (ascii >= 'A' && ascii <= 'Z')
                {
                    ascii += 32;
                }

                array[i] = (char)ascii;
            }
            txtResult.Text = new string(array);
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            sBackup = txtResult.Text;
            btnRevertText.Enabled = true;

            bool isClear = true;
            char[] array = txtResult.Text.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int ascii = (int)array[i];
                if (ascii == ' ' || ascii == '\n' || ascii == '.' || ascii == '!' || ascii == '?')
                {
                    isClear = true;
                }
                else if (isClear)
                {
                    if (ascii >= 'a' && ascii <= 'z')
                    {
                        ascii -= 32;
                    }
                    isClear = false;
                }
                else if (ascii >= 'A' && ascii <= 'Z')
                {
                    ascii += 32;
                }

                array[i] = (char)ascii;
            }
            txtResult.Text = new string(array);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            sBackup = txtResult.Text;
            btnRevertText.Enabled = true;

            txtResult.Text = new string(txtResult.Text.ToCharArray().Reverse().ToArray());
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            sBackup = txtResult.Text;
            btnRevertText.Enabled = true;

            txtResult.Text = txtResult.Text.Trim();
        }
    }

    static class Url
    {
        public static string Encode(string value)
        {
            return HttpUtility.UrlEncode(value);
        }
        public static string Decode(string value)
        {
            return HttpUtility.UrlDecode(value);
        }
    }

    static class Hex
    {
        public static string Encode(string value)
        {
            var res = new StringBuilder();
            foreach (var t in Encoding.UTF8.GetBytes(value))
            {
                res.Append(t.ToString("X2"));
            }
            return res.ToString();
        }

        public static string Decode(string value)
        {
            var bytes = new byte[value.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(value.Substring(i * 2, 2), 16);
            }
            return Encoding.UTF8.GetString(bytes);
        }
    }

    static class Html
    {
        public static string Encode(string value)
        {
            return HttpUtility.HtmlEncode(value);
        }
        public static string Decode(string value)
        {
            return HttpUtility.HtmlDecode(value);
        }
    }

    static class Base64
    {
        public static string Encode(string value)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
        }
        public static string Decode(string value)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(value));
        }
    }

    static class Rot13
    {
        public static string Encode(string value)
        {
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int ascii = (int)array[i];
                if (ascii >= 'a' && ascii <= 'z')
                {
                    if (ascii > 'm') ascii -= 13;
                    else ascii += 13;
                }
                else if (ascii >= 'A' && ascii <= 'Z')
                {
                    if (ascii > 'M') ascii -= 13;
                    else ascii += 13;
                }
                array[i] = (char)ascii;
            }
            return new string(array);
        }
        public static string Decode(string value)
        {
            return Rot13.Encode(value);
        }
    }

    static class MD5
    {
        public static string Hash(string value)
        {
            var res = new StringBuilder();
            foreach (var t in new MD5CryptoServiceProvider().ComputeHash(new UTF8Encoding().GetBytes(value)))
            {
                res.Append(t.ToString("X2"));
            }
            return res.ToString();
        }
    }

    static class CRC32
    {
        public static string Hash(string value)
        {
            var table = new uint[]{
                0x00000000, 0x77073096, 0xEE0E612C, 0x990951BA, 0x076DC419, 0x706AF48F,
                0xE963A535, 0x9E6495A3, 0x0EDB8832, 0x79DCB8A4, 0xE0D5E91E, 0x97D2D988,
                0x09B64C2B, 0x7EB17CBD, 0xE7B82D07, 0x90BF1D91, 0x1DB71064, 0x6AB020F2,
                0xF3B97148, 0x84BE41DE, 0x1ADAD47D, 0x6DDDE4EB, 0xF4D4B551, 0x83D385C7,
                0x136C9856, 0x646BA8C0, 0xFD62F97A, 0x8A65C9EC, 0x14015C4F, 0x63066CD9,
                0xFA0F3D63, 0x8D080DF5, 0x3B6E20C8, 0x4C69105E, 0xD56041E4, 0xA2677172,
                0x3C03E4D1, 0x4B04D447, 0xD20D85FD, 0xA50AB56B, 0x35B5A8FA, 0x42B2986C,
                0xDBBBC9D6, 0xACBCF940, 0x32D86CE3, 0x45DF5C75, 0xDCD60DCF, 0xABD13D59,
                0x26D930AC, 0x51DE003A, 0xC8D75180, 0xBFD06116, 0x21B4F4B5, 0x56B3C423,
                0xCFBA9599, 0xB8BDA50F, 0x2802B89E, 0x5F058808, 0xC60CD9B2, 0xB10BE924,
                0x2F6F7C87, 0x58684C11, 0xC1611DAB, 0xB6662D3D, 0x76DC4190, 0x01DB7106,
                0x98D220BC, 0xEFD5102A, 0x71B18589, 0x06B6B51F, 0x9FBFE4A5, 0xE8B8D433,
                0x7807C9A2, 0x0F00F934, 0x9609A88E, 0xE10E9818, 0x7F6A0DBB, 0x086D3D2D,
                0x91646C97, 0xE6635C01, 0x6B6B51F4, 0x1C6C6162, 0x856530D8, 0xF262004E,
                0x6C0695ED, 0x1B01A57B, 0x8208F4C1, 0xF50FC457, 0x65B0D9C6, 0x12B7E950,
                0x8BBEB8EA, 0xFCB9887C, 0x62DD1DDF, 0x15DA2D49, 0x8CD37CF3, 0xFBD44C65,
                0x4DB26158, 0x3AB551CE, 0xA3BC0074, 0xD4BB30E2, 0x4ADFA541, 0x3DD895D7,
                0xA4D1C46D, 0xD3D6F4FB, 0x4369E96A, 0x346ED9FC, 0xAD678846, 0xDA60B8D0,
                0x44042D73, 0x33031DE5, 0xAA0A4C5F, 0xDD0D7CC9, 0x5005713C, 0x270241AA,
                0xBE0B1010, 0xC90C2086, 0x5768B525, 0x206F85B3, 0xB966D409, 0xCE61E49F,
                0x5EDEF90E, 0x29D9C998, 0xB0D09822, 0xC7D7A8B4, 0x59B33D17, 0x2EB40D81,
                0xB7BD5C3B, 0xC0BA6CAD, 0xEDB88320, 0x9ABFB3B6, 0x03B6E20C, 0x74B1D29A,
                0xEAD54739, 0x9DD277AF, 0x04DB2615, 0x73DC1683, 0xE3630B12, 0x94643B84,
                0x0D6D6A3E, 0x7A6A5AA8, 0xE40ECF0B, 0x9309FF9D, 0x0A00AE27, 0x7D079EB1,
                0xF00F9344, 0x8708A3D2, 0x1E01F268, 0x6906C2FE, 0xF762575D, 0x806567CB,
                0x196C3671, 0x6E6B06E7, 0xFED41B76, 0x89D32BE0, 0x10DA7A5A, 0x67DD4ACC,
                0xF9B9DF6F, 0x8EBEEFF9, 0x17B7BE43, 0x60B08ED5, 0xD6D6A3E8, 0xA1D1937E,
                0x38D8C2C4, 0x4FDFF252, 0xD1BB67F1, 0xA6BC5767, 0x3FB506DD, 0x48B2364B,
                0xD80D2BDA, 0xAF0A1B4C, 0x36034AF6, 0x41047A60, 0xDF60EFC3, 0xA867DF55,
                0x316E8EEF, 0x4669BE79, 0xCB61B38C, 0xBC66831A, 0x256FD2A0, 0x5268E236,
                0xCC0C7795, 0xBB0B4703, 0x220216B9, 0x5505262F, 0xC5BA3BBE, 0xB2BD0B28,
                0x2BB45A92, 0x5CB36A04, 0xC2D7FFA7, 0xB5D0CF31, 0x2CD99E8B, 0x5BDEAE1D,
                0x9B64C2B0, 0xEC63F226, 0x756AA39C, 0x026D930A, 0x9C0906A9, 0xEB0E363F,
                0x72076785, 0x05005713, 0x95BF4A82, 0xE2B87A14, 0x7BB12BAE, 0x0CB61B38,
                0x92D28E9B, 0xE5D5BE0D, 0x7CDCEFB7, 0x0BDBDF21, 0x86D3D2D4, 0xF1D4E242,
                0x68DDB3F8, 0x1FDA836E, 0x81BE16CD, 0xF6B9265B, 0x6FB077E1, 0x18B74777,
                0x88085AE6, 0xFF0F6A70, 0x66063BCA, 0x11010B5C, 0x8F659EFF, 0xF862AE69,
                0x616BFFD3, 0x166CCF45, 0xA00AE278, 0xD70DD2EE, 0x4E048354, 0x3903B3C2,
                0xA7672661, 0xD06016F7, 0x4969474D, 0x3E6E77DB, 0xAED16A4A, 0xD9D65ADC,
                0x40DF0B66, 0x37D83BF0, 0xA9BCAE53, 0xDEBB9EC5, 0x47B2CF7F, 0x30B5FFE9,
                0xBDBDF21C, 0xCABAC28A, 0x53B39330, 0x24B4A3A6, 0xBAD03605, 0xCDD70693,
                0x54DE5729, 0x23D967BF, 0xB3667A2E, 0xC4614AB8, 0x5D681B02, 0x2A6F2B94,
                0xB40BBE37, 0xC30C8EA1, 0x5A05DF1B, 0x2D02EF8D
        };
            unchecked
            {
                uint crc = (uint)(((uint)0) ^ (-1));
                for (var i = 0; i < value.Length; i++)
                {
                    crc = (crc >> 8) ^ table[(crc ^ (byte)value[i]) & 0xFF];
                }
                crc = (uint)(crc ^ (-1));

                if (crc < 0)
                {
                    crc += (uint)4294967296;
                }
                return crc.ToString("X4");
            }
        }
    }

    static class SHA1
    {
        public static string Hash(string value)
        {
            var res = new StringBuilder();
            foreach (var t in new SHA1CryptoServiceProvider().ComputeHash(new UTF8Encoding().GetBytes(value)))
            {
                res.Append(t.ToString("X2"));
            }
            return res.ToString();

        }
    }

    static class SHA256
    {
        public static string Hash(string value)
        {
            var res = new StringBuilder();
            foreach (var t in new SHA256CryptoServiceProvider().ComputeHash(new UTF8Encoding().GetBytes(value)))
            {
                res.Append(t.ToString("X2"));
            }
            return res.ToString();

        }
    }

    static class SHA384
    {
        public static string Hash(string value)
        {
            var res = new StringBuilder();
            foreach (var t in new SHA384CryptoServiceProvider().ComputeHash(new UTF8Encoding().GetBytes(value)))
            {
                res.Append(t.ToString("X2"));
            }
            return res.ToString();

        }
    }

    static class SHA512
    {
        public static string Hash(string value)
        {
            var res = new StringBuilder();
            foreach (var t in new SHA512CryptoServiceProvider().ComputeHash(new UTF8Encoding().GetBytes(value)))
            {
                res.Append(t.ToString("X2"));
            }
            return res.ToString();

        }
    }
}
  