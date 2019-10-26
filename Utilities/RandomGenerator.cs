using System;


namespace Homework.Utilities
{
    public static class RandomGenerator
    {
        public static string GenerateMail()
        {
           return $"jenny+{Guid.NewGuid()}@gmail.com";
        }
    }
}
