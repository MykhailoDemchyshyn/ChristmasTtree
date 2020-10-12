using System.Windows.Controls;

namespace TestTask02a
{
    internal class SnowInfo
    {
        public Image Flake { get; set; }

        public double VelocityY { get; set; }

        public double VelocityX { get; set; }

        public int Radius { get; set; }

        public SnowInfo(Image flake, double velocityY, int radius)
        {
            VelocityY = velocityY;
            Flake = flake;
            Flake.Width = radius;
            Radius = radius;
        }
    }
}
