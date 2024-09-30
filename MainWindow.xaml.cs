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

namespace crud
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            clear.Click += Clear_Click;
        }

        private void ClearData() {
            name_txt.Clear();
            age_txt.Clear();
            city_txt.Clear();
            gender_txt.Clear();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }
    }
}
