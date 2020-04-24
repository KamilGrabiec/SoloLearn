using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class WHCharacterCreator
    {
        private int lvl;
        private string race;
        private int hp;
        private int mn;

        public WHCharacterCreator(string rc)
        {
            race = rc;
            lvl = 1;
            if (race == "elf") { hp = 30; mn = 30; }
            else if (race == "człowiek") { hp = 40; mn = 20; }
            else if (race == "krasnolud") { hp = 50; mn = 10; }
            else if (race == "niziołek") { hp = 20; mn = 30; }
        }


        public void GetStats(out int returnHp, out int returnMn, out int returnLvl, out string returnRace)
        {
            returnHp = hp;
            returnMn = mn;
            returnLvl = lvl;
            returnRace = race;
        }
    }
}
