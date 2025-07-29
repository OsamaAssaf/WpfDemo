using System.Windows;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Button button = new();
            //button.Content = "B";
            //button.Height = 50;

            //Grid.SetRow(button, 3);
            //Grid.SetColumn(button, 4);

            //Grid myGrid = (Grid)FindName("myGrid");
            //myGrid.Children.Add(button);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }
    }
}