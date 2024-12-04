
namespace Creational.Factory.Example
{
    public abstract class Level
    {
        public abstract IEnemy CreateEnemy();
    
        public void EnemyReact()
        {
            IEnemy enemy = CreateEnemy();
            enemy.Attack();
            enemy.Scream();
        }
    }
}
