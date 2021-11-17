using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Openssl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            output.SelectionFont = new Font("Microsoft Sans Serif", 8);
            key.Text = "crypto1234crypto";
            vector.Text = "thermoAAAAthermo";
            input.Text = "7IwDEpdhsP41iKPnRGEWe1HUMASC3nPY8OGvfwCBmeG1rK2drdhEQG1nK0B" +
                "HcQVXXpQZ/iICZ51My1tvB6BEcEewJaArY1K2eVsS1KwIdap9YZrPlKRKZloW/jjgJTGD" +
                "5v3FPANDlXygiMSWdtLNTDwm1pQ9an3ko3q21p2PSAD3B2f/++KfYhjxcoAjqFMhsbINh" +
                "pbLtmTMjFQgB45T+62VnSE1yYprP/1iFd7ejfUg+wtZzkT+Dxl1joL198x+QmLHzSxh2Z" +
                "iXlA1kwJcyjoQwZVIKAUC47H1nvR2ZZN0tPhA5LwU0YxQENHcN/3aERi7ayFRmHweCE9Y" +
                "WIALeHjTGg80MOzo+6+vM7jgYWjilBGBpT/KNRgBldX0XYy31e3nA8lHNmgN/D23zbTV1" +
                "TF1oV2L0FL1FpjmfDJtNbVuheZJ2MlnnhcP/BlO2rwrmGjrC9j7m/g8LZZh7PaBjiYPjL" +
                "Ou3Ji0rQtu3FuJM3Z8/XvLYLUYKn2rJLuCg2/KAJr+YmMzlg15cpnul7MKfaomHT9salC" +
                "dKgra29Tu+BDDFTJ+wWyUjXwXqZzIqpZQG2Bks9UTITq5ng/IFmrmTzH1M8EIOAKPGSMR" +
                "XpqkAZPhaIRWZAdYvYeflp57dnWjKMimRmENvn7BQjDAyGdB9G6wJIT5nTft6aebmPhY3" +
                "J5nIgFxeV7Eo2Am3jGtvc8L0o/1Qcpdxu7N5itPwFSdrks1q7YnMBkADlAGLxROt00H2t" +
                "jQID7D9cLG1PkE3JOiVD9rhrkYbZutKAZ9C7sMw6IUZCarcSjT5gTUms1/IFJ3VCMlU31" +
                "eC739tzpVQRm8eom3ppW8F4pbUAJ3wdcLOPKtWvn/3781ezgYDmEDPSrXMTzOOvY4Hz+Y" +
                "ZfcavsKoeq6SNzztdwBHR00mF7kA7pThSyYzGZqHK0yAB9kDcDQTm0MyOPDxSHyv2M8iJ" +
                "+abnA5RrBgfqBeOJjJL6bP0jZZG5qfxEzA7bNhTri1W/oU3gH1lCGvrrrUIeiDKbfli2V" +
                "g7OR+7oC964gCRDjhP9iu/cB3TAOTesIVsnqmuhvsrF2F7cG660Vv3tVmO2YjIEPcMjPM" +
                "qvXYk2x5GLfvZIwerLrMJrcimOciDLTLJaiyrkIkJTgOcliAizQU7KK8g3ruXige7CFFx" +
                "3egPPn1AodHOCzxhSIKmBk4B9wXDGzJuzpV7NxNEU8jfYP3EEkI5qcjrsdkMxJ/xZIRbk" +
                "YwulAqdED4vbEfq/zg13LQB6jkWmTo1S//+AMvilhv/WgIaqtLttz6cAlooDgMLlSYT6H" +
                "GGkBSNA639vQFlfONoy4DDl7xz7f7a8qpPMR2A2TGOz8wI/nZ17/ZatzwRnudD8dlikwy" +
                "yQNZIdAosLNfC+nj74wUCaoIdiDiFjDoph7ADAxR/t4+jgIhqh7Q1nod9nKqHctrbYNQN" +
                "zDRAIn9WXtVsg1zYiMYuH7/aTo+wl/7pXBz8UWDP9tqtjvUJZwQ0rvwbWfTU8aA==";
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            Chilkat.Crypt2 encrypt = new Chilkat.Crypt2();
            encrypt.CryptAlgorithm = "aes";
            encrypt.CipherMode = "ctr";
            encrypt.KeyLength = 128;
            encrypt.EncodingMode = "base64";
            encrypt.SetEncodedIV(vector.Text, "ascii");
            encrypt.SetEncodedKey(key.Text, "ascii");
            output.Text = encrypt.EncryptStringENC(input.Text);
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            Chilkat.Crypt2 decrypt = new Chilkat.Crypt2();
            decrypt.CryptAlgorithm = "aes";
            decrypt.CipherMode = "ctr";
            decrypt.KeyLength = 128;
            decrypt.EncodingMode = "base64";
            decrypt.SetEncodedIV(vector.Text, "ascii");
            decrypt.SetEncodedKey(key.Text, "ascii");
            output.Text = decrypt.DecryptStringENC(input.Text);
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            if (vector.Text.ToCharArray().Length != 16 || key.Text.ToCharArray().Length != 16)
            { encrypt.Enabled = false; decrypt.Enabled = false; }
            else
            { encrypt.Enabled = true; decrypt.Enabled = true; }
        }

        private void vector_TextChanged(object sender, EventArgs e)
        {
            if (vector.Text.ToCharArray().Length != 16 || key.Text.ToCharArray().Length != 16)
            { encrypt.Enabled = false; decrypt.Enabled = false; }
            else
            { encrypt.Enabled = true; decrypt.Enabled = true; }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            input.Font = new Font("Microsoft Sans Serif", 8);
        }
    }
}
