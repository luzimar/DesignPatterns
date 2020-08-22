using Demonstration.Singleton;
using System;
using System.Threading.Tasks;

namespace Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Singleton

            Parallel.Invoke(
                () => CreatePeople1(),
                () => CreatePeople2()
            );

            #endregion



            Console.ReadKey();

        }

        private static void CreatePeople1()
        {
            People people1 = People.GetInstance;
            people1.ShowDetail("People 1 was created");
        }

        private static void CreatePeople2()
        {
            People people2 = People.GetInstance;
            people2.ShowDetail("People 2 was created");
        }
    }
}
