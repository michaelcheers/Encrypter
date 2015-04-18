using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.IO;

namespace Enc_Library
{
    public class Encryption
    {
        BigInteger encryption;
        
        public byte[] ToBytes ()
        {
            return encryption.ToByteArray();
        }

        public Encryption (BigInteger encryption)
        {
            this.encryption = encryption;
        }
    }
    public class Encrypter
    {
        BigInteger password;

        public Encrypter(BigInteger password)
        {
            this.password = password;
        }

        public Encrypter(string password)
        {
            this.password = new BigInteger(System.Text.ASCIIEncoding.Default.GetBytes(password));
        }

        public Encrypter(string password, Encoding enc)
        {
            this.password = new BigInteger(enc.GetBytes(password));
        }

        public Encryption Encrypt(byte[] encrypt)
        {
            return Encrypt(new BigInteger(encrypt));
        }

        public Encryption Encrypt(BigInteger encrypt)
        {
            return new Encryption(encrypt * password);
        }

        public Encryption Encrypt(string encrypt, Encoding encoding)
        {
            return Encrypt(encoding.GetBytes(encrypt));
        }

        public Encryption Encrypt(string encrypt)
        {
            return Encrypt(encrypt, System.Text.ASCIIEncoding.Default);
        }

        public Encryption Encrpyt(Stream encrypt, byte[] buffer, int index, int count)
        {
            encrypt.Read(buffer, index, count);
            return Encrypt(buffer);
        }
    }
}
