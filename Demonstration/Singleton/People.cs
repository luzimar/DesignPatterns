using Demonstration.Common.Enumerations;
using System;

namespace Demonstration.Singleton
{
    public sealed class People
    {
        private static int counter = 0;

        public string Name { get; private set; }
        public int Age { get; private set; }
        public EGenre Genre { get; private set; }

        private static readonly Lazy<People> _instance = new Lazy<People>(() => new People());
        public static People GetInstance
        {
            get
            {
                return _instance.Value;
            }
        }

        private People()
        {
            counter++;
            Console.WriteLine($"Called {counter} time(s)");
        }

        public void ShowDetail(string message)
        {
            Console.WriteLine(message);
        }

    }
}
