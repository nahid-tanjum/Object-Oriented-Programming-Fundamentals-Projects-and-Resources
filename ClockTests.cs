using NUnit.Framework;

namespace Clock
{
    public class ClockTests
    {
        private Clock clock;

        [SetUp]
        public void SetUp()
        {
            clock = new Clock();
        }

        [Test]
        public void TestClockInitalise()
        {
            Assert.IsTrue(clock.Hours == 0 && clock.Minutes == 0 && clock.Seconds == 0);
        }

        [Test]
        public void TestClockSingularTick()
        {
            clock.Tick();

            Assert.That(clock.Seconds, Is.EqualTo(1));
        }

        [Test]
        public void TestClockMultipleTicks()
        {
            int origCount = clock.Seconds;
            int noOfTicks = 5;
            for (int i = 0; i < noOfTicks; i++)
            {
                clock.Tick();
            }

            Assert.That(clock.Seconds, Is.EqualTo(origCount + noOfTicks));
        }

        [Test]
        public void TestClockSecondsTick()
        {
            for (int i = 0; i < 59; i++)
            {
                clock.Tick();
            }
            int secondLastCount = clock.Seconds;
            clock.Tick();
            int lastCount = clock.Seconds;

            Assert.IsTrue(secondLastCount == 59 && lastCount == 0);
        }

        [Test]
        public void TestClockMinutesTick()
        {
            for (int i = 0; i < 3599; i++)
            {
                clock.Tick();
            }
            int secondLastCount = clock.Minutes;
            clock.Tick();
            int lastCount = clock.Minutes;

            Assert.IsTrue(secondLastCount == 59 && lastCount == 0);
        }

        [Test]
        public void TestClockHoursTick()
        {
            for (int i = 0; i < 86399; i++)
            {
                clock.Tick();
            }
            int secondLastCount = clock.Hours;
            clock.Tick();
            int lastCount = clock.Hours;

            Assert.IsTrue(secondLastCount == 23 && lastCount == 0);
        }

        [Test]
        public void TestClockReset()
        {
            for (int i = 0; i < 1672; i++)
            {
                clock.Tick();
            }
            clock.Reset();

            Assert.IsTrue(clock.Hours == 0 && clock.Minutes == 0 && clock.Seconds == 0);
        }
    }
}