namespace Client
{
	public class WeatherDetailModel
	{
		private string _feels_like_temperature;
		private string _pressure;
		private string _humidity;
		private string _cloudiness;
		private string _wind_speed;

		public string Feels_Like_Temperature
		{
			get { return _feels_like_temperature; }
			set
			{
				if (_feels_like_temperature == value)
				{
					return;
				}
				_feels_like_temperature = value;
			}
		}

		public string Pressure
		{
			get { return _pressure; }
			set
			{
				if (_pressure == value)
				{
					return;
				}
				_pressure = value;
			}
		}

		public string Humidity
		{
			get { return _humidity; }
			set
			{
				if (_humidity == value)
				{
					return;
				}
				_humidity = value;
			}
		}

		public string Cloudiness
		{
			get { return _cloudiness; }
			set
			{
				if (_cloudiness == value)
				{
					return;
				}
				_cloudiness = value;
			}
		}

		public string Wind_Speed
		{
			get { return _wind_speed; }
			set
			{
				if (_wind_speed == value)
				{
					return;
				}
				_wind_speed = value;
			}
		}
	}
}