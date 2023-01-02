using System.Windows;

namespace Example02 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		// This method is an Event Handler.
		// It is executed every time the UI button is clicked.
		private void OnClick(object sender, RoutedEventArgs e) {
			// MessageBox.Show is the WPF equivalent of Console.WriteLine.
			// It can be used to display messages to users, as well as collect basic dialog responses.
			MessageBox.Show("Button clicked!");
		}
	}
}
