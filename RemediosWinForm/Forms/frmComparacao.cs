using DataLayer;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RemediosWinForm {
    public partial class frmComparacao : Form {
        private readonly RemediosEntities _ctx = new RemediosEntities();

        public frmComparacao() {
            InitializeComponent();
            _ctx.Remedios.Load();
            var remedios = _ctx.Remedios.Local.OrderBy(r => r.Nome).ToArray();
            comparador1.PopulateCombo(remedios);
            comparador2.PopulateCombo(remedios);
        }
    }
}
