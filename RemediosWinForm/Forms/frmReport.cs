using DataLayer;
using Microsoft.Reporting.WinForms;
using SuperReport;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Remedios {
    public partial class frmReport : SuperReportViewer {

        private readonly RemediosEntities _ctx = new RemediosEntities();

        public frmReport() {
            InitializeComponent();

            var btn = new ToolStripButton() {
                Text = "Medicamentos",
                DisplayStyle = ToolStripItemDisplayStyle.Text
            };
            btn.Click += ToolStripButtonAlfabetico_Click;
            toolStripMenu.Items.Add(btn);

            btn = new ToolStripButton() {
                Text = "Categorias",
                DisplayStyle = ToolStripItemDisplayStyle.Text
            };
            btn.Click += ToolStripButtonCategoria_Click;
            toolStripMenu.Items.Add(btn);

            btn = new ToolStripButton() {
                Text = "Princípios",
                DisplayStyle = ToolStripItemDisplayStyle.Text
            };
            btn.Click += ToolStripButtonPrincipio_Click;
            toolStripMenu.Items.Add(btn);

            toolStripMenu.Items.Add(new ToolStripSeparator());
            toolStripMenu.Items.Add(new ToolStripLabel() {
                Text = "Filtro:"
            });

            var cbx = new ToolStripComboBox() {
                Items = { "Todos", "Humanos", "Veterinários" },
                SelectedIndex = 0,
                Name = "Filtro",
                Font = toolStripMenu.Font
            };
            toolStripMenu.Items.Add(cbx);

        }

        private void ToolStripButtonAlfabetico_Click(object sender, EventArgs e) {
            SetLocalReport("RemediosAlfabetico", "Remédios ordem Alfabética", "DataSetRemedios",
                _ctx.Remedios.ToList(), GetFiltro());
        }

        private void ToolStripButtonCategoria_Click(object sender, EventArgs e) {
            SetLocalReport("RemediosCategorias", "Remédios por Categoria", "DataSetCategorias",
                _ctx.spCategoriasRemedios().ToList(), GetFiltro());
        }

        private void ToolStripButtonPrincipio_Click(object sender, EventArgs e) {
            SetLocalReport("RemediosPrincipios", "Remédios por Princípio", "DataSetPrincipios",
                _ctx.spPrincipiosRemedios().ToList(), GetFiltro());
        }

        private ReportParameter[] GetFiltro() {
            var cbx = (ToolStripComboBox)toolStripMenu
                .Items.Find("Filtro", false).First();
            var letra = ((string)cbx.SelectedItem)[0].ToString();
            return new ReportParameter[] {
                new ReportParameter("Filtro", letra)
            };
        }
    }
}
