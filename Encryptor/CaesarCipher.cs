using System.Text;

namespace Encryptor
{
    class CaesarCipher
    {
        private const int DEFAULT_DELTA = 2;

        private int delta = 0;

        public CaesarCipher(int delta)
        {
            this.delta = delta;
        }

        private string Process(string src, int delta)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < src.Length; i++)
            {
                sb.Append((char)(src[i] + delta));
            }
            return sb.ToString();
        }

        public string Encrypt(string src)
        {
            return Process(src, delta);
        }

        public string Decrypt(string src)
        {
            return Process(src, -delta);
        }
    }
}
