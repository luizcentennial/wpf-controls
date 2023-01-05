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

namespace Example04 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void OnClickOK(object sender, EventArgs e) {
			// Named controls can be accessed in the code-behind like any other class field.
			// Since txtName is a TextBox, we can retrieve its current value from property 'Text'.
			string name = txtName.Text;

			if (string.IsNullOrWhiteSpace(name)) {
				MessageBox.Show($"Make sure to input your name before clicking the button.");
			}
			else {
				MessageBox.Show($"Hello, {name}!");
			}
		}
	}
}
