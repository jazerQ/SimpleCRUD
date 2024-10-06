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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace crud
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection sqlConnection = null;
        public MainWindow()
        {
            InitializeComponent();
            Load_Grid();
            clear.Click += Clear_Click;
            insert.Click += Insert_Click;
            //Form1_Load();
            
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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
        /*private void Form1_Load()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            sqlConnection.Open();
            if(sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Установлено!");
            }
        }*/
        public void Load_Grid()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from FirstTable",sqlConnection);
            DataTable dt = new DataTable();
            sqlConnection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            //sqlConnection.Close();
            dataGrid.ItemsSource = dt.DefaultView;
        }
    }
}
