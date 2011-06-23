using System.Data.Linq.Mapping;
using FluentNHibernate.Mapping;
using VehicleGarage.DBCStructures;
using VehicleGarage.SQLStores;

namespace VehicleGarage.SQLStructures
{
    public class CreatureTemplate
    {
        /// <summary>
        /// Only relevant variables
        /// </summary>
        public virtual uint Id { get; private set; }
        public virtual string Name { get; set; }
        public virtual uint NPCFlag { get; set; }
        public virtual uint UnitFlags { get; set; }
        public virtual uint DynamicFlags { get; set; }
        public virtual uint VehicleId { get; set; }
        public virtual string AIName { get; set; }
        public virtual uint InhabitType { get; set; }
        public virtual string ScriptName { get; set; }
        public virtual uint WDBVerified { get; set; }
    }

    public class CreatureTemplateMap : ClassMap<CreatureTemplate>
    {
        public CreatureTemplateMap()
        {
            Id(x => x.Id, "entry");
            Map(x => x.Name, "name");
            Map(x => x.NPCFlag, "npcflag");
            Map(x => x.UnitFlags, "unit_flags");
            Map(x => x.DynamicFlags, "dynamicflags");
            Map(x => x.VehicleId, "VehicleId");
            Map(x => x.AIName, "AIName");
            Map(x => x.InhabitType, "InhabitType");
            Map(x => x.ScriptName, "ScriptName");
            Map(x => x.WDBVerified, "WDBVerified");
            Table("creature_template");
        }
    }
}
