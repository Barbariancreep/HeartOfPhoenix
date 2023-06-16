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
    public partial class DivDesigner : UserControl
    {
        public DivDesigner()
        {
            InitializeComponent();

            // Sort out some DataGrid properties 
            DataGrid[] DataGrids = {
                DivStatsGrid
            };

            for (int i = 0; i < DataGrids.Length; i++)
            { // generally good for all tables
                DataGrids[i].AutoGenerateColumns = false;
                DataGrids[i].CanUserAddRows = false;
                DataGrids[i].CanUserDeleteRows = false;
                DataGrids[i].CanUserSortColumns = false;
                DataGrids[i].CanUserResizeRows = false;
                DataGrids[i].IsReadOnly = true;
            }

            // dont let the user touch this one
            DivStatsGrid.IsReadOnly = true;
            DivStatsGrid.IsHitTestVisible = false;
        }
    }
}
