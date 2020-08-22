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

        private static People _instance = null;
        public static People GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new People();
                return _instance;
            }
        }

        private People()
        {
            counter++;
            Console.WriteLine($"Called {counter} time(s)");
        }

    }
}
