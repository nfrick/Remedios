using DataLayer;
using IEnumerableExtensions;
using RemediosWinForm.Properties;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RemediosWinForm {
    public partial class frmAnvisa : Form {
        private readonly RemediosEntities _ctx = new RemediosEntities();

        public frmAnvisa() {
            InitializeComponent();
            comboBoxProcurar.DisplayMember = "Nome";
            ckbPrincipios.DisplayMember = "Nome";
            dgvAnvisaRemedio.FormatColumn("#", dgvAnvisaRemedio.StyleInteger, 40);
            radioButtonProduto.Checked = true;
        }

        #region DATAGRIDVIEW ------------------------
        private void anvisaRemedioSuperDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex != 7) {
                return;
            }

            var remedio = (AnvisaRemedio)dgvAnvisaRemedio.Rows[e.RowIndex].DataBoundItem;
            e.CellStyle.BackColor = remedio.TarjaColor;
            e.CellStyle.ForeColor = Color.White;
        }

        private void dgvAnvisaRemedio_DoubleClick(object sender, EventArgs e) {
            var remedio = (AnvisaRemedio)bsAnvisaRemedio.Current;
            ckbPrincipios.Items.Clear();
            ckbPrincipios.Items.AddRange(remedio.PrincipiosAtivos.ToArray());
            ChangeCheck(true);
            radioButtonPrincipio.Checked = true;
            buttonPesquisaPrincipio_Click(sender, e);
        }
        #endregion DATAGRIDVIEW ------------------------

        #region COMBOBOX DIRECT SEARCH ------
        private void Classe_SelectedIndexChanged(object sender, EventArgs e) {
            dgvAnvisaRemedio.Columns[0].Visible = false;
            dgvAnvisaRemedio.Columns[1].Visible = true;
            dgvAnvisaRemedio.Columns[5].Visible = false;
            bsAnvisaRemedio.DataSource =
                ((ClasseTerapeutica)comboBoxProcurar.SelectedItem).Remedios.ToBindingList();
        }

        private void Produto_SelectedIndexChanged(object sender, EventArgs e) {
            dgvAnvisaRemedio.Columns[0].Visible = false;
            dgvAnvisaRemedio.Columns[1].Visible = false;
            dgvAnvisaRemedio.Columns[5].Visible = true;
            bsAnvisaRemedio.DataSource =
                ((Produto)comboBoxProcurar.SelectedItem).Remedios.ToBindingList();
        }
        #endregion COMBOBOX DIRECT SEARCH ------

        #region PRINCIPIOS BUTTONS --------------
        private void buttonPesquisaPrincipio_Click(object sender, EventArgs e) {
            dgvAnvisaRemedio.Columns[0].Visible = true;
            dgvAnvisaRemedio.Columns[1].Visible = true;
            dgvAnvisaRemedio.Columns[5].Visible = true;

            var principiosSelecionados = ckbPrincipios.CheckedItems.Cast<PrincipioAtivo>();
            var osl = principiosSelecionados.SelectMany(p => p.Remedios).ToObservableListSource().ToBindingList();

            foreach (var item in osl) {
                item.SetMatches(principiosSelecionados);
            }
            bsAnvisaRemedio.DataSource = osl;
            dgvAnvisaRemedio.Sort(dgvAnvisaRemedio.Columns[0], ListSortDirection.Descending);
        }

        private void buttonChangeCheck_Click(object sender, EventArgs e) {
            var check = ((Button)sender).Name == "buttonCheck";
            ChangeCheck(check);
        }

        private void ChangeCheck(bool check) {
            for (var i = 0; i < ckbPrincipios.Items.Count; i++) {
                ckbPrincipios.SetItemChecked(i, check);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            ckbPrincipios.Items.Clear();
            buttonCheck.Enabled = false;
            buttonUncheck.Enabled = false;
            buttonClear.Enabled = false;
            buttonPesquisaPrincipio.Enabled = false;
        }
        #endregion PRINCIPIOS BUTTONS --------------

        #region COMBOBOX TO PRINCIPIOS LISTBOX ---------
        private void PrincipioParaLista_Click(object sender, EventArgs e) {
            if (ckbPrincipios.Items.Contains(comboBoxProcurar.SelectedItem)) {
                return;
            }

            var item = ckbPrincipios.Items.Add(comboBoxProcurar.SelectedItem);
            ckbPrincipios.SetItemChecked(item, true);
        }

        private void ProdutoParaLista_Click(object sender, EventArgs e) {
            var produto = (Produto)comboBoxProcurar.SelectedItem;
            if (produto == null) {
                return;
            }

            var principios = produto.Remedios.SelectMany(p => p.PrincipiosAtivos)
                .Distinct().OrderBy(p => p.Nome).ToArray();
            var x = comboBoxProcurar.SelectedIndex;
            radioButtonPrincipio.Checked = true;
            ckbPrincipios.Items.Clear();
            ckbPrincipios.Items.AddRange(principios);
            ChangeCheck(true);
            buttonPesquisaPrincipio_Click(sender, e);
        }
        #endregion COMBOBOX TO PRINCIPIOS LISTBOX ------

        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            comboBoxProcurar.Items.Clear();
            comboBoxProcurar.SelectedIndex = -1;
            comboBoxProcurar.Text = string.Empty;
            comboBoxProcurar.SelectedIndexChanged -= Produto_SelectedIndexChanged;
            comboBoxProcurar.SelectedIndexChanged -= Classe_SelectedIndexChanged;
            buttonAdd.Enabled = false;
            PrincipioVisible();
            if (radioButtonClasse.Checked) {
                labelProcurar.Text = "Classe:";
                comboBoxProcurar.Items.AddRange(_ctx.ClasseTerapeuticas.OrderBy(p => p.Nome).ToArray());
                comboBoxProcurar.SelectedIndexChanged += Classe_SelectedIndexChanged;
                buttonAdd.Visible = false;
            }
            else if (radioButtonPrincipio.Checked) {
                labelProcurar.Text = "Princípio:";
                comboBoxProcurar.Items.AddRange(_ctx.PrincipiosAtivos.OrderBy(p => p.Nome).ToArray());
                buttonAdd.Image = Resources.Add_24;
                buttonAdd.Click += PrincipioParaLista_Click;
                buttonAdd.Click -= ProdutoParaLista_Click;
                buttonAdd.Visible = true;
            }
            else {
                labelProcurar.Text = "Produto:";
                comboBoxProcurar.Items.AddRange(_ctx.Produtos.OrderBy(p => p.Nome).ToArray());
                comboBoxProcurar.SelectedIndexChanged += Produto_SelectedIndexChanged;
                buttonAdd.Image = Resources.Right_Arrow_24;
                buttonAdd.Click -= PrincipioParaLista_Click;
                buttonAdd.Click += ProdutoParaLista_Click;
                buttonAdd.Visible = true;
            }
        }

        private void PrincipioVisible() {
            foreach (Control ctl in panel2.Controls) {
                ctl.Visible = radioButtonPrincipio.Checked;
            }
        }

        private void ckbPrincipios_ItemCheck(object sender, ItemCheckEventArgs e) {
            var totalItems = ckbPrincipios.Items.Count;
            var checkedCount = ckbPrincipios.CheckedItems.Count + (e.NewValue == CheckState.Checked ? 1 : -1);
            var uncheckedCount = totalItems - checkedCount;
            var anyChecked = checkedCount > 0; ;
            var anyUnChecked = uncheckedCount > 0;

            buttonCheck.Enabled = anyUnChecked;
            buttonUncheck.Enabled = anyChecked;
            buttonClear.Enabled = ckbPrincipios.Items.Count > 0;
            buttonPesquisaPrincipio.Enabled = anyChecked;
        }

        private void comboBoxProcurar_SelectedIndexChanged(object sender, EventArgs e) {
            buttonAdd.Enabled = comboBoxProcurar.SelectedIndex != -1;
        }
    }
}
