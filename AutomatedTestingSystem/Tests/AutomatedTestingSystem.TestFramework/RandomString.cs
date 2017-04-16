using System;

namespace AutomatedTestingSystem.TestFramework
{
    public static class RandomString
    {
        public static string GetText(int characters, int writeSpace)
        {
            char[] randomWord = new char[characters];
            int divider = characters / writeSpace;
            Random random = new Random();
  
            for (int i = 0; i < characters; i++)
            {
                if (i + 1 % divider == 0)
                {
                    continue;
                }
                if ((i & 1) == 0)
                {
                    randomWord[i] = (char)random.Next(62, 122);
                }
                else
                {
                    randomWord[i] = (char)random.Next(0, 61);
                }
            }
            return Convert.ToString(randomWord);
        }

        public static string GetString()
        {
            char[] randomWord = new char[14];
            Random random = new Random();
            //A-Z (65-90) a-z(97-122) 0-9(48-57)
            for (int i = 0; i < 14; i++)
            {
                if ((i & 1) == 0)
                {
                    randomWord[i] = (char)random.Next(62, 122);
                }
                else
                {
                    randomWord[i] = (char)random.Next(0, 61);
                }
            }
            return Convert.ToString(randomWord);
        }
    }
}
