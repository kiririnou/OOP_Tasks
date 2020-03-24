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
using System.IO;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        //ObservableCollection<Student> students = new ObservableCollection<Student>();

        public MainWindow()
        {
            InitializeComponent();
            dp_SCDate.SelectedDate = DateTime.Today;
        }

        private void Tb_Add_Click(object sender, RoutedEventArgs e)
        {
            Student std = new Student()
            {
                Firstname = tb_FName.Text,
                Lastname = tb_LName.Text,
                Age = int.Parse(tb_Age.Text.Trim()),
                SCard = new StudentCard()
                {
                    Number = tb_SCNumber.Text,
                    DateOfIssuance = dp_SCDate.SelectedDate
                }
            };

            students.Add(std);

            tb_FName.Text = "";
            tb_LName.Text = "";
            tb_Age.Text = "";
            tb_SCNumber.Text = "";
            dp_SCDate.SelectedDate = DateTime.Today;

            lb_Students.Items.Add(std);
        }

        private void B_Save_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("Students"));

            using (FileStream fs = new FileStream("students-" + DateTime.Now.ToString("MM-dd-yyyy") + ".xml", FileMode.Create))
            {
                serializer.Serialize(fs, students);
            }
            MessageBox.Show("List successfully saved!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
