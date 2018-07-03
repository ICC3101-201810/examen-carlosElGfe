using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Carlos_Aguila
{
    [Serializable]
    public class Usuario
    {
        public string name;
        public int score;
        public Usuario(string minamne,int miscore)
        {
            minamne = name;
            miscore = score;
        }
    }
}
