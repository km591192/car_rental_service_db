using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Carrent
{
    class FS
    {
        Crypto crypto = new Crypto();

        public void allwriteq(string str)
        {
            File.AppendAllText("allquery", str);
            File.AppendAllText("allquery", "\n");
        }

        public void writequery (string query)
        {
           /* FileStream infile = new FileStream("query", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sinfile = new StreamWriter(infile);
            sinfile.Write(query);
            sinfile.Dispose();
            sinfile.Close();
            infile.Dispose();
            infile.Close();*/
            File.WriteAllText("query", query);
        }
        public void writenum(string id)
        {
            File.WriteAllText("num", id);
        }
        public void writeclient(string str)
        {
            File.Decrypt("passc");
            File.AppendAllText("passc",str);
            File.Encrypt("passc");
        }
        public void writepo(string str)
        {
            File.Decrypt("passpo");
            File.AppendAllText("passpo", str);
            File.Encrypt("passpo");
        }

        public bool checkpasswdfromfile(string filename, MaskedTextBox mtb, TextBox ptb)
        {
             int flag = 0;
             File.Decrypt(filename);
            using (StreamReader sr = new StreamReader(filename))
            {
                string line, strph = mtb.Text, strpas = ptb.Text;
               // string hash = crypto.getMd5Hash(strpas);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string g = line.Substring(0, 13);
                    string d = line.Substring(14);
                    if (crypto.verifyMd5Hash(strpas, d) && (g == strph))
                    {
                        //MessageBox.Show("The password is correct.");
                        flag = 1;
                        writenum(sr.ReadLine());
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }

                   /* if (g == strph && d == strpas)
                    {
                        flag = 1;
                        writenum(sr.ReadLine());
                    }
                    else line = sr.ReadLine();*/
                }
                sr.Close();
            }
            File.Encrypt(filename);
            if (flag == 1) return true;
            else return false;
        }
    }
}
