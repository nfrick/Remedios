using DataLayer;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RemediosWinForm {
    public partial class Comparador : UserControl {
        public Comparador() {
            InitializeComponent();
        }

        public void PopulateCombo(Remedio[] remedios) {
            comboBoxRemedio.Items.AddRange(remedios);
        }

        private void comboBoxRemedio_SelectedIndexChanged(object sender, System.EventArgs e) {
            remedioBindingSource.DataSource = comboBoxRemedio.SelectedItem;
            SortDGV(dgvCategorias);
            SortDGV(dgvIndicacoes);
            SortDGV(dgvPrincipios);
            foreach (Control ctl in Controls) {
                ctl.Visible = true;
            }
        }

        private static void SortDGV(DataGridView dgv) {
            dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
        }

        private void comboBoxRemedio_TextChanged(object sender, System.EventArgs e) {
            if (comboBoxRemedio.Text.Length > 0) {
                return;
            }
            foreach (Control ctl in Controls.Cast<Control>()
                .Where(c => c.GetType().Name != "ComboBox")) {
                ctl.Visible = false;
            }
        }

        private void linkLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(linkLinkLabel.Text);
        }

        private void linkLabelBula_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            var frm = new frmBula() {
                remedio = ((Remedio)comboBoxRemedio.SelectedItem)
            };
            frm.Show();
        }
    }
}
