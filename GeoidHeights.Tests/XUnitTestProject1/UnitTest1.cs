using GeoidHeightsDotNet;
using System;
using Xunit;
using Debug = System.Diagnostics.Debug;

namespace GeoidHeight.Tests
{
    public class TestGroup
    {
        [Theory]
        [InlineData(38.6281550, 269.7791550, -31.629207585055408)]
        [InlineData(-14.621217, 305.021114, -2.966004569710332)]
        [InlineData(46.874319, 102.448729, -43.572016370945285)]
        [InlineData(-23.617446, 133.874712, 15.867758550982687)]
        [InlineData(38.625473, 359.999500, 50.06503036214729)]
        [InlineData(-00.466744, 0.002300, 17.329539958821204)]
        public void ReturnsExpectedUndulationValues(double lat, double lon, double expected)
        {
            double h = GeoidHeights.undulation(lat, lon);
            Console.WriteLine(h);
            Debug.WriteLine(h);
            Assert.Equal(expected, h, 13);
        }
    }
}
