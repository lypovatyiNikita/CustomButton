using System.Windows.Input;
using System.Windows;
using Button.Scripts;

namespace Button
{
	public partial class MainPage : ContentPage
	{
		private CustomButton newCustomButton;

		public MainPage()
		{
			InitializeComponent();
			newCustomButton = new CustomButton(new Point(150, 100), MainLayout, 200, 100, Brush.Gray.Color, Brush.Black.Color);
			newCustomButton.AddLabel("Test button", 14, Brush.Black.Color);
			newCustomButton.OnTabbed += OnTabbed;
		}

		private void OnTabbed()
		{
			Random r = new Random();
			MainLayout.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
		}

		private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
		{
			newCustomButton.CheckTabbedEvent(sender, e);
		}
	}

}
