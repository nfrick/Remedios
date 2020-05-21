using DataLayer;
using System;
using System.Windows.Forms;

namespace RemediosWinForm {
    public partial class frmBula : Form {
        public Remedio remedio { get; set; }
        public frmBula() {
            InitializeComponent();
        }

        private void frmBula_Load(object sender, EventArgs e) {
            Text = $"{remedio.Nome} - Bula";
            richTextBoxBula.Text = remedio.Bula;
        }
    }
}
