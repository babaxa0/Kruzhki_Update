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

namespace Kruzhki
{
    /// <summary>
    /// Логика взаимодействия для HomePageVicePresident.xaml
    /// </summary>
    public partial class HomePageVicePresident : Window
    {
        public HomePageVicePresident()
        {
            InitializeComponent();
        }
        private void ExitButt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btn_check_kruzh_Click(object sender, RoutedEventArgs e)
        {
            KruzhkiCheck kruzhkiCheck = new KruzhkiCheck();
            kruzhkiCheck.Show();
            this.Close();
        }

        private void btn_red_kruzh_Click(object sender, RoutedEventArgs e)
        {
            Kruzhok add_Kruzhok = new Kruzhok();
            add_Kruzhok.Show();
            this.Close();
        }

        private void btn_teachers_Click(object sender, RoutedEventArgs e)
        {
            CheckTeachers checkTeachers = new CheckTeachers();
            checkTeachers.Show();
            this.Close();
        }
    }
}
