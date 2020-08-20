using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditer31095 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //アプリ終了
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        //[開く]ダイアログを表示
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {


            if(ofdFileOpen.ShowDialog() == DialogResult.OK) {
                using (StreamReader sr = new StreamReader(ofdFileOpen.FileName,Encoding.GetEncoding("utf-8"),false)) {
                    rtbTextArea.Text = sr.ReadToEnd();
                   
                    //string line
                    //while ((line = sr.ReadLine()) != null) {
                    //    rtbTextArea.Text = line;
                    //}
                    
                }
            
            
            }
        }
        //[名前を付けて保存]ダイアログを表示
        private void NameSaveToolStripMenuItem_Click(object sender, EventArgs e) {
            if(sfdFileSave.ShowDialog() == DialogResult.OK) {
                using (StreamWriter sw = new StreamWriter(sfdFileSave.FileName, false,Encoding.GetEncoding("utf-8"))) {
                    sw.WriteLine(rtbTextArea.Text);
                }
                   
            }
        }
    }
}
