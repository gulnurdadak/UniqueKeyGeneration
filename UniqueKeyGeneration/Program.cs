using System;
using System.Security.Cryptography;

namespace UniqueKeyGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            //5000 kod üretelim.
            const int codeCount = 5000;
            const int codeLength = 8;

            //her iterasyonda bir benzersiz kod üretilir.
            for (int i = 0; i < codeCount; i++)
            {
                string generatedCode = GenerateUniqueCode(codeLength);
                Console.WriteLine(generatedCode);

                //Ekranda görüntülenecek kodları tek tek üretmek için kullanabiliriz.
                //Console.ReadKey();
            }

        }

        static string GenerateUniqueCode(int codeLength)
        {
            const string characters = "ACDEFGHKLMNPRTXYZ234579";

            //kriptografik olarak güvenli rastgele sayılar oluşturan RNGCryptoServiceProvider nesnesi başlatılır.
            using (var provider = new RNGCryptoServiceProvider())
            {
                //codeLength uzunluğunda bir dizi oluşturulur, ve her bir eleman başlangıçta boş bir karakterle ('\0') atanır.
                char[] code = new char[codeLength];

                //her bir iterasyonda bir karakter üretilir.
                for (int i = 0; i < codeLength; i++)
                {
                    //Kriptografik güvenilirliği sağlamak için 1 bytelık bir dizi oluşturulur.
                    byte[] byteArray = new byte[1];
                    //bu diziye rastgele bir byte eklenir.
                    provider.GetBytes(byteArray);
                    //dizinin ilk elemanına yerleştirilir.
                    byte randomByte = byteArray[0];

                    //Karakter kümesinden rastgele bir karakter seçilir ve oluşturulan kod dizisine eklenir.
                    code[i] = characters[randomByte % characters.Length];
                }

                return new string(code);
            }
        }
    }
}
