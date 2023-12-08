using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Shapes;

namespace Button.Scripts
{
	public class CustomButton : SelectableShape
	{
		public CustomButton(Point spawnPoint, Layout parentLayout, double width, double height, Color backgroundcolor, Color strokeColor) : base(spawnPoint, parentLayout, width, height, strokeColor)
		{
			Shape.Background = backgroundcolor;
		}

		public void AddLabel(string text, float size, Color color)
		{
			Label label = new Label();
			label.Text = text;
			label.FontSize = size;
			label.TextColor = color;
			label.HorizontalOptions = LayoutOptions.Center;
			label.VerticalOptions = LayoutOptions.Center;

			Shape.Content = label;
		}

		protected override void OnTabbedEvent()
		{
		}
	}
}
