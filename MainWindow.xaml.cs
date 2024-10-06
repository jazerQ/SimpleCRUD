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

        public bool isValid()
        {
            if (name_txt.Text == string.Empty)
            {
                MessageBox.Show("введи имя","Faied", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (age_txt.Text == string.Empty)
            {
                MessageBox.Show("введи возраст", "Faied", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (city_txt.Text == string.Empty)
            {
                MessageBox.Show("введи город", "Faied", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (gender_txt.Text == string.Empty)
            {
                MessageBox.Show("введи пол", "Faied", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO FirstTable VALUES (@Name, @Age, @Gender, @City)", sqlConnection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", name_txt.Text);
                    cmd.Parameters.AddWithValue("@Age", age_txt.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender_txt.Text);
                    cmd.Parameters.AddWithValue("@City", city_txt.Text);
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    Load_Grid();
                    MessageBox.Show("Successful", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClearData();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearData() {
            name_txt.Clear();
            age_txt.Clear();
            city_txt.Clear();
            gender_txt.Clear();
            searchId.Clear();
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
            sqlConnection.Close();
            dataGrid.ItemsSource = dt.DefaultView;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"delete from FirstTable where ID = {searchId.Text}", sqlConnection);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись была удалена", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                //sqlConnection.Close();
                ClearData();
                Load_Grid();
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
