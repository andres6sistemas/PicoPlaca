using System;

namespace PicoPlaca
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PicoPlacaValidator validator = new PicoPlacaValidator ();

			validator.setPlaca (InputUtil.readCarPlaca());
			validator.setDate (InputUtil.readDate());
			validator.setTime (InputUtil.readTime());
			validator.printData ();

			if (validator.canBeOnRoad ()) {			
				Console.WriteLine ("this car can be on road now");
			} else {
				Console.WriteLine ("this car cant be on road now");
			}

		}

	}

}
