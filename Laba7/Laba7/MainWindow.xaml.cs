using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Laba7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Dp { get; set; }
        string CnStr { get; set; }
     static   SqlConnection connection { get; set; }
        DataTable data;
        SqlDataAdapter adapter;
        public MainWindow()
        {
            InitializeComponent();
            Dp = ConfigurationManager.AppSettings["provider"];
            CnStr = ConfigurationManager.AppSettings["strconnect"];
            connection = new SqlConnection(CnStr);
            //using(SqlConnection connection =new SqlConnection(CnStr))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand();
            //    command.CommandText = "SELECT TABLE_NAME FROM KV_DATABASE";

            //    connection.Close();
            //}
            string[] buf = { "Items", "WAYBILL", "COMPANY" };
            for (int i = 0; i < buf.Count(); i++)
            {
                Tables.Items.Add(buf[i]);
            }
            
        }

      

        private void GridLoaded(object sender, RoutedEventArgs e)
        {
            if (Tables.SelectedItem != null)
            { 
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * FROM " + Tables.SelectedItem;

            data = new DataTable();

            adapter = new SqlDataAdapter(command);
            adapter.Fill(data);


            grid.DataContext = data.DefaultView;
            }
        }

        private void Additem(object sender, RoutedEventArgs e)
        {
            
            
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adapter);
            adapter.Update(data);
        }

        private void Adding(object sender, AddingNewItemEventArgs e)
        {
            var a = (DataGrid)sender;
            MessageBox.Show(a.Columns.ToString());
        }

       
        public static void SaveFileToDatabase()
        {
            
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Images VALUES (@FileName,  @ImageData)";
                command.Parameters.Add("@FileName", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Title", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@ImageData", SqlDbType.Image, 1000000);

                string filename = @"C:\Users\Eugene\Pictures\cats.jpg";
                string shortFileName = filename.Substring(filename.LastIndexOf('\\') + 1); 
                byte[] imageData;
                using (System.IO.FileStream fs = new System.IO.FileStream(filename, FileMode.Open))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                }
                command.Parameters["@FileName"].Value = shortFileName;
                command.Parameters["@ImageData"].Value = imageData;

                command.ExecuteNonQuery();
            
        }

        private void Tables_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridLoaded(sender,e);
        }

        private void grid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(CnStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM "+Tables.SelectedItem;
                var a=command.ExecuteReader();
                for (int i = 0; i < a.FieldCount; i++)
                {
                   MessageBox.Show(a.GetSqlValue(i).ToString());

                }
                
                
                connection.Close();
            }
            //string phone_number = @"[+]{1}[3]{1}[7]{1}[5]{1}-\d{2}-\d{3}-\d{2}-\d{2}$";
            //Regex regex = new Regex(phone_number);
            //var b = data.Rows[data.Rows.Count-1].ItemArray;
            //foreach (var item in b)
            //{
          
            //}
        }
    }

}
