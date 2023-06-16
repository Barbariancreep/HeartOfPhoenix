using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class DivStatsRow : ObservableObject
    {
        private string baseStat;
        private string combatStat;
        private string equipmentCost;

        public string BaseStat { get => baseStat; set => SetProperty(ref baseStat, value); }
        public string CombatStat { get => combatStat; set => SetProperty(ref combatStat, value); }
        public string EquipmentCost { get => equipmentCost; set => SetProperty(ref equipmentCost, value); }
    }
}
