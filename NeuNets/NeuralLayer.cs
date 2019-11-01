using System;
using System.Collections.Generic;
using System.Text;

namespace NeuNets
{
    public class NeuralLayer
    {
        private int size;
        private NeuralLayer sublayer;
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

        public void addLayer(NeuralLayer otherLayer)
        {
            if(this.getSize() == 0)
            {
                throw new InvalidOperationException();
            }
            this.sublayer = otherLayer;
        }
    }
}
