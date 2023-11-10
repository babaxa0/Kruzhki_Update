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
    /// Логика взаимодействия для Add_kruzhok.xaml
    /// </summary>
    public partial class Add_kruzhok : Window
    {
        public Add_kruzhok()
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кружок успешно добавлен.");
            Kruzhok kruzhok = new Kruzhok();
            kruzhok.Show();
            this.Close();
        }
    }
}
