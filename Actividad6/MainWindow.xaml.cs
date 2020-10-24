using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Actividad6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void imagen_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 1;
        }

        private void imagen_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 0.5;
        }
    }
}
