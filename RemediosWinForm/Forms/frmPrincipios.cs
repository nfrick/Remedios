using DataLayer;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace RemediosWinForm {
    public partial class frmPrincipios : Form {
        private RemediosEntities ctx = new RemediosEntities();
        public frmPrincipios() {
            InitializeComponent();
            principioAtivoSuperDGV.FormatColumn("ID", principioAtivoSuperDGV.StyleInteger, 30);
            principioAtivoSuperDGV.SetFont(14);
            ctx.PrincipiosAtivos.Load();
            principioAtivoBindingSource.DataSource = ctx.PrincipiosAtivos.Local.ToBindingList();
        }

        private void principioAtivoBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            principioAtivoSuperDGV.EndEdit();
            ctx.SaveChanges();
        }
    }
}
