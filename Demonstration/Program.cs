using Demonstration.Singleton;
using System;

namespace Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Singleton

            People people1 = People.GetInstance;

            People people2 = People.GetInstance;

            People people3 = People.GetInstance;

            #endregion



            Console.ReadKey();

        }
    }
}
