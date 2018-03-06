using System;
using System.Globalization;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
//namespace SI.Views
{
	public class TitleCaseConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{

			var str = (string) value;
			string upperFirstChar = str.Substring(0, 1).ToUpper();
			str = upperFirstChar + str.Substring(1);
			return str;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
