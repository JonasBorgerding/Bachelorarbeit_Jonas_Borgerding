using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace CSharpPerformanceTest
{
    public class DatabasePerformanceTest
    {
        class UnicodeEntry
        {
            public long ID { get; set; }
            public char UnicodeCharacter { get; set; }
            public long PREVIOUS { get; set; }
            public long NEXT { get; set; }

            public UnicodeEntry(long ID, char UnicodeCharacter, long PREVIOUS, long NEXT)
            {
                this.ID = ID;
                this.UnicodeCharacter = UnicodeCharacter;
                this.PREVIOUS = PREVIOUS;
                this.NEXT = NEXT;
            }
        }

        public void Execute()
        {
            var unicodeEntryList = new List<UnicodeEntry>();
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=unicode.sqlite;");
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM unicode;", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string resultString = reader.GetString(1);
                    unicodeEntryList.Add(new UnicodeEntry(
                        reader.IsDBNull(0) ? 0 : reader.GetInt64(0),
                        resultString.Length > 0 ? resultString[0] : ' ',
                        reader.IsDBNull(2) ? 0 : reader.GetInt64(2),
                        reader.IsDBNull(3) ? 0 : reader.GetInt64(3)
                    ));
                }
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}