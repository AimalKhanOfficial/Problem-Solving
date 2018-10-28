using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSAConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public byte[] Decrypt(byte[] bytes)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(PrivateParameters);

                // Correct the error in the JS encryptor.
                if (bytes.Length < rsa.KeySize / 8)
                {
                    byte[] tmp = new byte[rsa.KeySize / 8];
                    Buffer.BlockCopy(bytes, 0, tmp, tmp.Length - bytes.Length, bytes.Length);
                    bytes = tmp;
                }

                return rsa.Decrypt(bytes, RSAEncryptionPadding.Pkcs1);
            }
        }


    }
}
