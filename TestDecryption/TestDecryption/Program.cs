using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CryptoHelper.Decrypt("SjkASatNt8xuqheOxKPZQ55ygps4Miy1p0uvpcT/xSe1bEzvaYMd571Kzks+4pkEEwXt5qcHwJkqiQFHcf+6sg==", "!@#"));
            Console.Read();
        }
    }
}
