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

// added these to allow usage of SQL db : - Sum
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LoginReg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window // login
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // go watch this: -sum
        // https://parallelcodes.com/wpf-create-login-form-with-sql-database/


        // OK button LOGIN
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}