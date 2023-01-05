using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Example08 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			// The line below defines the list of objects to display in the DataGrid.
			myDataGrid.ItemsSource = GetDataGridData();
		}

		// Method OnGenerateColumns, which is an event handler, is executed when
		// the DataGrid generates its columns.
		private void OnGenerateColumns(object sender, EventArgs e) {
			foreach (var column in ((DataGrid)sender).Columns) {
				if (column.Header.ToString() == "PropertyHiddenFromDataGrid") {
					column.Visibility = Visibility.Hidden;
				}
				else if (column.Header.ToString() == "SomeProperty") {
					column.Header = "Some Property";
				}
				else if (column.Header.ToString() == "AnotherProperty") {
					column.Header = "Another Property";
				}
				else if (column.Header.ToString() == "YetAnotherProperty") {
					column.Header = "Yet Another Property";
				}
				else if (column.Header.ToString() == "LastProperty") {
					column.Header = "Last Property";
				}
			}
		}

		private List<Thing> GetDataGridData() {
			return new List<Thing>() {
				new Thing() {
					SomeProperty = "Hello",
					AnotherProperty = "World",
					YetAnotherProperty = "Of",
					PropertyHiddenFromDataGrid = "Can't see me",
					LastProperty = "C#"
					},
				new Thing() {
					SomeProperty = "Hi",
					AnotherProperty = "There",
					YetAnotherProperty = "Good-looking",
					PropertyHiddenFromDataGrid = "Can't see me",
					LastProperty = "Stranger"
					},
				new Thing() {
					SomeProperty = "Greetings",
					AnotherProperty = "From",
					YetAnotherProperty = "The",
					PropertyHiddenFromDataGrid = "Can't see me",
					LastProperty = "DataGrid"
					},
				new Thing() {
					SomeProperty = "Time",
					AnotherProperty = "To",
					YetAnotherProperty = "Say",
					PropertyHiddenFromDataGrid = "Can't see me",
					LastProperty = "Bye bye"
					},
			};
		}
	}

	public class Thing {
		public string SomeProperty { get; set; }
		public string AnotherProperty { get; set; }
		public string YetAnotherProperty { get; set; }
		public string PropertyHiddenFromDataGrid { get; set; }
		public string LastProperty { get; set; }
	}
}
