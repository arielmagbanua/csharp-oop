using System;
namespace CohesionAndCoupling.TightCoupling
{
	public abstract class AbstractEngine : IEngine
	{
		public AbstractEngine()
		{
		}

        public abstract void Start();

        public abstract void Stop();
    }
}

