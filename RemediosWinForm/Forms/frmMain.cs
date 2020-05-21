using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Remedios;

namespace RemediosWinForm {
    public partial class frmMain : Form {
        private int childFormNumber = 0;

        public frmMain() {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e) {
            Controls.OfType<MdiClient>().First().BackColor = this.BackColor;
        }

        #region JANELAS -----------------------------
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }
        #endregion JANELAS --------------------------

        #region CADASTRO ----------------------------
        private void remediosToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmRemedios() {MdiParent = this };
            frm.Show();
        }
        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmReport() { MdiParent = this };
            frm.Show();
        }

        #endregion CADASTRO ----------------------------

        #region PESQUISA  ------------------------------
        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmPesquisa() { MdiParent = this };
            frm.Show();
        }

        private void comparaçãoToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmComparacao() { MdiParent = this };
            frm.Show();
        }
        #endregion PESQUISA  ------------------------------

        private void anvisaToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmAnvisa() { MdiParent = this };
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmProdutos() { MdiParent = this };
            frm.Show();
        }

        private void princípiosToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmPrincipios() { MdiParent = this };
            frm.Show();
        }
    }
}
