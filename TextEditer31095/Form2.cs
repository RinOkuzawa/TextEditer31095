using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditer31095 {
    public partial class VersionForm : Form {
        private static VersionForm _singInstance;

        public static VersionForm GetInstance() {
            if (_singInstance == null) {
                _singInstance = new VersionForm();
            }
            return _singInstance; //自分自身のオブジェクトを探す
        }

        private VersionForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void VersionForm_FormClosed(object sender, FormClosedEventArgs e) {
            _singInstance = null;
        }
    }
}
