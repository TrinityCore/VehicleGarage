using System;
using System.Collections.Generic;
using VehicleGarage.Extensions;
using VehicleGarage.Properties;
using VehicleGarage.SQLStructures;
using MySql.Data.MySqlClient;

namespace VehicleGarage.SQLStores
{
    public static class SQLReader
    {
        public static Dictionary<int, CreatureTemplate> LoadCreatureTemplates()
        {
            var dict = new Dictionary<int, CreatureTemplate>();

            using (var conn = new MySqlConnection(ConnectionString))
            {
                var command =
                    new MySqlCommand(
                        "SELECT entry,name,npcflag,unit_flags,dynamicflags,VehicleId,AIName,InhabitType,ScriptName,WDBVerified FROM creature_template WHERE VehicleId <>0",
                        conn);
                
                conn.Open();

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
                                                       WDBVerified = reader[9].ToUInt32()
                                                   };

                        dict[creatureTemplate.Id.ToInt32()] = creatureTemplate;
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
