using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IniParser;
namespace CSharpPerformanceTest
{
    public class IniPerformanceTest
    {
        class IniEntry
        {
            public string SECTION { get; set; }
            public string KEY { get; set; }
            public string VALUE { get; set; }
            public IniEntry(string SECTION, string KEY, string VALUE)
            {
                this.KEY = KEY;
                this.SECTION = SECTION;
                this.VALUE = VALUE;
            }
        }
        public void Execute()
        {
            var iniEntries = new List<IniEntry>();
            try
            {
                var parser = new FileIniDataParser();
                var ini = parser.ReadFile("performance_test.ini", Encoding.UTF8);
                var sections = ini.Sections;
                foreach (var sectionName in sections)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        iniEntries.Add(new IniEntry(sectionName.SectionName, sectionName.SectionName + i, ini[sectionName.SectionName][sectionName.SectionName + i]));
                    }
                    var lastEntry = iniEntries.Last();
                    ini[lastEntry.SECTION][lastEntry.KEY] = "Testing around";
                    parser.WriteFile("performance_test.ini", ini, Encoding.UTF8);
                    ini[lastEntry.SECTION][lastEntry.KEY] = lastEntry.VALUE;
                    parser.WriteFile("performance_test.ini", ini, Encoding.UTF8);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}