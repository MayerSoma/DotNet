using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.DesignPatterns.Creational
{
    /// <summary>
    /// The code above implicitly uses LazyThreadSafetyMode.ExecutionAndPublication as
    /// the thread safety mode for the Lazy<VoteMachine>>. The Lazy<T> make the lazy 
    /// instantiation simple and performs well. 
    /// It also allows you to check whether or not the instance has been created yet 
    /// with the IsValueCreated property.
    /// </summary>
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> _instance = new(() => new Singleton());
        private int _totalVotes = 0;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void RegisterVote()
        {
            _totalVotes += 1;
            Console.WriteLine("Registered Vote #" + _totalVotes);
        }

        public int TotalVotes
        {
            get
            {
                return _totalVotes;
            }
        }
    }
}
