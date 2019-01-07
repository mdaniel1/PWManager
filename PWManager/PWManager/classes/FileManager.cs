using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace PWManager.classes
{
    public class FileManager
    {
        //Miscellanous variables
        private string Path { get; set; }
        private List<Domain> DomainList { get; set; }

        //AES variables
        private static int _keySize = 256;
        private static int _blocSize = 128;
        byte[] saltBytes = new byte[] { 42, 69, 255, 13, 37, 4, 20, 128 };

        public FileManager(BindingList<Domain> list, string Path)
        {
            this.Path = Path;
            InitializeDirectory();
            DomainList = list.ToList();
        }

        private void InitializeDirectory()
        {
            try
            {
                DirectoryInfo dinfo = new DirectoryInfo(Path);
                Directory.CreateDirectory(Path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur : {0}", e.Message);
            }

        }

        private byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = _keySize;
                    AES.BlockSize = _blocSize;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        //This is the method to call to encrypt
        private string EncryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }

        //DECRYPT
        private byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        //This is the method to call to decrypt
        private string DecryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }

        public Boolean WriteDomains()
        {
            BinaryWriter bw = null ;
            string FilePath = Path + "\\Domains"; //No need to encrypt this

            try
            {
                bw = new BinaryWriter(new FileStream(FilePath, FileMode.Create));
                string WriteFile = "";

                foreach (Domain d in DomainList)
                {
                    WriteFile += d.Name + "\n";
                    
                }
                WriteFile = WriteFile.Remove(WriteFile.Length - 1);
                bw.Write(WriteFile);
                bw.Flush();
                bw.Close();

                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Erreur lors de l'enregistrement du fichier Domains\n\n" + e.Message);
                if(bw != null)
                {
                    bw.Close();
                }
            }

            return false;
        }

        public BindingList<Domain> ReadDomains()
        {
            BinaryReader br = null;
            string FilePath = Path + "\\Domains";
            string file;
            DomainList.Clear();

            try
            {
                br = new BinaryReader(new FileStream(FilePath, FileMode.Open));

                file = br.ReadString();

                string[] domains = file.Split('\n');

                foreach(string s in domains)
                {
                    Domain d = new Domain(s);
                    ReadPasswords(d);
                    DomainList.Add(d);
                }

                br.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erreur lors de la lecture du fichier Domains\n\n" + e.Message);
                if (br != null)
                {
                    br.Close();
                }
            }

            return new BindingList<Domain>(DomainList);
        }

        public Boolean WriteAccounts()
        {
            foreach(Domain d in DomainList)
            {
                if (!WriteAccountsByDomain(d))
                    return false;
            }

            return true;
        }

        private Boolean WriteAccountsByDomain(Domain d)
        {
            BinaryWriter bw = null;
            string WriteFile = "";
            string FilePath = Path + "\\" + d.Name + ".domain";

            try
            {
                if(d.ListAccount.Count > 0)
                {
                    bw = new BinaryWriter(new FileStream(FilePath, FileMode.Create));
                    foreach (string s in d.ListAccount)
                    {
                        string encryptedAccount = EncryptText(s, "BXGEDLbNaX");
                        WriteFile += encryptedAccount + "#";
                    }

                    WriteFile = WriteFile.Remove(WriteFile.Length - 1); //Manually remove the last '#'
                    bw.Write(WriteFile);
                    bw.Flush();
                    bw.Close();
                }

                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Erreur lors de l'enregistrement des comptes\n\n" + e.Message);
                if (bw != null)
                {
                    bw.Close();
                }
            }

            return false;
        }

        public void ReadPasswords(Domain d)
        {
            string FilePath = Path + "\\" + d.Name + ".domain";
            BinaryReader br = null;
            try
            {
                br = new BinaryReader(new FileStream(FilePath, FileMode.Open));
                string File = "";

                File = br.ReadString();

                string[] AllAccounts = File.Split('#');

                foreach(string s in AllAccounts)
                {
                    string DecryptedAccount = DecryptText(s, "BXGEDLbNaX");
                    d.ListAccount.Add(DecryptedAccount);
                }

                br.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Erreur lors de la lecture du fichier " + d.Name + "\n\n" + e.Message);
                if (br != null)
                {
                    br.Close();
                }
            }
        }
    }
}
