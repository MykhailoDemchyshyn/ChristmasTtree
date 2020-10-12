using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TestTask02a
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SnowEngine snow;
        private short toyFigure;
        private Color toyColor = Colors.White;

        public MainWindow()
        {
            InitializeComponent();
            snow = new SnowEngine(canvas, "pack://application:,,,/Graphics/snow1.png");
               
        }

        private void Ball_Click(object sender, RoutedEventArgs e)
        {
            toyFigure = 1;
        }

        private void Tree_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(this);
            double x = p.X;
            double y = p.Y;
            if (toyFigure == 1)
            {
                Ellipse ball = new Ellipse();
                ball.Height = 20;
                ball.Width = 20;
                ball.Margin = new Thickness(x - 12.5, y, 0, 0);
                ball.Fill = new SolidColorBrush(toyColor);
                ball.Stroke = Brushes.White;
                ball.VerticalAlignment = VerticalAlignment.Top;
                ball.HorizontalAlignment = HorizontalAlignment.Left;
                toys.Children.Add(ball);

            }
            if (toyFigure == 2)
            {

                Rectangle rect = new Rectangle();
                rect.Height = 20;
                rect.Width = 20;
                rect.Margin = new Thickness(x - 12.5, y, 0, 0);
                rect.Fill = new SolidColorBrush(toyColor);
                rect.Stroke = Brushes.White;
                rect.VerticalAlignment = VerticalAlignment.Top;
                rect.HorizontalAlignment = HorizontalAlignment.Left;
                toys.Children.Add(rect);
                
            }
            if (toyFigure == 3)
            {
                //25,0,31,20,50,20,35,32,45,50,25,40,5,50,15,32,0,20,19,20
                Polygon star = new Polygon();
                PointCollection pointCollection = new PointCollection();
                pointCollection.Add(new Point(25, 0));
                pointCollection.Add(new Point(45, 50));
                pointCollection.Add(new Point(5, 50));
               
                star.Fill = new SolidColorBrush(toyColor);
                star.Points = pointCollection;
                star.Stroke = Brushes.White;
                Canvas c = new Canvas();
                c.Children.Add(star);
                c.Margin = new Thickness(x - 25, y, 0, 0);
                c.VerticalAlignment = VerticalAlignment.Top;
                c.HorizontalAlignment = HorizontalAlignment.Left;
                toys.Children.Add(c);
            }
            
        }

        private void Gift_Click(object sender, RoutedEventArgs e)
        {
            toyFigure = 2;
        }

        private void Triangle_Click(object sender, RoutedEventArgs e)
        {
            toyFigure = 3;
        }


        private void Red_Click(object sender, RoutedEventArgs e)
        {
            toyColor = Colors.Red;
        }

       

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            toyColor = Colors.Yellow;
        }

        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            toyColor = Colors.Orange;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            toyColor = Colors.Blue;
        }

        

        private void Garland1_Click(object sender, RoutedEventArgs e)
        {
           

            List<Ellipse> botEllipses = GarlandGenerator(13, 470);
            int i = 50;
            foreach (var ellipse in botEllipses)
            {
                DoubleAnimationUsingKeyFrames animation = new DoubleAnimationUsingKeyFrames();

                LinearDoubleKeyFrame keyFrame1 = new LinearDoubleKeyFrame();
                keyFrame1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(i)); ;
                keyFrame1.Value = 0;
                LinearDoubleKeyFrame keyFrame2 = new LinearDoubleKeyFrame();
                keyFrame2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(i + 0.5)); ;
                keyFrame2.Value = 0.5;
                LinearDoubleKeyFrame keyFrame3 = new LinearDoubleKeyFrame();
                keyFrame3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(i + 1)); ;
                keyFrame3.Value = 1;
                animation.KeyFrames.Add(keyFrame1);
                animation.KeyFrames.Add(keyFrame2);
                animation.KeyFrames.Add(keyFrame3);

                //animation.AutoReverse = true;
                animation.Duration = TimeSpan.FromSeconds(26.5);
                animation.RepeatBehavior = RepeatBehavior.Forever;
                toys.Children.Add(ellipse);
                ellipse.BeginAnimation(OpacityProperty, animation);
                i++;
            }

            i = 0;
            List<Ellipse> midEllipses = GarlandGenerator(9, 330);
            foreach (var ellipse in midEllipses)
            {
                DoubleAnimationUsingKeyFrames animation = new DoubleAnimationUsingKeyFrames();

                LinearDoubleKeyFrame keyFrame1 = new LinearDoubleKeyFrame();
                keyFrame1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(i)); ;
                keyFrame1.Value = 0;
                LinearDoubleKeyFrame keyFrame2 = new LinearDoubleKeyFrame();
                keyFrame2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5 + i)); ;
                keyFrame2.Value = 0.5;
                LinearDoubleKeyFrame keyFrame3 = new LinearDoubleKeyFrame();
                keyFrame3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1 + i)); ;
                keyFrame3.Value = 1;
                animation.KeyFrames.Add(keyFrame1);
                animation.KeyFrames.Add(keyFrame2);
                animation.KeyFrames.Add(keyFrame3);

                //animation.AutoReverse = true;
                animation.Duration = TimeSpan.FromSeconds(18);
                animation.RepeatBehavior = RepeatBehavior.Forever;
                toys.Children.Add(ellipse);
                ellipse.BeginAnimation(OpacityProperty, animation);
                i++;
            }

            i = 0;
            List<Ellipse> topEllipses = GarlandGenerator(4, 170);
            foreach (var ellipse in topEllipses)
            {
                DoubleAnimationUsingKeyFrames animation = new DoubleAnimationUsingKeyFrames();

                LinearDoubleKeyFrame keyFrame1 = new LinearDoubleKeyFrame();
                keyFrame1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0 + i)); ;
                keyFrame1.Value = 0;
                LinearDoubleKeyFrame keyFrame2 = new LinearDoubleKeyFrame();
                keyFrame2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5 + i)); ;
                keyFrame2.Value = 0.5;
                LinearDoubleKeyFrame keyFrame3 = new LinearDoubleKeyFrame();
                keyFrame3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1 + i)); ;
                keyFrame3.Value = 1;
                animation.KeyFrames.Add(keyFrame1);
                animation.KeyFrames.Add(keyFrame2);
                animation.KeyFrames.Add(keyFrame3);

                //animation.AutoReverse = true;
                animation.Duration = TimeSpan.FromSeconds(8.5);
                animation.RepeatBehavior = RepeatBehavior.Forever;
                toys.Children.Add(ellipse);
                ellipse.BeginAnimation(OpacityProperty, animation);
                i++;
            }
        }

        

        private List<Ellipse> GarlandGenerator(int length, int height)
        {
            List<Brush> brushes = new List<Brush>();
            brushes.Add(Brushes.Red);
            brushes.Add(Brushes.Orange);
            brushes.Add(Brushes.Yellow);
            brushes.Add(Brushes.LightBlue);
            brushes.Add(Brushes.Blue);
            brushes.Add(Brushes.Violet);
            List<Ellipse> ellipses = new List<Ellipse>();
            for (int i = - length; i <= length; i++)
            {
                Ellipse ellipse = new Ellipse();
                ellipse.Width = 8;
                ellipse.Height = 8;
                ellipse.Stroke = Brushes.White;
                ellipse.Fill = brushes[Math.Abs(i) % 6];
                ellipse.VerticalAlignment = VerticalAlignment.Top;
                ellipse.HorizontalAlignment = HorizontalAlignment.Left;
                ellipse.Margin = new Thickness(i * 10 + 200, - 5.0 / (length + 4) * Math.Pow(i , 2) + height, 0, 0);
                ellipses.Add(ellipse);
            }
            return ellipses;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            toys.Children.Clear();
        }

        private void On_Click(object sender, RoutedEventArgs e)
        {
            snow.Start();
        }

        private void Off_Click(object sender, RoutedEventArgs e)
        {
            snow.Stop();
        }

        private void Tree_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
