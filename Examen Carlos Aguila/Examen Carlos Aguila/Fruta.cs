using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Carlos_Aguila
{
    public class Fruta
    {
        public int posicion_X;
        public int posicion_Y;
        public int puntaje_a_entregar;
        public Fruta(int mix, int miy, int miptj)
        {
            mix = posicion_X;
            miy = posicion_Y;
            miptj = puntaje_a_entregar;
        }
        public void reaparecer()
        {
            Random random = new Random();
            this.posicion_X = random.Next(0, 200);
            this.posicion_Y = random.Next(0, 200);
        }
    }
}
