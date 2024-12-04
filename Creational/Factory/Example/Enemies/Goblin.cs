using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Example.Enemies
{
    public class Goblin : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Goblin Attack");
        }

        public void Scream()
        {
            Console.WriteLine("Goblin Scream");
        }
    }
}
