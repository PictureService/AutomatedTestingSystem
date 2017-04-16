using System;

namespace AutomatedTestingSystem.TestFramework
{
	public static class RandomNumeric
	{
		public static int GetInt32()
		{
            //Реализовать несколько методов получения 1 числа(3 метода с разными параметрами(границы))
            Random rand = new Random();
            return rand.Next();
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Максимально допустимое значение</param>
        /// <returns></returns>
        public static int GetInt32(int a)
        {
            //Реализовать несколько методов получения 1 числа(3 метода с разными параметрами(границы))
            Random rand = new Random();
            return rand.Next(a);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Левая граница интервала</param>
        /// <param name="b">Правая граница интервала</param>
        /// <returns></returns>
        public static int GetInt32(int a,int b)
        {
            //Реализовать несколько методов получения 1 числа(3 метода с разными параметрами(границы))
            Random rand = new Random();
            return rand.Next(a,b);
        }
    }
}
