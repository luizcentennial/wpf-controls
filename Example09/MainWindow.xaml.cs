using System.Windows;
using System.Windows.Controls;

namespace Example09 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			this.InitTabs();
		}

		private void InitTabs() {
			myTabs.Items.Add(new TabItem() {
				Header = "Tab 1",
				Content = new Border() {
					Margin = new Thickness(10),
					Child = new Label() { Content = "This is the first label." }
				}
			});
			myTabs.Items.Add(new TabItem() {
				Header = "Tab 2",
				Content = new Border() {
					Margin = new Thickness(10),
					Child = new Label() { Content = "This is the second label." }
				}
			});
			myTabs.Items.Add(new TabItem() {
				Header = "Tab 3",
				Content = new Border() {
					Margin = new Thickness(10),
					Child = new Label() { Content = "This is the third label." }
				}
			});
			myTabs.Items.Add(new TabItem() {
				Header = "Tab 4",
				Content = new Border() {
					Margin = new Thickness(10),
					Child = new Label() { Content = "This is the fourth label." }
				}
			});
		}
	}
}
