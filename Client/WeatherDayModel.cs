namespace Client
{
	public class WeatherDayModel
	{
		private WeatherCurrentModel _day1;
		private WeatherCurrentModel _day2;
		private WeatherCurrentModel _day3;
		private WeatherCurrentModel _day4;
		private WeatherCurrentModel _day5;
		private WeatherCurrentModel _day6;
		private WeatherCurrentModel _day7;

		public WeatherCurrentModel Day1
		{
			get { return _day1; }
			set { _day1 = value; }
		}

		public WeatherCurrentModel Day2
		{
			get { return _day2; }
			set { _day2 = value; }
		}

		public WeatherCurrentModel Day3
		{
			get { return _day3; }
			set { _day3 = value; }
		}

		public WeatherCurrentModel Day4
		{
			get { return _day4; }
			set { _day4 = value; }
		}

		public WeatherCurrentModel Day5
		{
			get { return _day5; }
			set { _day5 = value; }
		}

		public WeatherCurrentModel Day6
		{
			get { return _day6; }
			set { _day6 = value; }
		}

		public WeatherCurrentModel Day7
		{
			get { return _day7; }
			set { _day7 = value; }
		}
	}
}