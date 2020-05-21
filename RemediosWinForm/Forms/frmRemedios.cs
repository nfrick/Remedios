using DataLayer;
using DbContextExtensions;
using SuperGrid;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RemediosWinForm {
    public partial class frmRemedios : Form {
        private readonly RemediosEntities _ctx = new RemediosEntities();

        public frmRemedios() {
            InitializeComponent();
            _ctx.Remedios.Load();
            remedioBindingSource.DataSource = _ctx.Remedios.Local.ToBindingList();
        }

        private void frmRemedios_Load(object sender, System.EventArgs e) {
            dgvRemedios.Sort(dgvRemedios.Columns[0], ListSortDirection.Ascending);
        }

        private void frmRemedios_FormClosing(object sender, FormClosingEventArgs e) {
            if (!_ctx.ChangeTracker.HasChanges()) {
                return;
            }
            switch (MessageBox.Show(_ctx.TextoSalvar(), "Remédios",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                case DialogResult.Yes:
                    e.Cancel = !SalvarAlteracoes();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void remedioBindingSource_AddingNew(object sender, AddingNewEventArgs e) {
            nomeTextBox.Focus();
        }

        private void remedioBindingNavigatorSaveItem_Click(object sender, System.EventArgs e) {
            var row = dgvRemedios.CurrentRow.Index;
            row = row + (row == 0 ? 1 : -1);
            dgvRemedios.CurrentCell = dgvRemedios.Rows[row].Cells[0];
            dgvRemedios.Rows[row].Selected = true;
            if (!SalvarAlteracoes()) {
                return;
            }

            var col = dgvRemedios.SortedColumn.Index;
            var order = dgvRemedios.SortOrder;
            dgvRemedios.Sort(dgvRemedios.Columns[col],
                order == SortOrder.Ascending ?
                    ListSortDirection.Ascending :
                    ListSortDirection.Descending);
        }

        private bool SalvarAlteracoes() {
            var result = _ctx.SaveChanges(out var message);
            if (!result) {
                MessageBox.Show(message, "Erros de Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        private void TextBoxNome_Validating(object sender, CancelEventArgs e) {
            TextBox_Validating(sender, e);
            var atual = (Remedio)remedioBindingSource.Current;
            var alvo = _ctx.Remedios.Local.FirstOrDefault(r => r.Nome == nomeTextBox.Text);
            e.Cancel = alvo != null && alvo.ID != atual.ID;
            errorProvider1.SetError(nomeTextBox,
                e.Cancel ? $"{nomeTextBox.Text} já foi cadastrado." : "");
        }

        private void TextBox_Validating(object sender, CancelEventArgs e) {
            var txt = (TextBox)sender;
            txt.Text = txt.Text.Trim();
        }

        private void DGV_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var dgv = (SuperDGV)sender;
            var cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value == null) {
                return;
            }

            cell.Value = ((string)cell.Value).Trim().ToLower();
        }

        private void remedioBindingNavigatorRevert_Click(object sender, System.EventArgs e) {
            _ctx.RevertChanges();
            dgvRemedios.Refresh();
            dgvPrincipios.Refresh();
        }

        private void remedioBindingSource_CurrentItemChanged(object sender, System.EventArgs e) {
            remedioBindingNavigatorSaveItem.Text = $"{_ctx.ChangesCount()} alterações"; ;
        }

        private void unidadeTextBox_DoubleClick(object sender, System.EventArgs e) {
            unidadeTextBox.Text = $"{apresentacaoTextBox.Text}s";
        }

        private void linkLabel1_Click(object sender, System.EventArgs e) {
            System.Diagnostics.Process.Start(linkTextBox.Text);
        }
    }
}
