using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Health
    {
        public int Life { get; private set; }

        public Health()
        {
            Life = 5;
        }

        public Health(int life)
        {
            Life = life;
        }

        public void ReduceLife()
        {
            Life--;
        }
    }
}
