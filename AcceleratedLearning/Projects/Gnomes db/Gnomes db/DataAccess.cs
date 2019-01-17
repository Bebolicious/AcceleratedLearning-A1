using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Gnomes_db
{
    public class DataAccess
    {
        private const string conString = "Server = (localdb)\\mssqllocaldb; Database = GnomeDb";

        internal List<Gnome> GetGnomesFromDatabase()
        {
            var sql = @"SELECT Name, Hasbeard, Isevil, Temper, Racetype
                        FROM Gnome
						RIGHT JOIN Race ON Gnome.RaceId = Race.RaceId;";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<Gnome>();

                while (reader.Read())
                {
                    var Newgnome = new Gnome
                    {
                        Name = reader.GetSqlString(0).Value,
                        Hasbeard = reader.GetSqlBoolean(1).Value,
                        Isevil = reader.GetSqlBoolean(2).Value,
                        Temper = reader.GetSqlInt32(3).Value,
                        Race = reader.GetSqlString(4).Value
                    };
                    list.Add(Newgnome);
                }

                return list;

            }
        }
    }
}
