using DataLayer;
using DbContextExtensions;
using System.Data.Entity;
using System.Windows.Forms;

namespace RemediosWinForm {
    public partial class frmProdutos : Form {
        private readonly RemediosEntities _ctx = new RemediosEntities();

        public frmProdutos() {
            InitializeComponent();
            _ctx.Produtos.Load();
            produtoBindingSource.DataSource = _ctx.Produtos.Local.ToBindingList();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, System.EventArgs e) {
            if (!_ctx.SaveChanges(out var message)) {
                MessageBox.Show(message, "Produtos", 
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
