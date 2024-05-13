using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Kviz
{
    /// <summary>
    /// Interaction logic for WrongAnswers.xaml
    /// </summary>
    public partial class WrongAnswers : Window
    {
        public WrongAnswers()
        {
            InitializeComponent();
         
            foreach(String line in MainWindow.wrongAnswers)
            {
                tbWrongAnswers.Text += line + '\n';
            }
            tbBrojTacnihOdgovora.Text = MainWindow.brojTacnihOdgovora.ToString(); 
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.wrongAnswers.Clear();
            MainWindow.brojTacnihOdgovora = 0;
            MainWindow mw = new MainWindow();
            mw.Owner = this;
            this.Hide();
            mw.ShowDialog();     
        }

        private void btnNe_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
