using System;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        private CaesarCipher caesarCipher = null;

        public Form1()
        {
            InitializeComponent();
            caesarCipher = new CaesarCipher(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCipher.Text = caesarCipher.Encrypt(txtPlain.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPlain.Text = caesarCipher.Decrypt(txtCipher.Text);
        }
    }
}
