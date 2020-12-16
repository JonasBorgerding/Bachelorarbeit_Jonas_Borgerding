class Performance_Test {
    static void main(String[] args) {
        def databaseTimes = []
        def iniFileTimes = []
        new Database_Performance_Test().executeTest()
        for (i in (0..500)) {
            def start = System.currentTimeMillis()
            new Database_Performance_Test().executeTest()
            databaseTimes += (System.currentTimeMillis() - start)
        }
        def databaseAverage = databaseTimes.sum() / (1d * databaseTimes.size())
        println "Die durchschnittliche Zeit für die Datenbankabfrage beträgt: ${databaseAverage / 1000} Sekunden"

        new INI_Performance_Test().executeTest()
        for (i in (0..500)) {
            def start = System.currentTimeMillis()
            new INI_Performance_Test().executeTest()
            iniFileTimes += System.currentTimeMillis() - start
        }
        def iniAverage = iniFileTimes.sum() / (1d * iniFileTimes.size())
        System.out.printf("Die durchschnittliche Zeit für die INI Datei einlesen und ändern beträgt: ${iniAverage / 1000} Sekunden")
    }
}