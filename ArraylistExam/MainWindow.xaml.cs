using System;
using System.Collections;
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

namespace ArraylistExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(Input_TexT.Text);
            MessageBox.Show("Name : " + Input_TexT.Text);
            Input_TexT.Text = "";
            arrayList.Sort();
        }

        private void Btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(Input_TexT.Text);
            MessageBox.Show("Remove : " + Input_TexT.Text);
            Input_TexT.Text = "";
        }

        private void Btn_Show_Click(object sender, RoutedEventArgs e)
        {
            foreach (string data in arrayList)
            {
                MessageBox.Show("Name : " + data.ToString());
            }
            MessageBox.Show("Count : " + arrayList.Count.ToString());
        }
    }
}
