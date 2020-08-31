namespace TextEditer31095 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSave保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字コードCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            this.rtbTextArea = new System.Windows.Forms.RichTextBox();
            this.cldColor = new System.Windows.Forms.ColorDialog();
            this.ftdFont = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.文字コードCToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.updateSave保存ToolStripMenuItem,
            this.NameSaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.FileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.NewToolStripMenuItem.Text = "新規作成(&N)";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.OpenToolStripMenuItem.Text = "開く(&O)...";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // updateSave保存ToolStripMenuItem
            // 
            this.updateSave保存ToolStripMenuItem.Name = "updateSave保存ToolStripMenuItem";
            this.updateSave保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.updateSave保存ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.updateSave保存ToolStripMenuItem.Text = "上書き保存(&S)";
            this.updateSave保存ToolStripMenuItem.Click += new System.EventHandler(this.updateSave保存ToolStripMenuItem_Click);
            // 
            // NameSaveToolStripMenuItem
            // 
            this.NameSaveToolStripMenuItem.Name = "NameSaveToolStripMenuItem";
            this.NameSaveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.NameSaveToolStripMenuItem.Text = "名前を付けて保存(&A)...";
            this.NameSaveToolStripMenuItem.Click += new System.EventHandler(this.NameSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ExitToolStripMenuItem.Text = "終了(&X)";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.RedoRToolStripMenuItem,
            this.toolStripSeparator2,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PestToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.toolStripSeparator3,
            this.ColorToolStripMenuItem,
            this.FontToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.EditToolStripMenuItem.Text = "編集(&E)";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.UndoToolStripMenuItem.Text = "元に戻す(&U)";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoRToolStripMenuItem
            // 
            this.RedoRToolStripMenuItem.Name = "RedoRToolStripMenuItem";
            this.RedoRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoRToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.RedoRToolStripMenuItem.Text = "やり直し(&R)";
            this.RedoRToolStripMenuItem.Click += new System.EventHandler(this.RedoRToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.CutToolStripMenuItem.Text = "切り取り(&T)";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.CopyToolStripMenuItem.Text = "コピー(&C)";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PestToolStripMenuItem
            // 
            this.PestToolStripMenuItem.Name = "PestToolStripMenuItem";
            this.PestToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PestToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.PestToolStripMenuItem.Text = "貼り付け(&P)";
            this.PestToolStripMenuItem.Click += new System.EventHandler(this.PestToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.DeleteToolStripMenuItem.Text = "削除(&D)";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ColorToolStripMenuItem.Text = "色...";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.FontToolStripMenuItem.Text = "フォント...";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // 文字コードCToolStripMenuItem
            // 
            this.文字コードCToolStripMenuItem.Name = "文字コードCToolStripMenuItem";
            this.文字コードCToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.文字コードCToolStripMenuItem.Text = "文字コード(&C)";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // VersionToolStripMenuItem
            // 
            this.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem";
            this.VersionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.VersionToolStripMenuItem.Text = "バージョン情報...";
            this.VersionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.DefaultExt = "rtf";
            this.ofdFileOpen.FileName = "openFileDialog1";
            this.ofdFileOpen.Filter = "ファイル|*.rtf|すべてのファイル|*.*";
            // 
            // sfdFileSave
            // 
            this.sfdFileSave.DefaultExt = "rtf";
            this.sfdFileSave.Filter = "ファイル|*.rtf|すべてのファイル|*.*";
            // 
            // rtbTextArea
            // 
            this.rtbTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTextArea.EnableAutoDragDrop = true;
            this.rtbTextArea.Location = new System.Drawing.Point(0, 24);
            this.rtbTextArea.Name = "rtbTextArea";
            this.rtbTextArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rtbTextArea.Size = new System.Drawing.Size(896, 553);
            this.rtbTextArea.TabIndex = 1;
            this.rtbTextArea.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 577);
            this.Controls.Add(this.rtbTextArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "テキストエディタ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSave保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NameSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文字コードCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
        private System.Windows.Forms.RichTextBox rtbTextArea;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cldColor;
        private System.Windows.Forms.FontDialog ftdFont;
        private System.Windows.Forms.ToolStripMenuItem VersionToolStripMenuItem;
    }
}

