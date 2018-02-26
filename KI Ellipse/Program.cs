using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.EC;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Ki_Ellipse.KeyClass;

namespace KI_Ellipse
{
    class Program
    {
        static int Main(string[] args)
        {
            //[operation] [params]
            //possible operations:
            // --create, --encrypt, --decrypt, --sign
            string operation = args[0];

            switch (operation)
            {
                case "--create":
                    Create(args);
                    break;
                case "--encrypt":
                    Encrypt(args);
                    break;
                case "--decrypt":
                    Decrypt(args);
                    break;
                default:
                    Console.WriteLine("No command supplied.");
                    break;
            }

            return 0;
        }

        private static void Decrypt(string[] args)
        {
            throw new NotImplementedException();
        }

        private static void Encrypt(string[] args)
        {
            throw new NotImplementedException();
        }

        private static void Create(string[] args)
        {
            
        }
    }
}
