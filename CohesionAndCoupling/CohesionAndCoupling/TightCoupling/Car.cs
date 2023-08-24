using System;
namespace CohesionAndCoupling.TightCoupling
{
	public class Car
	{
		private IEngine engine;

		public Car(IEngine engine)
		{
			this.engine = engine;
		}

		public void Start()
		{
			this.engine.Start();
		}

		public void Stop()
		{
			this.engine.Stop();
		}
	}
}

