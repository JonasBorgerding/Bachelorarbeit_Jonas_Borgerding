fun main() {
    val databaseTimes = mutableListOf<Long>()
    val iniFileTimes = mutableListOf<Long>()
    Database_Performance_Test().execute()
    for (i in 0..500) {
        println(i)
        val start = System.currentTimeMillis()
        Database_Performance_Test().execute()
        databaseTimes += System.currentTimeMillis() - start
    }
    val databaseAverage = databaseTimes.sum() * 1.toDouble() / databaseTimes.size
    println("Die durchschnittliche Zeit für die Datenbankabfrage beträgt: ${databaseAverage / 1000} Sekunden")

    INI_Performance_Test().execute()
    for (i in 0..500) {
        val start = System.currentTimeMillis()
        INI_Performance_Test().execute()
        iniFileTimes += System.currentTimeMillis() - start
    }
    val iniFileAverage = iniFileTimes.sum() * 1.toDouble() / iniFileTimes.size
    println("Die durchschnittliche Zeit für die INI Datei einlesen und ändern beträgt: ${iniFileAverage / 1000} Sekunden")
}