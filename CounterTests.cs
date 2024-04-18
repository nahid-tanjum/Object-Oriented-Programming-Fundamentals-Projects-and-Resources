using NUnit.Framework;
using System.Diagnostics.Metrics;
using System;
using CounterTask;
using ClockTests;
using System.Reflection;

namespace ClockTests
{
    [TestFixture]
    public class CounterTests
    {
        [Test]
        public void InitialisingCounterStartsAt0()
        {
            Counter counter = new Counter("test");
            Assert.AreEqual(0, counter.Ticks);
        }

        [Test]
        public void IncrementingCounterAddsOneToTheCount()
        {
            Counter counter = new Counter("test");
            counter.Increment();
            Assert.AreEqual(1, counter.Ticks);
        }

        [Test]
        public void IncrementingCounterMultipleTimesIncreasesTheCountToMatch()
        {
            Counter counter = new Counter("test");
            counter.Increment();
            counter.Increment();
            counter.Increment();
            Assert.AreEqual(3, counter.Ticks);
        }

        [Test]
        public void ResettingCounterSetsTheCountTo0()
        {
            Counter counter = new Counter("test");
            counter.Increment();
            counter.Reset();
            Assert.AreEqual(0, counter.Ticks);
        }
    }
}
