using System;
using System.Windows.Controls;
using System.Windows.Media;

using LiveCharts;
using LiveCharts.Wpf;

namespace Wpf.CartesianChart.PointStroke
{
    /// <summary>
    /// Interaction logic for WindowAxisExample.xaml
    /// </summary>
    public partial class PointStrokeExample : UserControl
    {
        public PointStrokeExample()
        {
            InitializeComponent();

            SeriesCollection = GenerateSeriesCollection();

            DataContext = this;
        }

        private SeriesCollection GenerateSeriesCollection()
        {
            var series1 = new double[] {2, 4, 6, 8, 1};

            var series2 = new [] { double.NaN,
                                          series1[1],
                                          double.NaN,
                                          double.NaN,
                                          series1[4]
            };

            var series3 = new[] { double.NaN,
                                         double.NaN,
                                         series1[2],
                                         double.NaN,
                                         double.NaN
            }; 

            return new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double>(series1)
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double>(series2),
                    PointStroke = Brushes.Red
                },
                new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double>(series3),
                    PointStroke = Brushes.Green,
                    PointForeground = Brushes.Yellow
                }
            };
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}
