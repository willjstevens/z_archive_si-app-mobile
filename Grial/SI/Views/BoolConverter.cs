﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
//namespace SI.Views
{
	public class BoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (bool)value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
