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
        string fileName = "";
        int ctk = 0;
        public Form1() {
            InitializeComponent();
            initbutton();
        }

        //新規作成//新規作成
        private void NewToolStripMenuItem_Click(object sender, EventArgs e) {
            rtbTextArea.Text = "";
            fileName = "";
            initbutton();
            
        }
        //アプリ終了
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ctk > 0) {
                DialogResult result = MessageBox.Show("保存する？", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Yes) {
                    if (fileName == "") {
                        NameSaveToolStripMenuItem_Click(sender, e);
                    } else {
                        updateSave保存ToolStripMenuItem_Click(sender, e);
                    }
                } else if (result == DialogResult.No) {
                    Application.Exit();
                }

            } else {
                Application.Exit();
                
            }
            
        }
        //[開く]ダイアログを表示
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ctk > 0) {
                DialogResult result = MessageBox.Show("保存する？", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Yes) {
                    if (fileName == "") {
                        NameSaveToolStripMenuItem_Click(sender, e);
                    } else {
                        updateSave保存ToolStripMenuItem_Click(sender, e);
                    }
                } else if (result == DialogResult.No) {
                    if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                        rtbTextArea.LoadFile(@ofdFileOpen.FileName, RichTextBoxStreamType.RichText);
                        fileName = ofdFileOpen.FileName;
                    }
                }
            }

            
            initbutton();

        }
        //[名前を付けて保存]ダイアログを表示
        private void NameSaveToolStripMenuItem_Click(object sender, EventArgs e) {
            if(sfdFileSave.ShowDialog() == DialogResult.OK) {
                rtbTextArea.SaveFile(@sfdFileSave.FileName,RichTextBoxStreamType.RichText);
                    fileName = sfdFileSave.FileName;
                
                   
            }
            initbutton();
            ctk = 0;
        }      
        //上書き保存
        private void updateSave保存ToolStripMenuItem_Click(object sender, EventArgs e) {

            if (fileName == "") {
                NameSaveToolStripMenuItem_Click(sender, e);
                } else {
                    using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("utf-8"))) {
                        sw.WriteLine(rtbTextArea.Text);
                    }
                }
            initbutton();
            ctk = 0;
            }
        //元に戻す
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e) {
            
            rtbTextArea.Undo();
            rtbTextArea.ClearUndo();
            
        }
        //やり直し
        private void RedoRToolStripMenuItem_Click(object sender, EventArgs e) {
            
            rtbTextArea.Redo();
            rtbTextArea.ClearUndo();
            
        }
        //切り取り
        private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
            if (rtbTextArea.SelectedText != "") {
                rtbTextArea.Cut();
            }
            
        }
        //コピー
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
            if (rtbTextArea.SelectedText != "") {
                rtbTextArea.Copy();
            }
            
        }
        //削除
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) {
            rtbTextArea.Cut();
            Clipboard.Clear();
            
        }
        //色変更
        private void ColorToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cldColor.ShowDialog() == DialogResult.OK) {
                rtbTextArea.SelectionColor= cldColor.Color;
            }
            
        }
        //フォント変更
        private void FontToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ftdFont.ShowDialog() == DialogResult.OK) {
                rtbTextArea.SelectionFont = ftdFont.Font;
            }
            
        }
        //貼り付け
        private void PestToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                rtbTextArea.Paste();
            
        }
        //機能のマスク化
        void initbutton() {
            if (fileName == "") {
                updateSave保存ToolStripMenuItem.Enabled = false;
            } else {
                updateSave保存ToolStripMenuItem.Enabled = true;
            }   
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
            if (rtbTextArea.CanUndo) {
                UndoToolStripMenuItem.Enabled = true;
            } else {
                UndoToolStripMenuItem.Enabled = false;
            }
            if (rtbTextArea.CanRedo) {
                RedoRToolStripMenuItem.Enabled = true;
            } else {
                RedoRToolStripMenuItem.Enabled = false;
            }
            if (rtbTextArea.Text == "") {
                CutToolStripMenuItem.Enabled = false;
                CopyToolStripMenuItem.Enabled = false;

            } else {
                CutToolStripMenuItem.Enabled = true;
                CopyToolStripMenuItem.Enabled = true;
            }
            
        }
        void error() {
            if (fileName == "" || ctk > 0) {
                MessageBox.Show("保存する？","警告",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
            }
        }

        private void rtbTextArea_KeyUp(object sender, KeyEventArgs e) {
            ctk = 1;
        }
    }
}

