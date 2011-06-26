using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleGarage.SQLStructures;

namespace VehicleGarage.SQLStores
{
    public static class SQL
    {
        /// <summary>
        /// Primary key being Entry
        /// </summary>
        public static Dictionary<int, CreatureTemplate> CreatureTemplate;

        public static Dictionary<uint, List<int>> SpellClick;
        public static Dictionary<uint, List<VehicleTemplateAccessory>> Accessories;
    }
}
