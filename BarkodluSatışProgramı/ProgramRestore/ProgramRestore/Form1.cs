using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramRestore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bYedekSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Veri dosyasını seçiniz |*.bak"; //veri dosyası seçtirme |*.bak sadece bakları seçer 
            ofd.ShowDialog();
            tDosya.Text = ofd.FileName;
        }

        private void bYukle_Click(object sender, EventArgs e)
        {
            if (tDosya.Text != "")
            {
                try
                {
                    string strSql = @"data source=(LocalDB)\MSSQLLocalDb;attachdbfilename=|DataDirectory|\BarkodDb.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                    Cursor.Current = Cursors.WaitCursor;
                    string yedekyolu = tDosya.Text;
                    Application.DoEvents();
                    string str = Application.StartupPath + @"\BarkodDb.mdf";
                    using (SqlConnection connection = new SqlConnection(strSql))
                    {
                        connection.Open();
                        SqlCommand isle = new SqlCommand(@"USE Master; If Exists(Select * From sys.databases where name= 'BarkodDb') Drop DataBase[" + str + "];RESTORE DATABASE[" + str + "] FROM DISK=N'" + tDosya.Text + "'", connection);
                        isle.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Veriler Yüklenmiştir.");
                    Process.Start(Application.StartupPath + "\\BarkodluSatis.exe");
                    Cursor.Current = Cursors.Default;
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Hata");
                }
            }
        }
    }
}
