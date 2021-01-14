import scala.collection.mutable.ListBuffer

object Performance_Test {
  def main(args: Array[String]): Unit = {
    val databaseTimes, iniFileTimes = new ListBuffer[Long]
    new Database_Performance_Test().execute()
    for (_ <- 0 until 500) {
      val start = System.currentTimeMillis()
      new Database_Performance_Test().execute()
      databaseTimes += System.currentTimeMillis() - start
    }
    val databaseAverage = databaseTimes.sum[Long] * 1d / databaseTimes.size
    println(s"Die durchschnittliche Zeit für die Datenbankabfrage beträgt: ${databaseAverage / 1000} Sekunden")

    new INI_Performance_Test().execute()
    for (_ <- 0 until 500) {
      val start = System.currentTimeMillis()
      new INI_Performance_Test().execute()
      iniFileTimes += System.currentTimeMillis() - start
    }
    val iniAverage = iniFileTimes.sum[Long] * 1d / iniFileTimes.size
    println(s"Die durchschnittliche Zeit für die INI Datei einlesen und ändern beträgt: ${iniAverage / 1000} Sekunden")
  }
}
