using System.Windows;
using System.Windows.Controls;

namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cuadroTexBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cuadroTexBox.Text.Length == 140)
                cuadroTexBox.IsReadOnly = true;

            for(int i = 0; i <= cuadroTexBox.Text.Length; i++){
                contadorTextBlock.Text = i + "/140";
            }

        }
    }
}
