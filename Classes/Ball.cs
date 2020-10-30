using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Ball
    {        

        private int size;
        private Color color;
        private int thrown;

        public Ball ()
        {

        }

        public Ball (int size, Color color)
        {
            this.size = size;
            this.color = color;
        }

        public Ball (int size, Color color, int thrown)
        {
            this.size = size;
            this.color = color;
            this.thrown = thrown;
        }

        public void Pop(int size)
        {
            size = 0;
            this.size = size;
        }

        public void Throw(int thrown)
        {
            if (this.size == 0)
            {
                thrown += 1;
                this.thrown = thrown;
            }
        }

    }
}
