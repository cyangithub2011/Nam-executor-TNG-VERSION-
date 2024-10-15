using System.IO;
using System.Windows;
using System.Windows.Input;
using ForlornApi;
using TNGAPI;

namespace Nam_executor_V3_remake
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TNGEXPLOITTOP1.TNGLoad();

            editor.Navigate(new Uri(string.Format("file:///{0}/Monaco/index.html", Directory.GetCurrentDirectory())));


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TNGEXPLOITTOP1.Inject();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String script = editor.InvokeScript("getValue").ToString();
            TNGEXPLOITTOP1.Execute(script);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            editor.InvokeScript("setValue", "");
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}