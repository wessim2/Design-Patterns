using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Example.Enemies
{
    public class Ghost : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Ghost Attack");
        }

        public void Scream()
        {
            Console.WriteLine("Ghost Scream");
        }
    }
}
