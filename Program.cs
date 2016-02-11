using System;
using System.Collections.Generic;
using System.Text;

namespace GeoidHeightsDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = GeoidHeights.undulation(38.6281550, 269.7791550);
            h = GeoidHeights.undulation(-14.621217, 305.021114);
            h = GeoidHeights.undulation(46.874319, 102.448729);
            h = GeoidHeights.undulation(-23.617446, 133.874712);
            h = GeoidHeights.undulation(38.625473, 359.999500);
            h = GeoidHeights.undulation(-00.466744, 0.002300);
        }
    }
}
