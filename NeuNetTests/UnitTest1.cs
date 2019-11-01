using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeuNets;
using System;

namespace NeuNetTests
{
    [TestClass]
    public class NeuralLayerTest
    {
        [TestMethod]
        public void DefaultConstructorHasSize0()
        {
            NeuralLayer neuralLayer1 = new NeuralLayer();
            Assert.AreEqual(0, neuralLayer1.getSize());
        }

        [TestMethod]
        public void ParametrizedConstructorWithRangeChecks()
        {
            NeuralLayer nl = new NeuralLayer(1);
            Assert.AreEqual(1, nl.getSize());

            nl = new NeuralLayer(12);
            Assert.AreEqual(12, nl.getSize());

            nl = new NeuralLayer(0);
            Assert.AreEqual(0, nl.getSize());

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => nl = new NeuralLayer(-3));
        }

        [TestMethod]
        public void AddLayerToZeroSubLayersFails()
        {
            NeuralLayer nl = new NeuralLayer(0);
            Assert.ThrowsException<InvalidOperationException>(
                () => nl.addLayer(new NeuralLayer(2)));
        }
    }
}
