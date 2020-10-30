using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesV2
{
    class Ballon
    {

        private int size;
        private Color color;
        private int thrown;

        // Skal ikke bruges.
        //public int Size { get; private set; }
        //public int Color { get; private set; }
        //public int Thrown { get; private set; }

        public Ballon()
        {

        }

        public Ballon(int size, Color color)
        {
            this.size = size;
            this.color = color;

            // Skal ikke bruges.
            //this.Size = size;
        }

        public Ballon(int size, Color color, int thrown)
        {
            this.size = size;
            this.color = color;
            this.thrown = thrown;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if (this.size != 0)
            {
                this.thrown += 1;
            }
        }

        public int ThrownQuantity()
        {
            return this.thrown;
        }

        public int GetSize()
        {
            return this.size;
        }

    }
}
