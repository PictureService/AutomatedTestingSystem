using System;

namespace AutomatedTestingSystem.TestFramework
{
	public static class RandomMachine
	{
		public static Random Random
			=> new Random(new Guid().GetHashCode());
	}
}
