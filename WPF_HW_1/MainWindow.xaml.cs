using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace WPF_HW_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string query = "SELECT * FROM students";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                if (TextBox1.Text == "" | TextBox2.Text == "" | TextBox3.Text == "")
                    MessageBox.Show("Некоректно введено имя. Повторите ввод");
                else if (TextBox4.Text == "")
                    MessageBox.Show("Некоректно введен номер телефона. Повторите ввод");
                else if (TextBox5.Text == "" | TextBox6.Text == "")
                    MessageBox.Show("Некоректно введен номер группы или название факультета. Повторите ввод");
                Student NewStudent = new Student { SecondName = TextBox1.Text, Name = TextBox2.Text, Patronymic = TextBox3.Text, Telephone = TextBox4.Text, Faculty = TextBox5.Text, GroupName = TextBox6.Text };
                context.students.Add(NewStudent);
                context.SaveChanges();
                MessageBox.Show("Объект успешно сохранен");
            }
            
        }

      

        
    }
}
