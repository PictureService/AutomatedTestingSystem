using System;
using System.Collections.Generic;

namespace AutomatedTestingSystem.TestFramework.IEnumerableExtensions
{
	public static class IEnumerable
	{
        //Не трогать
		public static T FirstRandom<T>(this IEnumerable<T> input)
		{
            //Нужно выбрать из коллекции input случайный элемент.
            throw new NotImplementedException();
        }

        //Трогать
        public static int FirstRandom(this IEnumerable<int> input)
        {
            //Нужно выбрать из коллекции input случайный элемент. На выходе число.
            //throw new NotImplementedException();
            //int length = input.GetEnumerator.input;
            return 1;
        }
    }
}
