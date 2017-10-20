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

namespace WpfApp4
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

		private void exerise1btn_Click(object sender, RoutedEventArgs e)
		{
			exercise1label.Content = "You clicked the button";
		}
		private bool onOffStatus = true;
		private int counter = 1;

		private void exercise2btn_Click(object sender, RoutedEventArgs e)
		{
			if (onOffStatus)
				exercise2btn.Content = "Off";
			else
				exercise2btn.Content = "On";
			onOffStatus = !onOffStatus;
		}

		private void exercise3btn_Click(object sender, RoutedEventArgs e)
		{
			exercise3label.Content = exercise3tb.Text;
		}

		private void CountingButton_Click(object sender, RoutedEventArgs e)
		{
			countingListbox.Items.Add(counter);
			counter++;
		}

		private void CodeBtn1_Click(object sender, RoutedEventArgs e)
		{
			CodeBtn2.IsEnabled = !CodeBtn2.IsEnabled;
			CodeBtn3.IsEnabled = true;
			CodeBtn4.IsEnabled = false;
		}

		private void CodeBtn2_Click(object sender, RoutedEventArgs e)
		{
			CodeBtn1.IsEnabled = false;
			CodeBtn4.IsEnabled = !CodeBtn4.IsEnabled;
			CodeBtn5.IsEnabled = !CodeBtn5.IsEnabled;
			CodeBtn6.IsEnabled = !CodeBtn6.IsEnabled;
		}

		private void CodeBtn3_Click(object sender, RoutedEventArgs e)
		{
			CodeBtn1.IsEnabled = !CodeBtn1.IsEnabled;
			CodeBtn2.IsEnabled = !CodeBtn2.IsEnabled;
			CodeBtn6.IsEnabled = !CodeBtn6.IsEnabled;
			CheckVictory();
		}
		private void CheckVictory()
		{
			if (CodeBtn1.IsEnabled && CodeBtn2.IsEnabled && CodeBtn3.IsEnabled && CodeBtn4.IsEnabled && CodeBtn5.IsEnabled && CodeBtn6.IsEnabled && CodeBtn7.IsEnabled && CodeBtn8.IsEnabled)
			{
				exercise3label.Content = "Grattis! Du knäckte koden.";
			}
		}

		private void CodeBtn4_Click(object sender, RoutedEventArgs e)
		{
			CodeBtn1.IsEnabled = true;
			CodeBtn2.IsEnabled = true;
			CodeBtn3.IsEnabled = true;
			CodeBtn5.IsEnabled = true;
			CodeBtn6.IsEnabled = true;
			CheckVictory();
		}
	}
}
