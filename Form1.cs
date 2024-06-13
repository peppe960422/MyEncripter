using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace MyEncripter
{
    public partial class MyEncrypter : Form
    {
        int contatore = 0; 
        public MyEncrypter()
        {
            InitializeComponent();
        }

        private void btn_encript_Click(object sender, EventArgs e)
        {
            contatore++;
            string pfad = pfadBox.Text;
            string pfadKey = @"C:\\Users\\giuse\\Desktop\";
            string n = contatore.ToString();
            string Keyfile = ("KEY"+n+".txt") ;
            pfadKey = Path.Combine( pfadKey,Keyfile);
            byte[] key = new byte[32]; // 256 bit key
            byte[] iv = new byte[16];  // 128 bit IV

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(key);
                rng.GetBytes(iv);
            }
            string keyBase64 = Convert.ToBase64String(key);
            string ivBase64 = Convert.ToBase64String(iv);
            File.WriteAllText(pfadKey, $"Key={keyBase64} IV={ivBase64}");

            FileEncryptor encryptor = new FileEncryptor();
            byte[] encryptedData = encryptor.EncryptFile(pfad, key, iv);
            File.WriteAllBytes(pfad, encryptedData);
        }

        private void btn_decript_Click(object sender, EventArgs e)
        {
            string pfad = pfadBox.Text;
            string stringKey = KeyBox.Text;
            string stringIV = IVbox.Text;
            byte[] fileBytes = File.ReadAllBytes(pfad);
            byte[] Key = Convert.FromBase64String(stringKey);
            byte[] iv = Convert.FromBase64String(stringIV);
            FileEncryptor encryptor = new FileEncryptor();
            byte[] decryptedData = encryptor.DecryptFile(fileBytes, Key, iv);
            File.WriteAllBytes(pfad, decryptedData);

        }
    }
    public class FileEncryptor
    {
        public byte[] EncryptFile(string filePath, byte[] key, byte[] iv)
        {
            // Leggi il file in un array di byte
          
            byte[] fileBytes = File.ReadAllBytes(filePath);
           



            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(fileBytes, 0, fileBytes.Length);
                        csEncrypt.FlushFinalBlock();
                    }
                    return msEncrypt.ToArray();
                }
            }
        }
        public byte[] DecryptFile(byte[] encryptedFileBytes, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(encryptedFileBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (MemoryStream msPlain = new MemoryStream())
                        {
                            csDecrypt.CopyTo(msPlain);
                            return msPlain.ToArray();
                        }
                    }
                }
            }
        }
    }

    internal class ReadChuncks
    {

        internal void ReadFile(string filePath)
        {
            const int MAX_BUFFER = 20971520; //20MB this is the chunk size read from file
            byte[] buffer = new byte[MAX_BUFFER];
            int bytesRead;

            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                while ((bytesRead = bs.Read(buffer, 0, MAX_BUFFER)) != 0) //reading only 20mb chunks at a time
                {
                    //buffer contains the chunk data Treasure the moments with it . . . 
                    //modify the buffer size above to change the size of chunk . . .
                }
            }
        }


    }

}


