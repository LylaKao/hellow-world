namespace Animal
{
	public class Dog : Mammals
	{
		
		void Dog()
		{
			HeartBeat = 100;
			BodyTemprerature = 38;
		}
		
		public void RunShort()
		{
			HeartBeat = 130;
			BodyTemperature = 40;
		}
	}
}