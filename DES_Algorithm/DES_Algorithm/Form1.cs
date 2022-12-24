using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3Bai2
{
    public partial class Form1 : Form
    {
        public static string outputStr;
        public static string hashStr;
        public static string pathStr;
        public static byte[] text;
        public static byte[] key;
        public static byte[] toEncrypt;
        public static byte[] toDencrypt;
        public static byte[] iv;

        public static string str1;
        public Form1()
        {
            InitializeComponent();
        }


        public static string SHA256(string path)                         //hàm băm SHA256
        {
            try
            {
                using (FileStream stream = File.OpenRead(path))           //tiến hành băm dữ liệu từ đường dẫn
                {
                    SHA256Managed sha = new SHA256Managed();
                    byte[] hash = sha.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", String.Empty);
                }
            }
            catch
            {
                MessageBox.Show("Path file error!");
                return "";
            }
        }



        public static byte[] EncryptTextToMemory(string text, byte[] key, byte[] iv)
        {
            try
            {
                // Create a MemoryStream.
                using (MemoryStream mStream = new MemoryStream())
                {
                    // Create a new DES object.
                    using (DES des = DES.Create())
                    // Create a DES encryptor from the key and IV
                    using (ICryptoTransform encryptor = des.CreateEncryptor(key, iv))
                    // Create a CryptoStream using the MemoryStream and encryptor
                    using (var cStream = new CryptoStream(mStream, encryptor, CryptoStreamMode.Write))
                    {
                        // Convert the provided string to a byte array.
                        byte[] toEncrypt = Encoding.UTF8.GetBytes(text);

                        // Write the byte array to the crypto stream and flush it.
                        cStream.Write(toEncrypt, 0, toEncrypt.Length);

                        // Ending the using statement for the CryptoStream completes the encryption.
                    }

                    // Get an array of bytes from the MemoryStream that holds the encrypted data.
                    byte[] ret = mStream.ToArray();

                    // Return the encrypted buffer.
                    return ret;
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                throw;
            }
        }

        public static string DecryptTextFromMemory(byte[] encrypted, byte[] key, byte[] iv)
        {
            try
            {
                // Create a buffer to hold the decrypted data.
                // DES-encrypted data will always be slightly bigger than the decrypted data.
                byte[] decrypted = new byte[encrypted.Length];
                int offset = 0;

                // Create a new MemoryStream using the provided array of encrypted data.
                using (MemoryStream mStream = new MemoryStream(encrypted))
                {
                    // Create a new DES object.
                    using (DES des = DES.Create())
                    // Create a DES decryptor from the key and IV
                    using (ICryptoTransform decryptor = des.CreateDecryptor(key, iv))
                    // Create a CryptoStream using the MemoryStream and decryptor
                    using (var cStream = new CryptoStream(mStream, decryptor, CryptoStreamMode.Read))
                    {
                        // Keep reading from the CryptoStream until it finishes (returns 0).
                        int read = 1;

                        while (read > 0)
                        {
                            read = cStream.Read(decrypted, offset, decrypted.Length - offset);
                            offset += read;
                        }
                    }
                }

                // Convert the buffer into a string and return it.
                return Encoding.UTF8.GetString(decrypted, 0, offset);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                throw;
            }
        }
    
    private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                txbFile.Text = op.FileName;
                pathStr = op.FileName;
            }
            hashStr = SHA256(pathStr);
    
        }

        private void btnMaHoa_Click_1(object sender, EventArgs e)
        {
            using (DES des = DES.Create())
            {
                key = des.Key;
                iv = des.IV;
            }
            using (DES des = DES.Create())

            toEncrypt = EncryptTextToMemory(hashStr,key,iv);

            
            for (int i = 0; i < toEncrypt.Length; i++)
            {
                str1 += toEncrypt[i];
                str1 += "";
            }
            
            txbOutput.Text = str1;
            
        }

        private void btnGiaiMa_Click_1(object sender, EventArgs e)
        {
            
            using (DES des = DES.Create())

            //text = Encoding.ASCII.GetBytes(txbOutput.Text);
            outputStr = DecryptTextFromMemory(toEncrypt, key, iv);
          
            txbOriginText.Text = outputStr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
