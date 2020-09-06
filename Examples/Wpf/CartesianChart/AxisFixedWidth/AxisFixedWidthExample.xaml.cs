using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace Wpf.CartesianChart.AxisFixedWidth
{
    /// <summary>
    /// Interaction logic for WindowAxisExample.xaml
    /// </summary>
    public partial class AxisFixedWidthExample : UserControl
    {
        private readonly Random _random;
        private readonly Brush[] _brushes = {
            Brushes.Aqua,
            Brushes.YellowGreen,
            Brushes.HotPink,
            Brushes.Gold,
            Brushes.Crimson,
            Brushes.DodgerBlue,
            Brushes.CadetBlue,
            Brushes.DarkSlateBlue
        };
        public AxisFixedWidthExample()
        {
            InitializeComponent();

            _random = new Random();

            ChartOneSeriesCollection = GenerateSeriesCollection();
            ChartTwoSeriesCollection = GenerateSeriesCollection();
            ChartThreeSeriesCollection = GenerateSeriesCollection();

            DataContext = this;
        }

        private SeriesCollection GenerateSeriesCollection()
        {
            return new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<int>(RandomArray(5, 10)),
                    Stroke = RandomBrush()

                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<int>( RandomArray(5, 10)),
                    Stroke = RandomBrush()
                }
            };

        }

        private IEnumerable<int> RandomArray(int size, int range)
        {

            var array = new int[size];

            for (var i = 0; i < size; i++)
            {
                array[i] = _random.Next(0, range);
            }

            return array;
        }

        private Brush RandomBrush()
        {
            var random = _random.Next(_brushes.Length);

            return _brushes[random];
        }

        public SeriesCollection ChartOneSeriesCollection { get; set; }
        public SeriesCollection ChartTwoSeriesCollection { get; set; }
        public SeriesCollection ChartThreeSeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}
