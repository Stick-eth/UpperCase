using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UpperCase.Model;
using UpperCase.ViewModel;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ModelUpper model;
        ViewModelUpper viewModel;

        public MainWindow()
        {
            InitializeComponent();
            this.model = new ModelUpper();
            this.viewModel = new ViewModelUpper(this.model);
        }

        private void buton_Click(object sender, RoutedEventArgs e)
        {
            output.Text= this.viewModel.Update(enter.Text);
        }
    }
}