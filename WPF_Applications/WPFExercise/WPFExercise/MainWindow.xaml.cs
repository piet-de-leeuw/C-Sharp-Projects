using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = TextToWrite.Text;


            if(!string.IsNullOrEmpty(todoText))
            {
                TextBlock newTodo = new TextBlock
                {
                    Text = "- " + todoText,
                    Margin = new Thickness(10),
                };


                TodoStack.Children.Add(newTodo);

                TextToWrite.Clear();
            }

        }

        private void RemoveTodoButton_Click(Object sender, RoutedEventArgs e)
        {
            bool isInt = int.TryParse(NrToRemove.Text, out int nr);
            bool isOutOfRange = nr >= TodoStack.Children.Count;

            if(isInt && nr != 0 && !isOutOfRange)
            {
                TodoStack.Children.RemoveAt(nr);
            }
        }
    }
}