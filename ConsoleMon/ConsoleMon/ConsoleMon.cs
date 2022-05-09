using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMon
    {
        private string EnemyName;
        private int EnemyHP;
        private int EnemyEnergy;

        internal void TakeDamge(int damage)
        {
            EnemyHP = EnemyHP - damage;
            //for (int damage = 0; damage < 10; damage++)
            //{
            //   int EnemyHP = 0;
            //    EnemyHP += damage;
            //    Console.WriteLine(EnemyHP);
            //
            //    EnemyHP = EnemyHP - damage;
            //}
        }
        internal void DepleteEnergy(int energy)
        {
            EnemyEnergy = EnemyEnergy - energy;
        }
    }
}
