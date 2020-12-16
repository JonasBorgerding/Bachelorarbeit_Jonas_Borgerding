using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace CSharpPerformanceTest
{
    class Performance_Test
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            var databaseTimes = new List<long>();
            new DatabasePerformanceTest().Execute();
            for (int i = 0; i < 500; i++)
            {
                stopwatch.Restart();
                new DatabasePerformanceTest().Execute();
                stopwatch.Stop();
                databaseTimes.Add(stopwatch.ElapsedMilliseconds);
            }
            var databaseAverage = databaseTimes.Sum() * 1d / databaseTimes.Count;
            Console.WriteLine($"Die durchschnittliche Zeit für die Datenbankabfrage beträgt: {databaseAverage/1000} Sekunden");
            var iniFileTimes = new List<long>();
            new IniPerformanceTest().Execute();
            for (int i = 0; i < 500; i++)
            {
                stopwatch.Restart();
                new IniPerformanceTest().Execute();
                stopwatch.Stop();
                iniFileTimes.Add(stopwatch.ElapsedMilliseconds);
            }
            var iniFileAverage = iniFileTimes.Sum() * 1d / iniFileTimes.Count;
            Console.WriteLine($"Die durchschnittliche Zeit für die INI Datei einlesen, Daten ändern und in die Datei schreiben beträgt: {iniFileAverage/1000} Sekunden");
        }
    }
}