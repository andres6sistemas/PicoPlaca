using System;

namespace PicoPlaca
{
	public class PicoPlacaValidator
	{
		string placa;
		DateTime dateTime;
		TimeSpan currentTime;

		public void setPlaca(string value)
		{
			placa = value;
		}

		public void setDate(DateTime value)
		{
			dateTime = value;
		}

		public void setTime(TimeSpan value)
		{
			currentTime = value;
		}

		public void printData()
		{
			Console.WriteLine ("Car Placa: " + placa);
			Console.WriteLine ("Day: " + dateTime.DayOfWeek.ToString());
			Console.WriteLine ("Time: " + currentTime);
		}

		private bool isPicoTime()
		{
			if ((currentTime > new TimeSpan (7, 0, 0) && currentTime < new TimeSpan (9, 30, 0)) || (currentTime > new TimeSpan (16, 0, 0) && currentTime < new TimeSpan (19, 30, 0))) {
				return true;
			}

			return false;

		}

		public bool canBeOnRoad()
		{
			int lastDigit = int.Parse (placa.Substring(placa.Length-1));


			switch (dateTime.DayOfWeek) {

			case DayOfWeek.Monday:

				if ( (lastDigit == 1 || lastDigit == 2 ) && isPicoTime()) {
					return false;
				}

				break;

			case DayOfWeek.Tuesday:

				if ((lastDigit == 3 || lastDigit == 4) && isPicoTime()) {
					return false;
				}

				break;

			case DayOfWeek.Wednesday:

				if ((lastDigit == 5 || lastDigit == 6) && isPicoTime()) {
					return false;
				}

				break;

			case DayOfWeek.Thursday:

				if ((lastDigit == 7 || lastDigit == 8) && isPicoTime()) {
					return false;
				}

				break;

			case DayOfWeek.Friday:

				if ((lastDigit == 9 || lastDigit == 0) && isPicoTime()) {
					return false;
				}

				break;

			}


			return true;


		}
	}
}

