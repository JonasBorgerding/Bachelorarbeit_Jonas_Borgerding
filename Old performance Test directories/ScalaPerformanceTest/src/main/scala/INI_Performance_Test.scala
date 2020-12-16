import org.ini4j.Ini

import java.io.{FileReader, FileWriter, IOException}
import scala.collection.mutable.ListBuffer

class INI_Performance_Test {
  class IniEntry(private var SECTION: String, private var KEY: String, private var VALUE: String){
    def getSECTION: String = SECTION

    def setSECTION(SECTION: String): Unit = {
      this.SECTION = SECTION
    }

    def getKEY: String = KEY

    def setKEY(KEY: String): Unit = {
      this.KEY = KEY
    }

    def getVALUE: String = VALUE

    def setVALUE(VALUE: String): Unit = {
      this.VALUE = VALUE
    }
  }

  def execute(): Unit = {
    val iniEntries = new ListBuffer[IniEntry]
    try {
      val ini: Ini = new Ini(new FileReader("performance_test.ini"))
      val sections = ini.keySet()
      sections.forEach(sectionName => {
        for (i <- 1 until 5){
          iniEntries += new IniEntry(sectionName, sectionName + i, ini.get(sectionName, sectionName + i))
        }
        val lastEntry = iniEntries.last
        ini.put(lastEntry.getSECTION, lastEntry.getKEY, "Testing around")
        ini.store(new FileWriter("performance_test.ini"))
        ini.put(lastEntry.getSECTION, lastEntry.getKEY, lastEntry.getVALUE)
        ini.store(new FileWriter("performance_test.ini"))
      })
    }
    catch {
      case e: IOException => e.printStackTrace()
    }
  }
}
