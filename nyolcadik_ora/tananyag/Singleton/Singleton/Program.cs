using System;
using System.Threading;

namespace Singleton
{
    public interface ISingleton
    {
        ISingleton GetSingleton();
    }

    public class Singleton : ISingleton
    {
        private Singleton()
        {
        }

        private static readonly Singleton instance = new Singleton();
        public static Singleton Instance => instance;

        public ISingleton GetSingleton()
        {
            return instance;
        }
    }


    internal class Program
    {
        //Singleton pattern 


        static void Main(string[] args)
        {
            var singletonObject = Singleton.Instance.GetSingleton();
        }
    }
}
