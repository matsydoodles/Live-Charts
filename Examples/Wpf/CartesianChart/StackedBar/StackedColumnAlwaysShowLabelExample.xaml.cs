using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Wpf.CartesianChart
{
    /// <summary>
    /// Interaction logic for StackedColumnAlwaysShowLabelExample.xaml
    /// </summary>
    public partial class StackedColumnAlwaysShowLabelExample
    {
        public StackedColumnAlwaysShowLabelExample()
        {
            InitializeComponent();

            SeriesCollectionAlwaysShowPercentage = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(1)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Percentage,
                    AlwaysShowLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(250)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Percentage,
                    AlwaysShowLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Percentage,
                    AlwaysShowLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(900)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Percentage,
                    AlwaysShowLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                    new ObservableValue(15)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Percentage,
                    AlwaysShowLabels = true
                }
            };

            SeriesCollectionPercentage = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(1)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Percentage,
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(250)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Percentage,
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Percentage
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(900)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Percentage
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(15)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Percentage
                }
            };

            SeriesCollectionAlwaysShowValues = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(1)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Values,
                    AlwaysShowLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(250)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Values,
                    AlwaysShowLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Values,
                    AlwaysShowLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(900)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Values,
                    AlwaysShowLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                    new ObservableValue(15)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Values,
                    AlwaysShowLabels = true
                }
            };

            SeriesCollectionValues = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(1)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Values
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(250)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Values
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Values
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(900)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Values
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(15)
                    },
                    DataLabels = true,
                    StackMode = StackMode.Values
                }
            };

            Labels = new[]
            {
                "Jan", "Feb","Mar", "Apr", "May", "Jun", "Jul", "Ago"
            };

            DataContext = this;
        }

        public SeriesCollection SeriesCollectionAlwaysShowPercentage { get; set; }
        public SeriesCollection SeriesCollectionPercentage { get; set; }
        public SeriesCollection SeriesCollectionAlwaysShowValues { get; set; }
        public SeriesCollection SeriesCollectionValues { get; set; }
        public string[] Labels { get; set; }
    }
}
