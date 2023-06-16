using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary;

namespace HeartOfPhoenix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }
    }

    public class MainWindowViewModel : ObservableDependencyObject
    {
        private ObservableCollection<DivStatsRow> divStatsRows = new ObservableCollection<DivStatsRow>();
        public ObservableCollection<DivStatsRow> DivStatsRows { get => divStatsRows; set => SetProperty(ref divStatsRows, value); }

        public MainWindowViewModel()
        {
            DivStatsRows.Add(new DivStatsRow() { BaseStat = "Max Speed: ", CombatStat = "Soft Attack: " });
        }
    }
}
