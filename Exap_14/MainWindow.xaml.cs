using Exap_14.view;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exap_14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TablAppraisalWin tablAppraisalWin = new TablAppraisalWin();
            tablAppraisalWin.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TabSubjectWin tabSubjectWin = new TabSubjectWin();
            tabSubjectWin.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TabSpecWin tabSpecWin = new TabSpecWin();
            tabSpecWin.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TabStudWin tabSpecWin = new TabStudWin();
            tabSpecWin.Show();
        }
    }
}
