using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataLayer;

namespace RemediosWpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private readonly RemediosEntities _ctx = new RemediosEntities();
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            var remedioViewSource = (CollectionViewSource)this.FindResource("remedioViewSource");
            // Load data by setting the CollectionViewSource.Source property:
            _ctx.Remedios.Load();
            remedioViewSource.Source = _ctx.Remedios.Local.ToBindingList();
        }
    }
}
