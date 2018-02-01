using System;

namespace PicoPlaca
{
	public class InputUtil
	{
		public static string readCarPlaca ()
		{
			string buffer = null;
			while (true) {

				Console.WriteLine ("Car plate number, ejm(AAC-0123): ");
				buffer = Console.ReadLine ();

				if (buffer.Length == 8 && haveOnlyLetters(buffer.Substring(0,3)) && haveOnlyDigits(buffer.Substring(4,4)) && buffer[3]=='-' && char.IsDigit (buffer [7])) {

					break;

				} else {

					Console.WriteLine ("incorrect value");
					Console.Read ();
					Console.Clear ();

				}	

			}

			return buffer;
		}

		public static DateTime readDate ()
		{

			DateTime dateTime;
			while (true) {

				Console.WriteLine ("Date, ejm(01/02/18): ");
				string buffer = Console.ReadLine ();


				try
				{
					dateTime = DateTime.ParseExact(buffer, "dd/MM/yy", System.Globalization.CultureInfo.InvariantCulture);
					break;					
				}
				catch {

					Console.WriteLine ("incorrect value");
					Console.Read ();
					Console.Clear ();
				
				}

			}

			return dateTime;
		}

		public static TimeSpan readTime ()
		{

			TimeSpan currentTime;
			while (true) {

				Console.WriteLine ("Time, ejm(13:30): ");
				string buffer = Console.ReadLine ();


				try
				{
					currentTime = TimeSpan.Parse(buffer);
					break;					
				}
				catch {

					Console.WriteLine ("incorrect value");
					Console.Read ();
					Console.Clear ();

				}

			}
			return currentTime;
		}


		private static bool haveOnlyDigits(string value)
		{
			for (int i = 0; i < value.Length; i++) {

				if (!char.IsDigit (value [i])) {
					return false;
				}
			
			}

			return true;			
		}

		private static bool haveOnlyLetters(string value)
		{
			for (int i = 0; i < value.Length; i++) {

				if (char.IsDigit (value [i])) {
					return false;
				}

			}

			return true;

		}

	}
}

