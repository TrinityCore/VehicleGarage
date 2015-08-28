using System;
using System.Collections.Generic;
using System.Data;
using VehicleGarage.Extensions;
using VehicleGarage.Properties;
using VehicleGarage.SQLStructures;
using MySql.Data.MySqlClient;

namespace VehicleGarage.SQLStores
{
    public static class SQLReader
    {
        private static MySqlConnection _conn;

        public static void Connect()
        {
            _conn = new MySqlConnection(ConnectionString);
            _conn.Open();
            if (_conn.State != ConnectionState.Open)
                throw new Exception();
        }

        public static void Disconnect()
        {
            if (_conn != null)
                _conn.Close();
        }

        public static Dictionary<int, CreatureTemplate> LoadCreatureTemplates()
        {
            var dict = new Dictionary<int, CreatureTemplate>();

            using (var command = new MySqlCommand("SELECT entry,name,npcflag,unit_flags,dynamicflags,VehicleId,AIName,InhabitType,ScriptName,VerifiedBuild FROM creature_template WHERE VehicleId <>0", _conn))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var creatureTemplate = new CreatureTemplate
                                                    {
                                                        Id = reader[0].ToUInt32(),
                                                        Name = reader[1].ToString(),
                                                        NPCFlag = reader[2].ToUInt32(),
                                                        UnitFlags = reader[3].ToUInt32(),
                                                        DynamicFlags = reader[4].ToUInt32(),
                                                        VehicleId = reader[5].ToUInt32(),
                                                        AIName = reader[6].ToString(),
                                                        InhabitType = reader[7].ToUInt32(),
                                                        ScriptName = reader[8].ToString(),
                                                        VerifiedBuild = reader[9].ToUInt32()
                                                    };

                        dict[creatureTemplate.Id.ToInt32()] = creatureTemplate;
                    }
                }
            }

            return dict;
        }

        public static Dictionary<uint,  List<int>> LoadSpellClick()
        {
            var dict = new Dictionary<uint, List<int>>();

            using (var command = new MySqlCommand("SELECT npc_entry,spell_id FROM npc_spellclick_spells AS sc LEFT JOIN creature_template AS ct ON sc.npc_entry = ct.entry WHERE ct.VehicleId <>0", _conn))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var npc = reader[0].ToUInt32();
                        var spell = reader[1].ToInt32();
                        if (!dict.ContainsKey(npc))
                            dict.Add(npc, new List<int>());
                        dict[npc].Add(spell);
                    }
                }
            }

            return dict;
        }

        public static Dictionary<uint, List<VehicleTemplateAccessory>> LoadVehicleAccessories()
        {
            var dict = new Dictionary<uint, List<VehicleTemplateAccessory>>();

            using (var command = new MySqlCommand("SELECT entry,accessory_entry, CAST(seat_id AS UNSIGNED INTEGER) FROM vehicle_template_accessory", _conn))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var vehicle = reader[0].ToUInt32();

                        var accessory = new VehicleTemplateAccessory
                                            {
                                                AccessoryEntry = reader[1].ToUInt32(),
                                                SeatId = reader[2].ToByte(),
                                            };

                        if (!dict.ContainsKey(vehicle))
                            dict.Add(vehicle, new List<VehicleTemplateAccessory>());
                        dict[vehicle].Add(accessory);
                    }
                }
            }

            return dict;
        }

        private static String ConnectionString
        {
            get
            {
                return String.Format("Server={0};Port={1};Uid={2};Pwd={3};Database={4};character set=utf8;Connection Timeout=10",
                    Settings.Default.Host,
                    Settings.Default.Port,
                    Settings.Default.User,
                    Settings.Default.Pass,
                    Settings.Default.WorldDB);
            }
        }
    }
}
