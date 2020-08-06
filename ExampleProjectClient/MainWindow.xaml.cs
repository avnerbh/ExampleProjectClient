using ExampleProjectClient.MyWCFServiceReference;
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

namespace ExampleProjectClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyWCFServiceClient srv = new MyWCFServiceClient();
            Student stu = srv.StudentSelectByID(1);

            StudentList students = srv.StudentSelectAll();

            String str = "";

            students.ForEach(s => str += s.FirstName + " ");
                 
            
            MessageBox.Show(str);
            //MessageBox.Show(stu == null ? "is null !!!" : stu.City.Name + " " + stu.FirstName);


            //string s = srv.GetData(3);
            //MessageBox.Show(s);
            //System.Diagnostics.Debug.WriteLine("ABC:" + stu.FirstName);
            //MessageBox.Show(stu == null?"null":stu.FirstName);


        }
    }
}
