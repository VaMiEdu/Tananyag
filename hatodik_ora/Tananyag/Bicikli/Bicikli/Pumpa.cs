using System;
using System.Collections.Generic;
using System.Text;

namespace Bicikli
{
    class Pumpa
    {
        public void Felfuj(Kerek kerek)
        {
            kerek.Nyomas += 1;
        }

        public void Felfuj(List<Kerek> kerekek, double idealisNyomas)
        {
            foreach (var kerek in kerekek)
            {
                if (kerek.Nyomas < idealisNyomas)
                {
                    kerek.Nyomas = idealisNyomas;
                }
            }
        }
    }
}
