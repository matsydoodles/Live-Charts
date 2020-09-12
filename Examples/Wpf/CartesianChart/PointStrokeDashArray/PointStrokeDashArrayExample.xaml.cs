using System;
using System.Windows.Controls;
using System.Windows.Media;

using LiveCharts;
using LiveCharts.Wpf;

namespace Wpf.CartesianChart.PointStrokeDashArray
{
    /// <summary>
    /// Interaction logic for WindowAxisExample.xaml
    /// </summary>
    public partial class PointStrokeDashArrayExample : UserControl
    {
        public PointStrokeDashArrayExample()
        {
            InitializeComponent();

            SeriesCollection = GenerateSeriesCollection();

            DataContext = this;
        }

        private SeriesCollection GenerateSeriesCollection()
        {
            var series1 = new double[] { 5, 7, 6, 8, 4 };

            var series1Marking = new [] { double.NaN,
                                          series1[1],
                                          double.NaN,
                                          series1[3],
                                          double.NaN,
            };

            var series2 = new double[] { 2, 4, 1, 5, 3 };

            return new SeriesCollection
            {
                new LineSeries
                {
                    Title = "No StrokeDashArray",
                    Values = new ChartValues<double>(series1),
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "PointStrokeDashArray",
                    Values = new ChartValues<double>(series1Marking),
                    PointGeometrySize = 15, 
                    PointForeground = Brushes.Transparent,
                    PointStrokeDashArray = new DoubleCollection { 2, 1 }
                },
                new LineSeries
                {
                    Title = "Point & Series StrokeDashArray",
                    Values = new ChartValues<double>(series2),
                    PointGeometrySize = 15,
                    StrokeDashArray = new DoubleCollection { 1 },
                    PointStroke = Brushes.Green,
                    PointForeground = Brushes.Transparent,
                    PointStrokeDashArray = new DoubleCollection { 0.5, 1 }
                }
            };
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}