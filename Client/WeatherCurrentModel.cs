namespace Client
{
	public class WeatherCurrentModel
	{
		// Per aiutare nella deserializzazione dei json ricevuti, selezionandone di volta in volta i campi di interesse
		private string _temperature;
		private string _description;
		private string _base64_icon;

		public string Temperature // Anche se le maiuscole/minuscole non sono rispettate, rispetto a json che arriva, non ci fa niente
		{
			get { return _temperature; }
			set
			{
				if (_temperature == value) // Validazione riguardo corrente e vecchio valore che non siano uguali
				{
					return;
				}
				_temperature = value;
			}
		}

		public string Description
		{
			get { return _description; }
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
			}
		}

		public string Base64_Icon
		{
			get { return _base64_icon; }
			set
			{
				if (_base64_icon == value)
				{
					return;
				}
				_base64_icon = value;
			}
		}
	}
}