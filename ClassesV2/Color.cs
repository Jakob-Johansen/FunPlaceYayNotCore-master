using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesV2
{
    class Color
    {

        // Instance Variables
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        public int GetRed()
        {
            return red;
        }
        public void SetRed(int red)
        {
            this.red = red;
        }

        public int GetGreen()
        {
            return red;
        }
        public void SetGreen(int green)
        {
            this.green = green;
        }

        public int GetBlue()
        {
            return blue;
        }
        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        public int GetGrayscale()
        {
            return (red + green + blue) / 3;
        }

    }
}
