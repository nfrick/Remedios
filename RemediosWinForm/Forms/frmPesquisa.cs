using DataLayer;
using IEnumerableExtensions;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RemediosWinForm {
    public partial class frmPesquisa : Form {
        private readonly RemediosEntities _ctx = new RemediosEntities();
        public frmPesquisa() {
            InitializeComponent();
            checkedListBoxCategorias.Items.AddRange(_ctx.spCategorias().ToArray());
            checkedListBoxIndicacoes.Items.AddRange(_ctx.spIndicacoes().ToArray());
            checkedListBoxPrincipios.Items
                .AddRange(_ctx.Principios.Select(p => p.Nome)
                .Distinct().OrderBy(p => p).ToArray());

            dgvRemedios.FormatColumn("Nome", null, 200);
            dgvRemedios.FormatColumn("Apresentação", null, 120);
            dgvRemedios.FormatColumn("Estoque", null, 130);
            dgvRemedios.FormatColumn("Link", null, 220);
            dgvRemedios.FormatColumn("Princípios", null, -1);

            labelCategorias.Tag = checkedListBoxCategorias;
            labelIndicacoes.Tag = checkedListBoxIndicacoes;
            labelPrincipios.Tag = checkedListBoxPrincipios;
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            bsRemedios.DataSource = _ctx.spRemedios((int)nupQuantidade.Value,
                checkBoxUsoHumano.Checked, checkBoxUsoVeterinario.Checked,
                CheckedItemsToList(checkedListBoxCategorias),
                CheckedItemsToList(checkedListBoxIndicacoes),
                CheckedItemsToList(checkedListBoxPrincipios))
                .ToObservableListSource().ToBindingList();

            labelResultado.Text = $"{dgvRemedios.RowCount} remédios encontrados";
            splitContainer1.Visible = dgvRemedios.RowCount > 0;
            splitContainer1.SplitterDistance = dgvRemedios.Rows.Cast<DataGridViewRow>()
                .Sum(r => r.Height) + dgvRemedios.ColumnHeadersHeight;
        }

        private static string CheckedItemsToList(CheckedListBox chklstbox) {
            var items = chklstbox.CheckedItems.Cast<string>();
            return items.Any() ? "'" +
                items.Aggregate((accumulator, piece) => accumulator + "','" + piece) + "'" : "";
        }

        private void checkedListBoxCategorias_ItemCheck(object sender, ItemCheckEventArgs e) {
            labelCategorias.Text = SetLabel(sender, e);
        }

        private void checkedListBoxIndicacoes_ItemCheck(object sender, ItemCheckEventArgs e) {
            labelIndicacoes.Text = SetLabel(sender, e);
        }

        private void checkedListBoxPrincipios_ItemCheck(object sender, ItemCheckEventArgs e) {
            labelPrincipios.Text = SetLabel(sender, e);
        }

        private string SetLabel(object sender, ItemCheckEventArgs e) {
            var chk = (CheckedListBox)sender;
            var count = chk.CheckedItems.Count + (e.NewValue == CheckState.Checked ? 1 : -1);
            return (string)chk.Tag + (count == 0 ? string.Empty : $" ({count})");
        }

        private void labelCategorias_DoubleClick(object sender, EventArgs e) {
            var chk = (CheckedListBox)((Control)sender).Tag;
            while (chk.CheckedIndices.Count > 0) {
                chk.SetItemChecked(chk.CheckedIndices[0], false);
            }
        }

        private void dgvRemedios_DoubleClick(object sender, EventArgs e) {
            var remedio = (Remedio)dgvRemedios.CurrentRow.DataBoundItem;
            if (remedio.Link != null) {
                System.Diagnostics.Process.Start(remedio.Link);
            }
        }
    }
}