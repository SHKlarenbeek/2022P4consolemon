using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Skill
    {
        private string MoveName;
        private int MoveDMG;
        private int MoveEnergy;

        internal void UseOn(ConsoleMon caster, ConsoleMon target)
        {
            caster.DepleteEnergy(MoveEnergy);
            target.TakeDamge(MoveDMG);
        }
    }
}
