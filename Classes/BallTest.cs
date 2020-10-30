using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class BallTest
    {

        private int size;
        private int color;
        private int thrown;

        public BallTest()
        {

        }

        public BallTest(int size, int color)
        {
            this.size = size;
            this.color = color;
        }

        public BallTest(int size, int color, int thrown)
        {
            this.size = size;
            this.color = color;
            this.thrown = thrown;
        }

        public void Pop()
        {
            this.size = 0;
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
