using System;
using System.Collections.Generic;
using System.Text;

namespace NeuNets
{
    public class NeuralLayer
    {
        private int size;
        public NeuralLayer()
        {
            this.size = 0;
        }

        public NeuralLayer(int size)
        {
            if (size < 0) throw new ArgumentOutOfRangeException();
            this.size = size;
        }

        public int getSize() { return this.size; }
    }
}
